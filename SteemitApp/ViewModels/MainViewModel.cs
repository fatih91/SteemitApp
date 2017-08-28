using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using System.Linq;
using MvvmCross.Core.Navigation;
using MvvmCross.Platform;

namespace SteemitApp.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IRepository repository;
        private readonly IMvxNavigationService navigation;

        public MainViewModel(IRepository Repository, IMvxNavigationService Navigation)
        {
            repository = Repository;
            navigation = Navigation;
        }
        
        public override async Task Initialize()
        {
            var result = await repository.LoadDiscussions(new DiscussionPayload("steem", "10"));
            if (result.StatusCode == System.Net.HttpStatusCode.OK) 
            {
                foreach (var discussion in result.Data)
                {
                    Discussions.Add(discussion);
                }
            }
        }

        public MvxObservableCollection<PostPresentation> Discussions { get; set; } = new MvxObservableCollection<PostPresentation>();

        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        private void ResetText()
        {
            Text = "Hello MvvmCross";

        }

        public IMvxCommand LoadMoreCommand => new MvxCommand(LoadMore);
        private async void LoadMore() 
        {
            var lastEntry = Discussions.LastOrDefault();
            if (lastEntry != null) 
            {
                var payload = new DiscussionPayload("steem", "10", lastEntry.Author, lastEntry.Permlink);
                var result = await repository.LoadDiscussions(payload);
                if (result.StatusCode == System.Net.HttpStatusCode.OK) 
                {
                    for (int i = 1; i < result.Data.Count; i++)
                    {
                        Discussions.Add(result.Data[i]);
                    }
                }
            }
        }

        public IMvxCommand SelectTableItemCommand => new MvxCommand<PostPresentation>(SelectTableItem);
        private void SelectTableItem(PostPresentation Post) 
        {
            Mvx.RegisterSingleton<PostPresentation>(Post);
            navigation.Navigate<DetailViewModel>();
            // navigation.Navigate<TabViewModel>();
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}
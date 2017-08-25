using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using System.Linq;

namespace SteemitApp.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IRepository repository;

        public MainViewModel(IRepository Repository)
        {
            repository = Repository;
        }
        
        public override async Task Initialize()
        {
            //TODO: Add starting logic here
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
                    foreach (var discussion in result.Data)
                    {
                        Discussions.Add(discussion);
                    }
                }
            }
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}
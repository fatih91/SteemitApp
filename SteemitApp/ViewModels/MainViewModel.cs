using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

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

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}
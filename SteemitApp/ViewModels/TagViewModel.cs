using System;
using System.Linq;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace SteemitApp.Core
{
    public class TagViewModel : MvxViewModel<TagPayload, TagPresentation>
    {
        private readonly IRepository repository;
        private readonly IMvxNavigationService navigation;

        public TagViewModel(IRepository Repository, IMvxNavigationService Navigation)
        {
            Tags = new MvxObservableCollection<TagPresentation>();

            repository = Repository;
            navigation = Navigation;
        }

        private async Task loadTags() 
        { 
            var result = await repository.LoadTags(new TagPayload());
            if (result.StatusCode == System.Net.HttpStatusCode.OK) 
            {
                foreach (var tag in result.Data)
                {
                    Tags.Add(tag);
                }
            }
        }

        public IMvxCommand LoadMoreCommand => new MvxCommand(LoadMore);
        private async void LoadMore() 
        {
            var lastEntry = Tags.LastOrDefault();
            if (lastEntry != null) 
            {
                var payload = new TagPayload(lastEntry.Name, "10");

                var result = await repository.LoadTags(payload);
                if (result.StatusCode == System.Net.HttpStatusCode.OK) 
                {
                    for (int i = 1; i < result.Data.Count; i++)
                    {
                        Tags.Add(result.Data[i]);
                    }
                }
            }
        }

        public MvxObservableCollection<TagPresentation> Tags { get; set; }

        public override async Task Initialize(TagPayload parameter)
        {
            await loadTags();
            // throw new NotImplementedException();
        }


        public IMvxCommand SelectTableItemCommand => new MvxCommand<TagPresentation>(SelectTableItem);
        private void SelectTableItem(TagPresentation Post)
        {
            this.Close(Post);
        }
    }
}

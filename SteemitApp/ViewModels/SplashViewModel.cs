using System;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

namespace SteemitApp.Core.ViewModels
{
    public class SplashViewModel : MvxViewModel
    {
        private readonly IRepository repository;
        private readonly IMvxNavigationService navigation;

        public SplashViewModel(IRepository Repository, IMvxNavigationService Navigation)
        {
        	repository = Repository;
            navigation = Navigation;
        }

        public override async System.Threading.Tasks.Task Initialize()
        {
            await repository.LoadDiscussions(new DiscussionPayload("steem", "10"));
            await navigation.Navigate<TabViewModel>();
        }
    }
}

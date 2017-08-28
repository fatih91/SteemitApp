using System;
using System.Collections.Generic;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using SteemitApp.Core.ViewModels;

namespace SteemitApp.Core.ViewModels
{
    public class TabViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService navigation;

        public TabViewModel(IMvxNavigationService Navigation)
        {
            navigation = Navigation;

            tabs = new List<TabItemPresentation>();
            tabs.Add(new TabItemPresentation 
            {
                Title = "Explore",
                ViewModelType = typeof(MainViewModel),
                ImageName = "tabPatient"
            });
            tabs.Add(new TabItemPresentation 
            {
                Title = "My Posts",
                ViewModelType = typeof(MyPostsViewModel),
                ImageName = "tabPatient"
            });
            tabs.Add(new TabItemPresentation 
            {
                Title = "Wallet",
                ViewModelType = typeof(WalletViewModel),
                ImageName = "tabPatient"
            });
            tabs.Add(new TabItemPresentation 
            {
                Title = "Settings",
                ViewModelType = typeof(SettingsViewModel),
                ImageName = "tabPatient"
            });
        }

        private List<TabItemPresentation> tabs;
        public List<TabItemPresentation> Tabs
        {
        	get { return tabs; }
        	set { SetProperty(ref tabs, value); }
        }
    }
}

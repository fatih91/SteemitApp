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
                Title = "Patient",
                ViewModelType = typeof(DetailViewModel),
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

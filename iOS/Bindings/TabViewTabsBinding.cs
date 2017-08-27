using System;
using System.Collections.Generic;
using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using SteemitApp.Core;
using UIKit;

namespace SteemitApp.iOS
{
    public class TabViewTabsBinding : MvxTargetBinding
    {
        private readonly TabView tabView;

        public TabViewTabsBinding(TabView TabView): base(TabView)
        {
            tabView = TabView;
        }

        public override MvxBindingMode DefaultMode
        {
            get
            {
                return MvxBindingMode.Default;
            }
        }

        public override Type TargetType
        {
            get
            {
                return typeof(TabView);
            }
        }

        public override void SetValue(object value)
        {
            if (value != null) 
            {
                try
                {
                    List<TabItemPresentation> tabs = (List<TabItemPresentation>)value;
                    List<UIViewController> viewControllers = new List<UIViewController>();

                    tabs.ForEach((tab) => 
                           viewControllers.Add(createTabFor(tab.Title, tab.ImageName, tab.ViewModelType)));

                    tabView.ViewControllers = viewControllers.ToArray();
                    tabView.CustomizableViewControllers = new UIViewController[] { };
                    tabView.SelectedViewController = tabView.ViewControllers[0];
                }
                catch (Exception ex)
                {

                }

            }
        }

        private int tabCount = 0;

        private UIViewController createTabFor(string title, string imageName, Type viewModelType)
        {
            var controller = new UINavigationController();
            var screen = tabView.CreateViewControllerFor(new MvxViewModelRequest
            {
                ViewModelType = viewModelType
            }) as UIViewController;

            setTitleAndBarItem(screen, title, imageName);
            controller.PushViewController(screen, false);
            return controller;
        }

        private void setTitleAndBarItem(UIViewController screen, string title, string imageName)
        {
        	screen.Title = title;
        	screen.TabBarItem = new UITabBarItem(title, UIImage.FromBundle(imageName + ".png"), tabCount++);
        }
    }
}

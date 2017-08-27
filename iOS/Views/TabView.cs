using System;
using System.Collections.Generic;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using SteemitApp.Core;
using SteemitApp.Core.ViewModels;
using UIKit;

namespace SteemitApp.iOS
{
    [MvxRootPresentation]
    public partial class TabView : MvxTabBarViewController<TabViewModel>
    {
        public TabView() // : base("TabView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.


            var set = this.CreateBindingSet<TabView, TabViewModel>();
            set.Bind(this).For("Tabs").To(vm => vm.Tabs);
            try

            {
                set.Apply();
            }
            catch (Exception e)
            {

            }


            

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


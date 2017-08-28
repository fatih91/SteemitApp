using System;
using MvvmCross.iOS.Views;
using UIKit;

namespace SteemitApp.iOS
{
    public partial class SplashView : MvxViewController
    {
        public SplashView() : base("SplashView", null)
        {
        }

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.NavigationController.NavigationBarHidden = true;

            await this.ViewModel.Initialize();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


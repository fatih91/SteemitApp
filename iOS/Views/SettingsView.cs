using System;
using MvvmCross.iOS.Views;
using UIKit;

namespace SteemitApp.iOS
{
    public partial class SettingsView : MvxViewController
    {
        public SettingsView() : base("SettingsView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


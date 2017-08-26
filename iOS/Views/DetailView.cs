using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using SteemitApp.Core;
using UIKit;

namespace SteemitApp.iOS
{
    public partial class DetailView : MvxViewController
    {
        public DetailView() : base("DetailView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var set = this.CreateBindingSet<DetailView, DetailViewModel>();

            set.Bind(WebView).For("Html").To(vm => vm.Post.Body);

            set.Apply();

            // this.webViewHeightConstraint.Constant = 1000f;
            this.WebView.ScrollView.ScrollEnabled = false;
            this.WebView.Frame = new CoreGraphics.CGRect(0f, 
                                                         0f, 
                                                         this.WebView.Frame.Width, 
                                                         2000f);

            this.ViewModel.Initialize();
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


using System;
using CoreGraphics;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using SteemitApp.Core;
using SteemitApp.Core.ViewModels;
using UIKit;

namespace SteemitApp.iOS
{
    [MvxTabPresentation]
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
            set.Bind(WebView).For("Loaded").To(vm => vm.RenderedCommand);
            set.Bind(ScrollView).For("Size").To(vm => vm.WebViewContentHeight);
            set.Apply();

            // this.webViewHeightConstraint.Constant = 1000f;
            this.WebView.ScrollView.ScrollEnabled = false;
            this.WebView.Frame = new CGRect(0f, 
                                            0f, 
                                            this.WebView.Frame.Width, 
                                            2000f);

            // this.ScrollView.AddSubview(this.WebView);
            this.ScrollView.ContentSize = new CGSize(100f, 2000f);

            this.TabBarItem.Title = "Test";
            this.ViewModel.Initialize();
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


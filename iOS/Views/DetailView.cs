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

            this.ViewModel.Initialize();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}


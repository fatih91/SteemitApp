using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using SteemitApp.Core;
using UIKit;

namespace SteemitApp.iOS
{
    public partial class PostCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("PostCell");
        public static readonly UINib Nib;

        static PostCell()
        {
            Nib = UINib.FromName("PostCell", NSBundle.MainBundle);
        }

        public PostCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() => 
            {
                var set = this.CreateBindingSet<PostCell, PostPresentation>();
                set.Bind(LabelTitle).To(vm => vm.Title);

                MvxImageViewLoader imageLoader = new MvxImageViewLoader(() => PostImage);    
                set.Bind(imageLoader).To(vm => vm.MainImage);

                set.Apply();
            });
        }
    }
}

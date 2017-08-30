using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using SteemitApp.Core;
using UIKit;

namespace SteemitApp.iOS
{
    public partial class TagCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("TagCell");
        public static readonly UINib Nib;

        static TagCell()
        {
            Nib = UINib.FromName("TagCell", NSBundle.MainBundle);
        }

        public TagCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() => 
            {
                var set = this.CreateBindingSet<TagCell, TagPresentation>();
                set.Bind(LabelName).To(vm => vm.Name);
                set.Apply();
            });
        }
    }
}

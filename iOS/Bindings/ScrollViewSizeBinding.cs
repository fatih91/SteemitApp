using System;
using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;
using UIKit;

namespace SteemitApp.iOS
{
    public class ScrollViewSizeBinding : MvxTargetBinding
    {
        private readonly UIScrollView scrollView;

        public ScrollViewSizeBinding(UIScrollView ScrollView): base(ScrollView)
        {
            scrollView = ScrollView;
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
                return typeof(UIScrollView);
            }
        }

        public override void SetValue(object value)
        {
            if (value != null) 
            {
                float height = (float)value;
                scrollView.ContentSize = new CoreGraphics.CGSize(100, height);
            }
        }
    }
}

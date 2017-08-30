using System;
using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;
using UIKit;

namespace SteemitApp.iOS
{
    public class ButtonTextBinding : MvxTargetBinding
    {
        private readonly UIButton button;

        public ButtonTextBinding(UIButton Button): base(Button)
        {
            button = Button;
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
                return typeof(UIButton);
            }
        }

        public override void SetValue(object value)
        {
            if (value != null) 
            {
                string text = (string)value;
                button.SetTitle(text, UIControlState.Normal);
            }
        }
    }
}

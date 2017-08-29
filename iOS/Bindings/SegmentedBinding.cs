using System;
using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;
using MvvmCross.Core.ViewModels;
using UIKit;

namespace SteemitApp.iOS
{
    public class SegmentedBinding : MvxTargetBinding
    {
        private readonly UISegmentedControl segmentedControl;

        private MvxCommand<int> command;

        public SegmentedBinding(UISegmentedControl SegmentedControl): base(SegmentedControl)
        {
            segmentedControl = SegmentedControl;
            segmentedControl.ValueChanged += valueChanged;
        }

        private void valueChanged(object sender, EventArgs e) 
        {
            if (command != null) 
            {
                command.Execute((int)segmentedControl.SelectedSegment);
            }
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
                return typeof(UISegmentedControl);
            }
        }

        public override void SetValue(object value)
        {
            if (value != null) 
            {
                command = (MvxCommand<int>)value;
            }
        }

        protected override void Dispose(bool isDisposing)
        {
            segmentedControl.ValueChanged -= valueChanged;
            base.Dispose(isDisposing);
        }
    }
}

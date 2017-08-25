using System;
using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Core.ViewModels;

namespace SteemitApp.iOS
{
    public class TableSourcePagingBinding : MvxTargetBinding
    {
        private bool isLoading = false;

        private IMvxCommand command;

        public TableSourcePagingBinding(PagingTableSource Source) : base(Source)
        {
            Source.ScrolledToEnd += (sender, e) => 
            {
                if (command != null) 
                {
                    command.Execute();
                }
            };
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
                return typeof(PagingTableSource);
            }
        }

        public override void SetValue(object value)
        {
            if (value != null) 
            {
                command = (IMvxCommand)value;
            }
        }
    }
}

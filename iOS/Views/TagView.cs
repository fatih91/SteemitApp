using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using SteemitApp.Core;
using UIKit;

namespace SteemitApp.iOS
{
    public partial class TagView : MvxViewController
    {
        public TagView() : base("TagView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.AutomaticallyAdjustsScrollViewInsets = false;

            var set = this.CreateBindingSet<TagView, TagViewModel>();

            var source = new GenericTableSource<TagCell>(TableTags,
                                                         TagCell.Nib,
                                                         TagCell.Key,
                                                         RowHeight: 44f);

            set.Bind((PagingTableSource)source).For("Paging").To(vm => vm.LoadMoreCommand);
            set.Bind(source).To(vm => vm.Tags);
            set.Bind(source).For(s => s.SelectionChangedCommand).To(vm => vm.SelectTableItemCommand);

            TableTags.Source = source;

            set.Apply();

            this.ViewModel.Initialize();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}


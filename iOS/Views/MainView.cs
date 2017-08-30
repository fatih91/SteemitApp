using CoreGraphics;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using UIKit;

namespace SteemitApp.iOS.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class MainView : MvxViewController
    {
        public MainView() : base("MainView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.AutomaticallyAdjustsScrollViewInsets = false;

            var set = this.CreateBindingSet<MainView, Core.ViewModels.MainViewModel>();

            set.Bind(SegmentedControl).For("Segmented").To(vm => vm.SegmentChangedCommand);

            var source = new GenericTableSource<PostCell>(TableDiscussions,
                                                          PostCell.Nib,
                                                          PostCell.Key,
                                                          RowHeight: 300f);

            set.Bind(source).To(vm => vm.Discussions);
            set.Bind(source).For(s => s.SelectionChangedCommand).To(vm => vm.SelectTableItemCommand);
            set.Bind((PagingTableSource)source).For("Paging").To(vm => vm.LoadMoreCommand);

            TableDiscussions.Source = source;

            var tagButton = new UIButton(UIButtonType.System);
            // tagButton.SetTitle("#steem", UIControlState.Normal);
            tagButton.Frame = new CGRect(-10, -30, 100, 100);

            set.Bind(tagButton).To(vm => vm.OpenTagPopoverCommand);
            set.Bind(tagButton.TitleLabel).To(vm => vm.CurrentTag.Name);

            set.Apply();

            this.NavigationController.NavigationBar.Add(tagButton);


            TableDiscussions.ReloadData();

			this.ViewModel.Initialize();


            /*
            var currentPopover = new UIPopoverController();
            currentPopover.SetContentViewController(this, true);
            */
            /*
            var currentPopover = new UIPopoverController(lController);
            currentPopover.SetContentViewController(pWindow.RootViewController, 
                                                    true);

            currentPopover.PresentFromRect(
                new CGRect(fPosition.X, fPosition.Y, 100, 100), 
				this.pWindow.RootViewController.View,
				UIPopoverArrowDirection.Any, true);
        
            currentPopover.ContentViewController
                          .PreferredContentSize = new CGSize(fPosition.Width, 
                                                             fPosition.Height);
                                                             */
        }
    }
}

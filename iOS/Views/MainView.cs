using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;

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

            var set = this.CreateBindingSet<MainView, Core.ViewModels.MainViewModel>();

            set.Bind(SegmentedControl).For("Segmented").To(vm => vm.SegmentChangedCommand);

            var source = new PagingTableSource(TableDiscussions);

            set.Bind(source).To(vm => vm.Discussions);
            set.Bind(source).For(s => s.SelectionChangedCommand).To(vm => vm.SelectTableItemCommand);
            set.Bind(source).For("Paging").To(vm => vm.LoadMoreCommand);

            TableDiscussions.Source = source;



            set.Apply();

            TableDiscussions.ReloadData();

            this.ViewModel.Initialize();
        }
    }
}

using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform.Platform;
using UIKit;

namespace SteemitApp.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(IMvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }
        
        public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
        
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override void FillTargetFactories(MvvmCross.Binding.Bindings.Target.Construction.IMvxTargetBindingFactoryRegistry registry)
        {
            registry.RegisterCustomBindingFactory<PagingTableSource>("Paging", (arg) => new TableSourcePagingBinding(arg));
            registry.RegisterCustomBindingFactory<UIWebView>("Html", (arg) => new WebViewStringBinding(arg));
            registry.RegisterCustomBindingFactory<UIWebView>("Loaded", (arg) => new WebViewLoadedBinding(arg));
            registry.RegisterCustomBindingFactory<UIScrollView>("Size", (arg) => new ScrollViewSizeBinding(arg));
            registry.RegisterCustomBindingFactory<TabView>("Tabs", (arg) => new TabViewTabsBinding(arg));
            registry.RegisterCustomBindingFactory<UISegmentedControl>("Segmented", (arg) => new SegmentedBinding(arg));
            registry.RegisterCustomBindingFactory<UIButton>("ButtonTitle", (arg) =>  new ButtonTextBinding(arg));

            base.FillTargetFactories(registry);
        }
    }
}

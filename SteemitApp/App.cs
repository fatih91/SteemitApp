using MvvmCross.Platform;
using MvvmCross.Platform.IoC;

namespace SteemitApp.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.RegisterSingleton<IProvider>(() => new RestProvider());
            RegisterAppStart<ViewModels.MainViewModel>();

        }
    }
}

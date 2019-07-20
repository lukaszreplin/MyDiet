using MyDiet.Ingredients.ViewModels;
using MyDiet.Views;
using MyDiet.Views.Ingredients;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace MyDiet
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTIxNTA2QDMxMzcyZTMyMmUzME5mVUR6L0E4L0RvUGZKS05XMllNMFlKaUtpR3pOMng4VGJFbFZwbkV5OEk9");
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<IngredientsWindow, IngredientsWindowViewModel>();

        }
    }
}

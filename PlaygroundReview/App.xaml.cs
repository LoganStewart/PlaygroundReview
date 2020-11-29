using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PlaygroundReview.Services;
using PlaygroundReview.Views;
using PlaygroundReview.Helpers;

namespace PlaygroundReview
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";

        public App()
        {
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Secrets.Syncfusionkey);

            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            DependencyService.Register<PlaygroundsDatastore>();
            DependencyService.Register<UserDatastore>();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

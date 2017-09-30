using System;
using Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;
namespace Messenger
{
    public partial class App : Application
    {
		public static MobileServiceClient MobileService = new MobileServiceClient("https://merendinomessenger.azurewebsites.net");
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MessengerPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

    }
}

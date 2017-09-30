using System;

using Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;
namespace Messenger
{
    public partial class MessengerPage : ContentPage
    {
		public static MobileServiceClient MobileService = new MobileServiceClient("https://merendinomessenger.azurewebsites.net");
        public MessengerPage()
        {
            InitializeComponent();
        }
		async void login(object sender, EventArgs e)
		{
            await DisplayAlert("Information:", "Username: " + unameField.Text +
                               "\nPassword: " + pwordField.Text ,"Enter");

		}
		async void Register(object sender, EventArgs e)
		{
            await Navigation.PushAsync(new Registration());
		}
    }
}

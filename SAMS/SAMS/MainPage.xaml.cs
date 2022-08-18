using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit;
using Xamarin.CommunityToolkit.UI.Views;

namespace SAMS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var assembly = typeof(MainPage);

            SplashScreenImage.Source = ImageSource.FromResource("SAMS.Assets.Images.splashpage.png", assembly);

        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            LoginButton.BackgroundColor = Color.DodgerBlue;
        }
        private void RegisterButton_Clicked(object sender, EventArgs e)
        {
            RegisterButton.BackgroundColor = Color.Blue;
            Navigation.ShowPopup(new StudorLecRegPopup());
        }

        private void ForgotPassButton_Clicked(object sender, EventArgs e)
        {
            ForgotPassButton.BackgroundColor = Color.Blue;
        }
    }
}

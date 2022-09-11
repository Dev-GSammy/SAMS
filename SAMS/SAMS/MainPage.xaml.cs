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

            SplashScreenImage.Source = ImageSource.FromResource("SAMS.Assets.Images.SplashImage.png", assembly);

        }

        async private void LoginButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Dashboard());
        }
         async private void RegisterButton_Clicked(object sender, EventArgs e)
        {
           var result = await App.Current.MainPage.Navigation.ShowPopupAsync(new StudorLecRegPopup());

            if (result)
            {
                await Navigation.PushModalAsync(new StudorLecRegistration());
            }
            else
            {
                await Navigation.PushModalAsync(new RegAsLecturer());
            }
        }

        private void ForgotPassButton_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}

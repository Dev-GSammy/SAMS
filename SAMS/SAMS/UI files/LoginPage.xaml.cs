using System;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.Extensions;

namespace SAMS
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            var assembly = typeof(LoginPage);

            SplashScreenImage.Source = ImageSource.FromResource("SAMS.Assets.Images.SplashImage.png", assembly);
            //NameEntryIcon.Source = ImageSource.FromResource("SAMS.Assets.Icons.Usercheck.png", assembly);
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

        async private void ForgotPassButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ForgotPassword());
        }
    }
}

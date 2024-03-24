
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SAMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegAsLecturer : ContentPage
    {
        public RegAsLecturer()
        {
            InitializeComponent();
            var assembly = typeof(RegAsLecturer);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
        }

        async private void LecRegisterButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                await DisplayAlert("Verify Password", "We need to verify your password before you log in. \n Please confirm you're a lecturer by clicking on the link sent to your mail", "Okay");
            }
            catch {
                await DisplayAlert("Registration", "Registration Unsuccessful! \n Please try again later", "Okay");
            }
            
            //await DisplayAlert("Confirm Identity","We need to confirm you are a lecturer. \n Please click on the verification link sent to your mail","Okay");
            //await Navigation.PushModalAsync(new VerifyMail());
        }
    }
}
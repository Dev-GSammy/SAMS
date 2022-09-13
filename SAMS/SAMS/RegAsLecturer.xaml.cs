using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            await DisplayAlert("Confirm Identity","We need to confirm you are a lecturer. \n Please input the OTP sent to your mail.","Okay");
            await Navigation.PushModalAsync(new VerifyMail());
        }
    }
}
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SAMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgotPassword : ContentPage
    {
        public ForgotPassword()
        {
            InitializeComponent();
            var assembly = typeof(ForgotPassword);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
        }

        private void SubmitEmailBtn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Send Password", "Your password has been successfully sent to the mail provided.", "Thank you", FlowDirection.LeftToRight);
            
        }

       // private void Resendbtn_Clicked(object sender, EventArgs e)
       //{

//        }
    }
}
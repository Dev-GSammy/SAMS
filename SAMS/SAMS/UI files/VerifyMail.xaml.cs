using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SAMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerifyMail : ContentPage
    {
        public VerifyMail()
        {
            InitializeComponent();
            var assembly = typeof(VerifyMail);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
        }

        private void SubmitOTPbtn_Clicked(object sender, EventArgs e)
        {
            
        }

        private void Resendbtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}
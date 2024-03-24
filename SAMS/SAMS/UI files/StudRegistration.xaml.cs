using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SAMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudorLecRegistration : ContentPage
    {
        public StudorLecRegistration()
        {
            InitializeComponent();
            var assembly = typeof(StudorLecRegistration);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
        }

        private void studRegisterButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Successful", "Your data has been successfully registered, Please Login", "Okay", FlowDirection.RightToLeft);
        }
    }
}
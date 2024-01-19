using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SAMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseCourseCheckReports : ContentPage
    {
        public ChooseCourseCheckReports()
        {
            InitializeComponent();
            var assembly = typeof(ChooseCourseCheckReports);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
        }

        private async void ChooseCourseCheckRepsbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CheckReport());
        }
    }
}
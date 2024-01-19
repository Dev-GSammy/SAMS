using System;
using Xamarin.Forms.Xaml;

namespace SAMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudorLecRegPopup
    {
        public StudorLecRegPopup()
        {
            InitializeComponent();
            //var assembly = typeof(StudorLecRegPopup);
            //ClosePopup.Source = ImageSource.FromResource("SAMS.Assets.Images.closeButton.png", assembly);
        }

        public void RegAsStudent_Clicked(object sender, EventArgs e) => Dismiss(true);
        private void RegAsLecturer_Clicked(object sender, EventArgs e)
        {
            Dismiss(false);
        }

        private void ClosePopup_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}
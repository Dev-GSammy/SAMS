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
    public partial class ChooseCourseMarkAttendance : ContentPage
    {
        public ChooseCourseMarkAttendance()
        {
            InitializeComponent();
            var assembly = typeof(ForgotPassword);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
            
        }

        async private void ChooseCourseMarkAttendancebtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ChooseStudentFile());
        }
    }
}
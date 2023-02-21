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
            var assembly = typeof(ChooseCourseMarkAttendance);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
            ChooseCourseMarkAttlv.ItemsSource = new string[] { "Samuel", "Stanlee", "Ihesie", "Adeyemo Itunu", "Adebeth", "TemiTope", "Bolanle", "And so on" };
            
        }

        async private void ChooseCourseMarkAttendancebtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ChooseStudentFile());
        }
    }
}
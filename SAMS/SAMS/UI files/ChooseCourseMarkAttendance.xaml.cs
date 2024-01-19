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
            
            ChooseCourseMarkAttlv.ItemsSource = new string[] { "CSC 101 - Introduction to Computer Science", "IFT 202 - Introduction to Information Technology", "PMT 203 - Principles of Management", "ENT 204 - Entrepreneurship", "SEN 205 - Sensory Perception", "CYS 206 - Cell and Molecular Biology", "CSC 301 - Data Structures and Algorithms", "IFT 302 - Database Systems", "PMT 303 - Organizational Behavior", "ENT 304 - Financial Accounting", "SEN 305 - Human Anatomy and Physiology", "CYS 306 - Genetics", "CSC 401 - Computer Architecture", "IFT 402 - Software Engineering", "PMT 403 - Marketing", "ENT 404 - Managerial Accounting", "SEN 405 - Microbiology", "CYS 406 - Immunology" };

        }

        async private void ChooseCourseMarkAttendancebtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ChooseStudentFile());
        }
    }
}
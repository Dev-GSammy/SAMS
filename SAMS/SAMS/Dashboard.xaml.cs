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
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
            var assembly = typeof(Dashboard);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
            DashboardImage.Source = ImageSource.FromResource("SAMS.Assets.Images.DashboardImage3x.png", assembly);
            DashboardPopupimgbtn.Source = ImageSource.FromResource("SAMS.Assets.Icons.DashboardPopup2x.png",assembly);
        }
        async private void MarkAttendancebtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ChooseCourseMarkAttendance());
        }

        async private void GivePermissionbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ChooseCourseGivePermission());
        }
        async private void YourAttendanceRecordbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ChooseCourseYourAttRec());
        }
        async private void CheckReportbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ChooseCourseCheckReports());
        }
        async private void AddCoursebtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddCourse());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        async private void shareBtn_Clicked(object sender, EventArgs e)
        {
            
        }

        async private void HowToUseBtn_Clicked(object sender, EventArgs e)
        {
            
        }

        async private void AppInfoBtn_Clicked(object sender, EventArgs e)
        {
            
        }

        async private void AdvertiseBtn_Clicked(object sender, EventArgs e)
        {
            
        }

        async private void DashboardPopupimgbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddCourse());
        }
    }
}
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
    public partial class CheckReport : ContentPage
    {
        public CheckReport()
        {
            InitializeComponent();
            var assembly = typeof(MarkAttendance);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
        }

        private void DownloadReportbtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}
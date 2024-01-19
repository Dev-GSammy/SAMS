using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.CommunityToolkit.Extensions;
using System.ComponentModel;
using Xamarin.CommunityToolkit;

namespace SAMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardMisc
    {
        public DashboardMisc()
        {
            InitializeComponent();
            var assembly = typeof(DashboardMisc);
            DashboardPopDownImgBtn.Source = ImageSource.FromResource("SAMS.Assets.Icons.PopLeft1.5x.png", assembly);
        }

        private void DashboardPopDownImgBtn_Clicked(object sender, EventArgs e)
        {
            Dismiss(true);
        }

        private void shareBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void HowToUseBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void AppInfoBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void AdvertiseBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}
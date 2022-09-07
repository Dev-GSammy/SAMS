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
    public partial class StudorLecRegPopup
    {
        public StudorLecRegPopup()
        {
            InitializeComponent();
            var assembly = typeof(StudorLecRegPopup);
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
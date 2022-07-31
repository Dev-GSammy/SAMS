using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.CommunityToolkit.Extensions;

namespace SAMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudorLecRegPopup : Popup
    {
        public StudorLecRegPopup()
        {
            InitializeComponent();
        }

        private void ClosePopup_Clicked(object sender, EventArgs e)
        {
            Dismiss(null);
        }
    }
}
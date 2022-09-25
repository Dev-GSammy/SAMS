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
    public partial class DownloadOrSendToMailPopup
    {
        public DownloadOrSendToMailPopup()
        {
            InitializeComponent();
            OnDismissed(new LoginPage());
        }
        private void DownloadMarkedFilebtn_Clicked(object sender, EventArgs e)
        {

        }
        private void SendToMailbtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}
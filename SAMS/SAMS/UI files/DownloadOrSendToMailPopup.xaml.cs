using System;
using Xamarin.Forms.Xaml;
namespace SAMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DownloadOrSendToMailPopup
    {
        public DownloadOrSendToMailPopup()
        {
            InitializeComponent();
            
            
        }
        private void DownloadMarkedFilebtn_Clicked(object sender, EventArgs e)
        {
            Dismiss(true);
        }
        private void SendToMailbtn_Clicked(object sender, EventArgs e)
        {
            Dismiss(false);
        }
    }
}
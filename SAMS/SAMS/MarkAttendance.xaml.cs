using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms.Xaml;

namespace SAMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MarkAttendance : ContentPage
    {
        public MarkAttendance()
        {
            InitializeComponent();
            var assembly = typeof(MarkAttendance);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
        }

        async private void SubmitAttendancebtn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Success","Attendance submission successful","Okay");
            var result = await App.Current.MainPage.Navigation.ShowPopupAsync(new DownloadOrSendToMailPopup());

            if (result)
            {
                
                await Navigation.PushModalAsync(new Dashboard());
            }
            else
            {
                await Navigation.PushModalAsync(new Dashboard());
            }
        }
    }
}
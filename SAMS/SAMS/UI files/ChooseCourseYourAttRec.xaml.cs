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
    public partial class ChooseCourseYourAttRec : ContentPage
    {
        public ChooseCourseYourAttRec()
        {
            InitializeComponent();
            var assembly = typeof(ChooseCourseYourAttRec);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
        }

        async private void ChooseCourseYourAttRecbtn_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.ShowPopupAsync(new AttendanceRecordPopup());
        }
    }
}
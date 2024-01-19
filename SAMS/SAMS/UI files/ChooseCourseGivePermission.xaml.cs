using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SAMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseCourseGivePermission : ContentPage
    {
        public ChooseCourseGivePermission()
        {
            InitializeComponent();
            var assembly = typeof(ChooseCourseGivePermission);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
        }

        async private void ChooseCourseGivePermissionbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ListofRegisteredStudents());
        }
    }
}
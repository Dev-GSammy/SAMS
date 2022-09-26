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
    public partial class AddCourse : ContentPage
    {
        public AddCourse()
        {
            InitializeComponent();
            var assembly = typeof(ForgotPassword);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
        }

        private void AddCoursebtn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Confirm Selection", "Are you sure you want to add these courses?", "Yes", "No");
            DisplayAlert("Success", "Course(s) have been added", "Ok");
        }
    }
}
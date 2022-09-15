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
    public partial class ChooseCourse : ContentPage
    {
        public ChooseCourse()
        {
            InitializeComponent();
            var assembly = typeof(ForgotPassword);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
        }

        private void ChooseCourseBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}
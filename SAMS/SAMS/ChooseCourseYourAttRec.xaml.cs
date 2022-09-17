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
    public partial class ChooseCourseYourAttRec : ContentPage
    {
        public ChooseCourseYourAttRec()
        {
            InitializeComponent();
            var assembly = typeof(ChooseCourseYourAttRec);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
        }

        private void ChooseCourseYourAttRecbtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}
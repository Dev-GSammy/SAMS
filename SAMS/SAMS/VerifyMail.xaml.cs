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
    public partial class VerifyMail : ContentPage
    {
        public VerifyMail()
        {
            InitializeComponent();
            var assembly = typeof(VerifyMail);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
        }

        private void SubmitEmailBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}
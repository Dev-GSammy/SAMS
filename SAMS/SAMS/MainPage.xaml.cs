using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SAMS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var assembly = typeof(MainPage);

            SplashScreenImage.Source = ImageSource.FromResource("SAMS.Assets.Images.mainpage.png", assembly);
        }
        
    }
}

using System;
using Xamarin.Forms;
[assembly: ExportFont("Poppins-Black.ttf", Alias = "PoppinsBlack")]
[assembly: ExportFont("Poppins-BlackItalic.ttf", Alias = "PoppinsBlackItalic")]
[assembly: ExportFont("Poppins-Bold.ttf", Alias = "PoppinsBold")]
[assembly: ExportFont("Poppins-SemiBold.ttf", Alias = "PoppinsSemiBold")]
[assembly: ExportFont("Poppins-SemiBoldItalic.ttf", Alias = "PoppinsSemiBoldItalic")]
[assembly: ExportFont("Poppins-BoldItalic.ttf", Alias = "PoppinsBoldItalic")]
[assembly: ExportFont("Poppins-Medium.ttf", Alias = "PoppinsMedium")]
[assembly: ExportFont("Poppins-MediumItalic.ttf", Alias = "PoppinsMediumItalic")]
[assembly: ExportFont("Poppins-Regular.ttf", Alias = "PoppinsRegular")]

namespace SAMS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

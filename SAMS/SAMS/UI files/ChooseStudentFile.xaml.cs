using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SAMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseStudentFile : ContentPage
    {
        public ChooseStudentFile()
        {
            InitializeComponent();
            var assembly = typeof(ChooseStudentFile);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
            //UploadStudentCSVbtn.ImageSource = ImageSource.FromResource("SAMS.Assets.Icons.LockIcon.png", assembly);
            
            ChooseStudentFilelv.ItemsSource = new string[] {"Computer Science Department 100L List", "Computer Science Department 200L List", "Computer Science Department 300L List", "Computer Science Department 400L List", "Information Technology Department 100L List", "Information Technology Department 200L List", "Information Technology Department 300L List", "Information Technology Department 400L List", "Management Department 100L List", "Management Department 200L List", "Management Department 300L List", "Management Department 400L List", "Entrepreneurship Department 100L List", "Entrepreneurship Department 200L List", "Entrepreneurship Department 300L List", "Entrepreneurship Department 400L List", "Sensory Perception Department 100L List", "Sensory Perception Department 200L List", "Sensory Perception Department 300L List", "Sensory Perception Department 400L List", "Cell and Molecular Biology Department 100L List", "Cell and Molecular Biology Department 200L List", "Cell and Molecular Biology Department 300L List", "Cell and Molecular Biology Department 400L List"};
        }

        private void UploadStudentCSVbtn_Clicked(object sender, EventArgs e)
        {

        }

        async private void ChooseStudentFileBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MarkAttendance());
        }
    }
}
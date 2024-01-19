using System;
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
            Addcourselv.ItemsSource = new string[] { "CSC 101 - Introduction to Computer Science", "IFT 202 - Introduction to Information Technology", "PMT 203 - Principles of Management", "ENT 204 - Entrepreneurship", "SEN 205 - Sensory Perception", "CYS 206 - Cell and Molecular Biology", "CSC 301 - Data Structures and Algorithms", "IFT 302 - Database Systems", "PMT 303 - Organizational Behavior", "ENT 304 - Financial Accounting", "SEN 305 - Human Anatomy and Physiology", "CYS 306 - Genetics", "CSC 401 - Computer Architecture", "IFT 402 - Software Engineering", "PMT 403 - Marketing", "ENT 404 - Managerial Accounting", "SEN 405 - Microbiology", "CYS 406 - Immunology" };
        }

        private void AddCoursebtn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "Course(s) have been added", "Ok");
            DisplayAlert("Confirm Selection", "Are you sure you want to add these courses?", "Yes");
            Console.WriteLine("Confirmation sent");
        }
    }
}
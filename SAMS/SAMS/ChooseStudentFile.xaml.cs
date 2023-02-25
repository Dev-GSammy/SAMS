﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            ChooseStudentFilelv.ItemsSource = new string[] { "500L IFT", "200L CSC", "300L SEN", "500L Special Students", "300L Carry Over Students" };
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
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
    public partial class MarkAttendance : ContentPage
    {
        public MarkAttendance()
        {
            InitializeComponent();
        }

        private void SubmitAttendancebtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class ListofRegisteredStudents : ContentPage
    {
        public ListofRegisteredStudents()
        {
            InitializeComponent();
        }

        private void GivePermissionbtn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Give Permission", "Are you sure you want to give Samuel Permission to mark attendance for the ECN310 course?", "Yes", "No");
            
        }
    }
}
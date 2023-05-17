using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace SAMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MarkAttendance : ContentPage
    {
        ObservableCollection<StudentList> Usr_List = new ObservableCollection<StudentList>();
        public MarkAttendance()
        {
            InitializeComponent();
            var assembly = typeof(MarkAttendance);

            PatternImage.Source = ImageSource.FromResource("SAMS.Assets.Images.WavyPattern.png", assembly);
            this.Usr_List.Add(new StudentList { SN = 1, Matric_No = "CSC/22/0516", Fullname = "Opayinka George Michael" });
            this.Usr_List.Add(new StudentList { SN = 2, Matric_No = "CSC/22/0517", Fullname = "Adeola David James" });
            this.Usr_List.Add(new StudentList { SN = 3, Matric_No = "CSC/22/0518", Fullname = "Ayobami Peter John" });
            this.Usr_List.Add(new StudentList { SN = 4, Matric_No = "CSC/22/0519", Fullname = "Chisom Daniel Kevin" });
            this.Usr_List.Add(new StudentList { SN = 5, Matric_No = "CSC/22/0520", Fullname = "Chukwudi Emmanuel Michael" });
            this.Usr_List.Add(new StudentList { SN = 6, Matric_No = "CSC/22/0521", Fullname = "Damilola Joseph Peter" });
            this.Usr_List.Add(new StudentList { SN = 7, Matric_No = "CSC/22/0522", Fullname = "Ebuka David John" });
            this.Usr_List.Add(new StudentList { SN = 8, Matric_No = "CSC/22/0523", Fullname = "Femi Chisom Kevin" });
            this.Usr_List.Add(new StudentList { SN = 9, Matric_No = "CSC/22/0524", Fullname = "Gideon Chukwudi Michael" });
            this.Usr_List.Add(new StudentList { SN = 10, Matric_No = "CSC/22/0525", Fullname = "Habeeb Damilola Peter" });
            this.Usr_List.Add(new StudentList { SN = 11, Matric_No = "CSC/22/0526", Fullname = "Ikenna Ebuka David" });
            this.Usr_List.Add(new StudentList { SN = 12, Matric_No = "CSC/22/0527", Fullname = "Jidefemi Gideon Chukwudi" });
            this.Usr_List.Add(new StudentList { SN = 13, Matric_No = "CSC/22/0528", Fullname = "Kolawole Habeeb Damilola" });
            this.Usr_List.Add(new StudentList { SN = 14, Matric_No = "CSC/22/0529", Fullname = "Michael Ikenna Ebuka" });
            this.Usr_List.Add(new StudentList { SN = 15, Matric_No = "CSC/22/0530", Fullname = "Oluwadamilola Kolawole Habeeb" });
            this.Usr_List.Add(new StudentList { SN = 16, Matric_No = "CSC/22/0531", Fullname = "Peter Michael Ikenna" });
            this.Usr_List.Add(new StudentList { SN = 17, Matric_No = "CSC/22/0532", Fullname = "Queen Chisom Oluwadamilola" });
            this.Usr_List.Add(new StudentList { SN = 18, Matric_No = "CSC/22/0533", Fullname = "Temitope Gideon Michael" });
            this.Usr_List.Add(new StudentList { SN = 19, Matric_No = "CSC/22/0534", Fullname = "Uchechukwu Queen Chisom" });
            this.Usr_List.Add(new StudentList { SN = 20, Matric_No = "CSC/22/0535", Fullname = "Victor Temitope Gideon" });
            this.Usr_List.Add(new StudentList { SN = 21, Matric_No = "CSC/22/0536", Fullname = "Wale Uchechukwu Queen" });
            this.Usr_List.Add(new StudentList { SN = 22, Matric_No = "CSC/22/0537", Fullname = "Yusuf Victor Temitope" });
            this.Usr_List.Add(new StudentList { SN = 23, Matric_No = "CSC/22/0538", Fullname = "Zara Wale Uchechukwu" });
            this.Usr_List.Add(new StudentList { SN = 24, Matric_No = "CSC/22/0539", Fullname = "Aisha Yusuf Victor" });
            this.Usr_List.Add(new StudentList { SN = 25, Matric_No = "CSC/22/0540", Fullname = "Bisi Zara Wale" });
            this.Usr_List.Add(new StudentList { SN = 26, Matric_No = "CSC/22/0541", Fullname = "Chika Aisha Yusuf" });
            this.Usr_List.Add(new StudentList { SN = 27, Matric_No = "CSC/22/0542", Fullname = "David Bisi Zara" });
            this.Usr_List.Add(new StudentList { SN = 28, Matric_No = "CSC/22/0543", Fullname = "Emeka Chika Aisha" });
            this.Usr_List.Add(new StudentList { SN = 29, Matric_No = "CSC/22/0544", Fullname = "Femi David Bisi" });
            this.Usr_List.Add(new StudentList { SN = 30, Matric_No = "CSC/22/0545", Fullname = "Goodluck Emeka Chika" });
            this.Usr_List.Add(new StudentList { SN = 31, Matric_No = "CSC/22/0571", Fullname = "Emeka Stanley Chibueze" });
            this.Usr_List.Add(new StudentList { SN = 32, Matric_No = "CSC/22/0546", Fullname = "Habeeb Femi David" });
            this.Usr_List.Add(new StudentList { SN = 33, Matric_No = "CSC/22/0547", Fullname = "Ikenna Goodluck Emeka" });
            this.Usr_List.Add(new StudentList { SN = 34, Matric_No = "CSC/22/0548", Fullname = "James Habeeb Femi" });
            this.Usr_List.Add(new StudentList { SN = 35, Matric_No = "CSC/22/0549", Fullname = "John Ikenna Goodluck" });
            this.Usr_List.Add(new StudentList { SN = 36, Matric_No = "CSC/22/0550", Fullname = "Kevin James Habeeb" });
            this.Usr_List.Add(new StudentList { SN = 37, Matric_No = "CSC/22/0551", Fullname = "Michael John Ikenna" });
            this.Usr_List.Add(new StudentList { SN = 38, Matric_No = "CSC/22/0552", Fullname = "Peter Kevin James" });
            this.Usr_List.Add(new StudentList { SN = 39, Matric_No = "CSC/22/0553", Fullname = "Sodiq Michael John" });
            this.Usr_List.Add(new StudentList { SN = 40, Matric_No = "CSC/22/0554", Fullname = "Tunde Peter Kevin" });
            this.Usr_List.Add(new StudentList { SN = 41, Matric_No = "CSC/22/0555", Fullname = "Uche Sodiq Michael" });
            this.Usr_List.Add(new StudentList { SN = 42, Matric_No = "CSC/22/0556", Fullname = "Victor Tunde Peter" });
            this.Usr_List.Add(new StudentList { SN = 43, Matric_No = "CSC/22/0557", Fullname = "Wale Uche Sodiq" });
            this.Usr_List.Add(new StudentList { SN = 44, Matric_No = "CSC/22/0558", Fullname = "Yusuf Victor Tunde" });
            this.Usr_List.Add(new StudentList { SN = 45, Matric_No = "CSC/22/0559", Fullname = "Zara Wale Uchechukwu" });
            this.Usr_List.Add(new StudentList { SN = 46, Matric_No = "CSC/22/0560", Fullname = "Aisha Yusuf Victor" });
            this.Usr_List.Add(new StudentList { SN = 47, Matric_No = "CSC/22/0561", Fullname = "Bisi Zara Wale" });
            this.Usr_List.Add(new StudentList { SN = 48, Matric_No = "CSC/22/0562", Fullname = "Chika Aisha Yusuf" });
            this.Usr_List.Add(new StudentList { SN = 49, Matric_No = "CSC/22/0563", Fullname = "David Bisi Zara" });
            this.Usr_List.Add(new StudentList { SN = 50, Matric_No = "CSC/22/0564", Fullname = "Emeka Chika Aisha" });
            ChooseListofStudentslv.ItemsSource = this.Usr_List;
            //ChooseListofStudentslv.ItemsSource = new string[] {"Daramola Ademola    IFT/17/2400    M", "Adebayo Omolade      IFT/16/2450   M", "Akinola Taiwo     IFT/16/2000    F" };
        }
        public class StudentList
        {
            public int SN { get; set; }
            public string Matric_No { get; set; }
            public string Fullname { get; set; }

        }

        async private void SubmitAttendancebtn_Clicked(object sender, EventArgs e)
        {
            //await DisplayAlert("SelectedMessage", Convert.ToString(ChooseListofStudentslv.SelectedItem), "Okay");
            Console.WriteLine("Selected Item successfully printed");
            await DisplayAlert("Success","Attendance submission successful","Okay");
            var result = await App.Current.MainPage.Navigation.ShowPopupAsync(new DownloadOrSendToMailPopup());

            if (result)
            {
                await Navigation.PushModalAsync(new Dashboard());
            }
            else
            {
                await Navigation.PushModalAsync(new Dashboard());
            }
        }
    }
}
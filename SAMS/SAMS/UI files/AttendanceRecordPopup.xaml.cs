using Xamarin.Forms.Xaml;


namespace SAMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AttendanceRecordPopup
    {
        public AttendanceRecordPopup()
        {
            InitializeComponent();
            ProgressBarPopup.Progress = 35;
        }
    }
}
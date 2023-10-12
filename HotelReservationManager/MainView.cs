namespace HotelReservationManager
{
    using System.Windows.Forms;

    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}

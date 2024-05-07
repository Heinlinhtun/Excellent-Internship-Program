namespace NewProject
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }
        UCHome home = new UCHome();
        UCEmployee employee = new UCEmployee();
        UCAttend attend = new UCAttend();

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Performer.ucFill(PnlContainer, home);
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            Performer.ucFill(PnlContainer, employee);
        }

        private void BtnAttend_Click(object sender, EventArgs e)
        {
            Performer.ucFill(PnlContainer, attend);
        }
    }
}

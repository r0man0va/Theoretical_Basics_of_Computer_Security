namespace Lab1
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();

        }

        private void AutorisationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorisationForm autorisationForm = new AutorisationForm();
            autorisationForm.ShowDialog();
        }
    }
}
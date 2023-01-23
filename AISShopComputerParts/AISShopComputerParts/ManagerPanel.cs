using System.Windows.Forms;

namespace AISShopComputerParts
{
    public partial class ManagerPanel : Form
    {
        public ManagerPanel()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, System.EventArgs e)
        {
            var form = new AutorizationForm();
            this.Hide();
            form.Show();
        }
    }
}
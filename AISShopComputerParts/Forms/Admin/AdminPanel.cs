using System.Windows.Forms;

namespace AISShopComputerParts
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, System.EventArgs e)
        {
            var form = new AutorizationForm();
            this.Hide();
            form.Show();
        }

        private void users_Click(object sender, System.EventArgs e)
        {
            var form = new UserEditor();
            this.Hide();
            form.Show();
        }

        private void staffs_Click(object sender, System.EventArgs e)
        {
            var form = new StaffEditor();
            this.Hide();
            form.Show();
        }

        private void categories_Click(object sender, System.EventArgs e)
        {
            var form = new CategoryEditor();
            this.Hide();
            form.Show();
        }

        private void products_Click(object sender, System.EventArgs e)
        {
            var form = new ProductEditor();
            this.Hide();
            form.Show();
        }

        private void salesAccounting_Click(object sender, System.EventArgs e)
        {
            var form = new OrdersRecorder();
            this.Hide();
            form.Show();
        }
    }
}
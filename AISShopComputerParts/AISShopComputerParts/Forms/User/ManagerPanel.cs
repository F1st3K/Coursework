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

        private void viewProducts_Click(object sender, System.EventArgs e)
        {
            var form = new ProductViewer();
            this.Hide();
            form.Show();
        }

        private void createSale_Click(object sender, System.EventArgs e)
        {
            var form = new OrderCreater();
            this.Hide();
            form.Show();
        }

        private void viewSales_Click(object sender, System.EventArgs e)
        {
            var form = new OrderList();
            this.Hide();
            form.Show();
        }
    }
}
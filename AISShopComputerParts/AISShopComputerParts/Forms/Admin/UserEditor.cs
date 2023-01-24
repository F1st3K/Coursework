using System.Windows.Forms;

namespace AISShopComputerParts
{
    public partial class UserEditor : Form
    {
        public UserEditor()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, System.EventArgs e)
        {
            var form = new AdminPanel();
            this.Hide();
            form.Show();
        }
    }
}
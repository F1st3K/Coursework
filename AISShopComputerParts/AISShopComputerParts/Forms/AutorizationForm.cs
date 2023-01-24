using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AISShopComputerParts
{
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form form;
            if (login.Text == "admin")
                form = new AdminPanel();
            else form = new ManagerPanel();
            this.Hide();
            form.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}

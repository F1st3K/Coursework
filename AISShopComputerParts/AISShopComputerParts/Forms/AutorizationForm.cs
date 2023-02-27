using AISShopComputerParts.Logic.MySql;
using AISShopComputerParts.Logic.MySql.DBStructure;
using System;
using System.Data;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace AISShopComputerParts
{
    public partial class AutorizationForm : Form
    {
        private int _countTryPasswd = 8;
        private int _countTryOutCaptcher => _countTryPasswd - 3;
        private int _msFrezze = 5000;

        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (captcha.Enabled && CheckCaptcha() == false)
            {
                MessageBox.Show("*неверная капча*", "неудачный вход",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataRow dataRow = MySqlAdapter.ReturnRow(DatabaseStructure.Users,
                DatabaseStructure.Users.Columns[1] + MySqlAdapter.EQUALS + login.Text + MySqlAdapter.AND +
                DatabaseStructure.Users.Columns[2] + MySqlAdapter.EQUALS + password.Text);
            if (dataRow is null)
            {
                MessageBox.Show("*неверный логин и/или пароль*", "неудачный вход",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataRow[3].ToString() == DatabaseStructure.AdminMode)
            {
                LoginAdmin();
                return;
            }
            if (dataRow[3].ToString() == DatabaseStructure.UserMode)
            {
                LoginUser();
                return;
            }
            _countTryPasswd--;

            if (_countTryPasswd <= 0)
                Block();
            else if (_countTryOutCaptcher <= 0)
                CaptcherMode();
            else
                NormalMode();
                
        }
        private bool CheckCaptcha()
        {
            return true;
        }

        private void NormalMode()
        {
            captcha.Enabled = false;
            login.Enabled = true;
            password.Enabled = true;
            buttonLogin.Enabled = true;
        }

        private void CaptcherMode()
        {
            captcha.Enabled = true;
            login.Enabled = true;
            password.Enabled = true;
            buttonLogin.Enabled = true;
        }

        private void BlockMode()
        {
            captcha.Enabled = false;
            login.Enabled = false;
            password.Enabled = false;
            buttonLogin.Enabled = false;
        }

        private void Block()
        {

        }

        private void LoginUser()
        {
            var form = new ManagerPanel();
            this.Hide();
            form.Show();
        }

        private void LoginAdmin()
        {
            var form = new AdminPanel();
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

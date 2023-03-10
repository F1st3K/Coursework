using AISShopComputerParts.Logic.Autorization;
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
        private int _countTryOutCaptcher = 5;
        private int _msFrezze = 5000;
        private Timer _frezzeTimer;

        public AutorizationForm()
        {
            InitializeComponent();
            _frezzeTimer = new Timer();
            _frezzeTimer.Interval = _msFrezze;
            _frezzeTimer.Tick += FrezzeTimerTick;
        }

        private void FrezzeTimerTick(object sender, EventArgs e)
        {
            CaptcherMode();
            _countTryPasswd = 5;
            _frezzeTimer.Enabled = false;
            _frezzeTimer.Stop();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (captcha.Enabled && CheckCaptcha() == false)
            {
                MessageBox.Show("*неверная капча*", "неудачный вход",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dataTable = MySqlAdapter.ReturnRows(DatabaseStructure.Users,
                DatabaseStructure.Users.Columns[1].Name + MySqlAdapter.EQUALS + 
                "\"" + login.Text + "\"" + MySqlAdapter.AND +
                DatabaseStructure.Users.Columns[2].Name + MySqlAdapter.EQUALS + 
                "\"" + new HashPassword(password.Text).Hash + "\"");
            if (dataTable.Rows.Count <= 0)
            {
                MessageBox.Show("*неверный логин и/или пароль*", "неудачный вход",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRow dataRow = dataTable.Rows[0];
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
            }

            _countTryPasswd--;
            _countTryOutCaptcher--;
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
            BlockMode();
            _frezzeTimer.Start();
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

using System;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace AISShopComputerParts
{
    public partial class AutorizationForm : Form
    {
        private int _countTryPasswd = 8;
        private int _countTryOutCaptcher = 3;
        private int _msFrezze = 5000;

        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (_countTryOutCaptcher <= 0)
                ViewCaptcher();
            if (_countTryPasswd <= 0)
                Frezze();
            _countTryOutCaptcher--;
            _countTryPasswd--;
        }

        private void ViewCaptcher()
        {
            
        }

        private void Frezze()
        {
            var timer = new Timer();
            timer.Interval = _msFrezze;
            timer.Tick += (a, e) => {
                
            };
        }

        private void LogIn()
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

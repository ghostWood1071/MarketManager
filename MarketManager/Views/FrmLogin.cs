using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MarketManager.Models;
using MarketManager.Interface;
namespace MarketManager.Views
{
    public partial class FrmLogin : Form
    {
        private ILoginable loginHandler;
        public FrmLogin(ILoginable loginHandler)
        {
            this.loginHandler = loginHandler;
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string account = edtAccount.Text;
            string password = edtPass.Text;
            Staff staff =  loginHandler.Login(account, password);
            if (staff == null)
                MessageBox.Show("sai tìa khoản, mật khẩu");
        }
    }
}

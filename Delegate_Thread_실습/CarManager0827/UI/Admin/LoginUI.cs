using CarManager0827;
using oracleTest0827.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager0811.UI
{
    public partial class LoginUI : Form
    {
        MainUI mainUi;
        public LoginUI()
        {
            InitializeComponent();
        }

        public LoginUI(object sender)
        {
            InitializeComponent();
            mainUi = sender as MainUI;
        }

        private void loginOK_Click(object sender, EventArgs e)
        {
            if (OraMgr.Instance.login(passwd.Text) == "성공")
            {
                MessageBox.Show("로그인 성공");
                mainUi.controllView(new AdminUI(), MainUI.UC_NAME_ADMIN);
                Close();
            }
            else
            {
                MessageBox.Show("로그인 실패");
            }
            
        }

        private void loginCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

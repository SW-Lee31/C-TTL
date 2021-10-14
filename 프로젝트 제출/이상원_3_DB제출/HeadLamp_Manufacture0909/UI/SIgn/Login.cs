using HeadLamp_Manufacture0909.Adapter;
using HeadLamp_Manufacture0909.DAO;
using HeadLamp_Manufacture0909.UI.AdminUI;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadLamp_Manufacture0909.UI.SIgn
{
    public partial class Login : MaterialForm
    {
        MainUI main;

        public Login()
        {
            InitializeComponent();
        }

        public Login(object sender)
        {
            InitializeComponent();
            main = sender as MainUI;
        }

        private void link_signup_Click(object sender, EventArgs e)
        {
            new SignUp().ShowDialog();
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submit_but_Click(object sender, EventArgs e)
        {
            OraMgr.Instance.show_admin_DB();

            bool[] chk = chk_account(input_id.Text, input_pw.Text);

            BaseAdapter.act_lst_Instance.Clear();

            for (int i = 0; i < chk.Length; i++)
            {
                if (chk[i] == true)
                {
                    MessageBox.Show("로그인 성공");
                    main.controllView(new AdminMainUI(main), MainUI.UC_NAME_ADMIN);
                    new Admin_Pro_Controller().Show();
                    main.signup = true;
                    Close();
                    break;
                }
                else
                {
                    if (i == chk.Length -1)
                    {
                        MessageBox.Show("아이디 혹은 비밀번호를 확인해주세요.");
                        break;
                    }
                }
            }
        }

        bool[] chk_account(string id, string pw)
        {
            bool[] chk = new bool[BaseAdapter.act_lst_Instance.Count];

            for (int i = 0; i < BaseAdapter.act_lst_Instance.Count; i++)
            {
                if (id == BaseAdapter.act_lst_Instance[i].Id && pw == BaseAdapter.act_lst_Instance[i].Pw)
                {
                    chk[i] = true;
                }
                else
                {
                    chk[i] = false;
                }
            }
            return chk;
        }
    }
}

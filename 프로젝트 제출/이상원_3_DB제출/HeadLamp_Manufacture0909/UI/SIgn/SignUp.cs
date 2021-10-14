using HeadLamp_Manufacture0909.DAO;
using HeadLamp_Manufacture0909.Model;
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
    public partial class SignUp : MaterialForm
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void submit_but_Click(object sender, EventArgs e)
        {
            value_input();

            MessageBox.Show("회원가입이 완료 되었습니다.", "회원가입완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void but_close_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        void value_input()
        {
            /*string name = string.Empty;
            string digit = string.Empty;
            string addr = string.Empty;
            string enom = string.Empty;
            string elev = string.Empty;
            string id = string.Empty;
            string pw = string.Empty;
            string pw_chk = string.Empty;

            string[] info_arr = new string[]
            {
                name, digit, addr, enom, elev, id, pw, pw_chk
            };
*/
            string[] input_arr = new string[]
            {
                input_name.Text, input_digit.Text, input_addr.Text, input_enom.Text,
                input_level.Text, input_id.Text, input_pw.Text, input_pw_chk.Text
            };

            string[] errmsg = new string[]
            {
                "이름 정보가 누락되었습니다.",
                "전화번호가 누락되었습니다.",
                "주소 정보가 누락되었습니다.",
                "사원번호 정보가 누락되었습니다.",
                "직급 정보가 누락되었습니다.",
                "아이디 정보가 누락되었습니다",
                "비밀번호 정보가 누락되었습니다.",
                "비밀번호 확인 정보가 누락되었습니다.",
                "비밀번호가 일치하지 않습니다.",
            };

            for (int i = 0; i < input_arr.Length; i++)
            {
                if (input_arr[i] == string.Empty)
                {
                    MessageBox.Show(errmsg[i]);
                    return;
                }
            }

            if (input_arr[6] != input_arr[7])
            {
                MessageBox.Show(errmsg[9]);
            }
            else if (input_arr[6] == input_arr[7])
            {
                Admin admin = new Admin(input_arr[0], input_arr[1], input_arr[2],
                    input_arr[3], input_arr[4]);

                Admin_account admin_account = new Admin_account(input_arr[5], input_arr[6]);

                OraMgr.Instance.insertDB(admin);
                OraMgr.Instance.insertDB(admin_account);
            }
        }
    }
}

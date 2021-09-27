using CarManager0811.Handler;
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
    public partial class MainLogin : Form
    {
        public delegate void eventMainLogin(string userName);
        public event eventMainLogin eventLogin;

        MainLoginHandler loginHandler = new MainLoginHandler();

        public MainLogin()
        {
            InitializeComponent();

            // 기존 디자인에서 Form Load를 활용해 이벤트 연결 -> 코드로 직접 이벤트 연결
            this.Load += onMainLogin;
        }

        void onMainLogin(object obj, EventArgs e)
        {
            Console.WriteLine("로그인 폼 로드");

            // 소스코드에서 버튼(클릭)이벤트 설정 (람다식 활용)
            MainLoginOK.Click += (sender, args) =>
            {
                if (emptychk())
                {
                    if (loginHandler.loginchk(MainUser.Text, MainPassword.Text))
                    {
                        string userName = MainUser.Text;
                        eventLogin(userName);
                        DialogResult = DialogResult.OK;
                    }

                    else
                    {
                        MessageBox.Show("로그인 정보가 일치하지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MainUser.Clear();
                        MainPassword.Clear();
                    }
                }
            };

            MainLoginCancel.Click += (sender, args) =>
            {
                Console.WriteLine("취소 버튼 클릭");
                DialogResult dia = MessageBox.Show("프로그램을 종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dia == DialogResult.Yes)
                {
                    Application.Exit();
                }
            };

            //MainLoginCancel.Click += testBtnClick;

            // MainLoginCancle.Click += (sender, args) => .... {람다식}은 MainLoginCancel.Click += testBtnClick과 동일함.
        }

        void testBtnClick(object sender, EventArgs arg)
        {
            Console.WriteLine("취소 버튼 클릭");
            DialogResult dia = MessageBox.Show("프로그램을 종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dia == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        bool emptychk()
        {
            if (string.IsNullOrEmpty(MainUser.Text))
            {
                MessageBox.Show("아이디를 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MainUser.Focus();
                return false;
            }

            else if (string.IsNullOrEmpty(MainPassword.Text)) 
            {
                MessageBox.Show("비밀번호를 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MainPassword.Focus();
                return false;
            }
            return true;
        }
    }
}

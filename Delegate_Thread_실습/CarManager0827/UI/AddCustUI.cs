using CarManager0811.Handler;
using oracleTest0827.DAO;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager0827
{
    partial class AddCustUI : UserControl
    {
        List<Customer> list;
        BaseAdapter adapter;
        public AddCustUI()
        {
            InitializeComponent();
        }

        public AddCustUI(List<Customer> list)
        {
            InitializeComponent();
            this.list = list;
        }

        public AddCustUI(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void custAddOK_Click(object sender, EventArgs e)
        {
            // TextBox
            string name = custName.Text;
            string tel = custTel.Text;
            string addr = custAddr.Text;

            // DatePicker
            DateTime date = custDate.Value;
            string strDate = string.Format("{0}년 {1}월 {2}일",
                date.Year, date.Month, date.Day);

            // ComboBox
            string year = custYear.SelectedText;
            string month = custMonth.SelectedText;
            string day = custDay.SelectedText;

            // RadioButton
            string gender = "";
            if (custMan.Checked == true)
            {
                gender = "남";
            }
            else if (custWoman.Checked == true)
            {
                gender = "여";
            }

            UICheckBox[] hbArr =
            {
                custHb1, custHb2, custHb3, custHb4, custHb5, custHb6
            };

            string birth = string.Format("{0}년 {1}월 {2}일",
                 year, month, day);

            List<string> hobbyList = new List<string>();
            for (int i = 0; i < hbArr.Length; i++)
            {
                if (hbArr[i].Checked == true)
                {
                    hobbyList.Add(hbArr[i].Text);
                }
            }

            string[] dataArr = new string[]
            {
                name, tel, addr, year, month, day, gender
            };

            string[] errMsg = new string[]
            {
                "이름 정보가 누락되었습니다.",
                "전화번호가 누락되었습니다.",
                "주소 정보가 누락되었습니다.",
                "년도 정보가 누락되었습니다.",
                "월 정보가 누락되었습니다.",
                "일 정보가 누락되었습니다.",
                "성별 정보가 누락되었습니다."
            };

            // 정보 누락 체크
            for (int i = 0; i < dataArr.Length; i++)
            {
                if (dataArr[i] == "")
                {
                    MessageBox.Show(errMsg[i]);
                    // void 메쏘드에서는 메쏘드를 탈출
                    return;
                }
            }

            // 한글 이름 체크
            Regex regex = new Regex(@"^[가-힣]{2,4}$");
            Match m = regex.Match(name);
            if (m.Success == false)
            {
                MessageBox.Show("잘못된 이름 정보입니다.");
                ActiveControl = custName;
                custName.Focus();
                return;
            }

            // 전화번호 체크
            Regex regexTel = new Regex(@"^01{1}[01]{1}[0-9]{7,8}$");
            Match m2 = regexTel.Match(tel);
            if (m2.Success == false)
            {
                MessageBox.Show("잘못된 전화번호 정보입니다.");
                return;
            }

            //-----------------------------------------
            // 사용자가 입력한 정상적인 데이터를 처리
            //-----------------------------------------
            Customer cust = new Customer(name, tel, addr,
                strDate, birth, gender, hobbyList);
            //list.Add(cust);
            //OraMgr.Instance.insertDB(cust);
            adapter.addToList(cust);
            MessageBox.Show("고객정보가 등록되었습니다.");
        }

        void setYear()
        {
            custYear.Items.Clear();
            for (int i = 2005; i >= 1940; i--)
            {
                custYear.Items.Add(i + "");
            }
        }

        void setMonth()
        {
            custMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                custMonth.Items.Add(i + "");
            }
        }

        void setDay()
        {
            custDay.Items.Clear();
            for (int i = 1; i <= 31; i++)
            {
                custDay.Items.Add(i + "");
            }
        }

        private void custAddClear_Click(object sender, EventArgs e)
        {

        }

        private void AddCustUI_Load(object sender, EventArgs e)
        {
            setYear();
            setMonth();
            setDay();
        }
    }
}

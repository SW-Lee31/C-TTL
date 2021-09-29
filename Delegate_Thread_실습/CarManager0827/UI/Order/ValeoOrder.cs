using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager0811.UI
{
    public partial class ValeoOrder : Form
    {
        int total_count = 0;
        public delegate int delOrderComplete(string str_result, int count);
        public event delOrderComplete eventOrderComplete;

        public ValeoOrder()
        {
            InitializeComponent();
        }

        private void ValeoOrder_Load(object sender, EventArgs e)
        {

        }

        public void ordercheck(Dictionary<string, int> orderDic)
        {
            foreach(KeyValuePair<string, int> order in orderDic)
            {
                string strType = string.Empty;
                int count = order.Value;

                if (order.Key == "더블클러치" || order.Key == "클러치 액츄에이터" || order.Key == "익스터널 댐퍼")
                {
                    strType = "[DDC]";
                }
                else if (order.Key == "CSC" || order.Key == "Damper" || 
                    order.Key == "CMC" || order.Key == "CRC")
                {
                    strType = "[HP]";
                }
                else if (order.Key == "C-DMF" || order.Key == "Pendulum DMF" || order.Key == "Dual Mass DMF")
                {
                    strType = "[DMF 시스템]";
                }
                total_count += count;
                lstbox_make.Items.Add(string.Format("{0} {1} {2}개가 주문되었습니다.", strType, order.Key, count));
                Refresh();
                Thread.Sleep(1000);
            }
            lstbox_make.Items.Add("=======================================");
            lstbox_make.Items.Add("주문 검사 완료되었습니다.");
            but_close.Text = "검사완료";
        }

        private void but_close_Click(object sender, EventArgs e)
        {
            int ret = eventOrderComplete("발주 주문이 완료 되었습니다.", total_count);
            if (ret == 0)
            {
                Console.WriteLine("주문 완료 확인되었습니다.");
            }
            else
            {
                Console.WriteLine("주문 오류 발생되었습니다.");
            }
            Close();
        }
    }
}

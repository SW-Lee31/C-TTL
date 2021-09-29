using CarManager0811.Util;
using CarManager0827;
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
    // enum : 사용자 정의 타입 -> 상수 변수
    enum DDC_ORDER
    {
        DOUBLE_CLUTCH = 1,
        CLUTCH_ACTUATOR,
        EXTERNAL_DAMPER
    }

    enum HP_ORDER
    {
        CSC = 1,
        DAMPER,
        CMC,
        CRC
    }

    enum DMF_ORDER
    {
        C_DMF = 1,
        P_DMF,
        D_DMF
    }

    public delegate int delFuncDDC(int i);
    public delegate int delFuncDMF(string strOrder, int ea);

    public partial class OrderUI : UserControl
    {
        //public const int C_DMF = 1;
        MainUI mainobj;

        int total_price;
        ValeoOrder valeorder;
        List<string> orderlst = new List<string>();

        public OrderUI()
        {
            InitializeComponent();
            ddc_1.Checked = true;
            hp_1.Checked = true;
        }

        public OrderUI(MainUI mainobj)
        {
            InitializeComponent();
            ddc_1.Checked = true;
            hp_1.Checked = true;
            this.mainobj = mainobj;
        }

        private void but_close_Load(object sender, EventArgs e)
        {
        }

        private void but_order_Click(object sender, EventArgs e)
        {
            total_price = 0;
            orderlst.Clear();
            
            Dictionary<string, int> orderDic = new Dictionary<string, int>();

            delFuncDDC del_ddc = new delFuncDDC(f_ddc_order);
            delFuncDDC del_hp = new delFuncDDC(f_hp_order);
            delFuncDMF del_dmf = null;

            int ddc_order = 0;
            int hp_order = 0;

            if (ddc_1.Checked)
            {
                ddc_order = (int)DDC_ORDER.DOUBLE_CLUTCH;
                orderDic.Add("더블 클러치", ddc_int_val.Value);
            }
            else if (ddc_2.Checked)
            {
                ddc_order = (int)DDC_ORDER.CLUTCH_ACTUATOR;
                orderDic.Add("클러치 액츄에이터", ddc_int_val.Value);
            }
            else if (ddc_3.Checked)
            {
                ddc_order = (int)DDC_ORDER.EXTERNAL_DAMPER;
                orderDic.Add("익스터널 댐퍼", ddc_int_val.Value);
            }

            if (ddc_int_val.Value <= 0)
            {
                MessageBox.Show("[DDC]품목 수량을 입력하세요.");
                return;
            }

            if (hp_1.Checked)
            {
                hp_order = (int)HP_ORDER.CSC;
                orderDic.Add("CSC", hp_int_val.Value);
            }
            else if (hp_2.Checked)
            {
                hp_order = (int)HP_ORDER.DAMPER;
                orderDic.Add("DAMPER", hp_int_val.Value);
            }
            else if (hp_3.Checked)
            {
                hp_order = (int)HP_ORDER.CMC;
                orderDic.Add("CMC", hp_int_val.Value);
            }
            else if (hp_4.Checked)
            {
                hp_order = (int)HP_ORDER.CRC;
                orderDic.Add("CRC", hp_int_val.Value);
            }

            if (hp_int_val.Value <= 0)
            {
                MessageBox.Show("[HP]품목 수량을 입력하세요.");
                return;
            }

            int ddc_total = fCallBackDelegate(ddc_order, del_ddc);
            int hp_total = fCallBackDelegate(hp_order, del_hp);

            // dmf체크
            if (c_dmf.Checked)
            {
                del_dmf += c_dmf_check;
                orderDic.Add("C-DMF", dmf_int_val.Value);
            }

            if (p_dmf.Checked)
            {
                del_dmf += p_dmf_check;
                orderDic.Add("Pendulum DMF", dmf_int_val.Value);
            }

            if (d_dmf.Checked)
            {
                del_dmf += d_dmf_check;
                orderDic.Add("Dual Mass DMF", dmf_int_val.Value);
            }

            if (del_dmf != null)
            {
                total_price += del_dmf("DMF 시스템", dmf_int_val.Value);
            }

            orderlst.Add("\n");
            orderlst.Add(string.Format("---- 총 발주 견적은 {0}원입니다. ----", total_price.ToString("C")));

            foreach (var str in orderlst)
            {
                Console.WriteLine(str);
            }

            call_order(orderDic);
        }

        void call_order(Dictionary<string, int> ordDic)
        {
            if (valeorder != null)
            {
                valeorder.Dispose();
                valeorder = null;
            }

            valeorder = new ValeoOrder();
            valeorder.eventOrderComplete += onValeoOrderComplete;


            // valeOrderUI 창을 띄우는 좌표(위치) showdialog는 centerParents 등이 먹히나, show는 그렇지 않음
            int mainX = mainobj.Location.X;
            int mainY = mainobj.Location.Y;
            int mainW = mainobj.Size.Width;
            int mainH = mainobj.Size.Height;

            int childW = valeorder.Size.Width;
            int childH = valeorder.Size.Height;

            valeorder.Show();
            // child 윈폼을 화면 정 가운데에 배치하도록 함
            valeorder.Location = new Point(
                mainX + (mainW / 2) - (childW / 2),
                mainY + (mainH / 2) - (childH / 2));

            valeorder.ordercheck(ordDic);
        }

        int onValeoOrderComplete(string str_result, int count)
        {
            orderlst.Add("---------------------------------------");
            orderlst.Add(string.Format("{0} / 총 주문 제품 : {1}", str_result, count));

            foreach (var order in orderlst)
            {
                detail_order.Items.Add(order);
            }

            if (count > 0 )
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        int c_dmf_check(string order, int ea)
        {
            int iprice = ea * 50000;
            string str_order = string.Format("[{0}] C_DMF {1}개를 선택: " +
                "{2}원 (1EA ￦50,000)", order, ea, iprice.ToString("C"));
            orderlst.Add(str_order);

            return iprice;
        }

        int p_dmf_check(string order, int ea)
        {
            int iprice = ea * 60000;
            string str_order = string.Format("[{0}] Pendulum DMF {1}개를 선택: " +
                "{2}원 (1EA ￦60,000)", order, ea, iprice.ToString("C"));
            orderlst.Add(str_order);

            return iprice;
        }

        int d_dmf_check(string order, int ea)
        {
            int iprice = ea * 70000;
            string str_order = string.Format("[{0}] Dual Mass DMF {1}개를 선택: " +
                "{2}원 (1EA ￦70,000)", order, ea, iprice.ToString("C"));
            orderlst.Add(str_order);

            return iprice;
        }

        public int fCallBackDelegate(int i, delFuncDDC dfunc)
        {
            return dfunc(i);
        }

        int f_ddc_order(int i)
        {
            string str_order = string.Empty;
            int i_price = 0;

            switch (i)
            {
                case (int)DDC_ORDER.DOUBLE_CLUTCH:
                    i_price = 100000 * (int)ddc_int_val.Value;
                    str_order = string.Format("[DDC] Double Clutch 선택 : {0}원 {1}개 (1EA ￦100,000)",
                        i_price.ToString("C"), ddc_int_val.Value);
                    break;

                case (int)DDC_ORDER.CLUTCH_ACTUATOR:
                    i_price = 110000 * (int)ddc_int_val.Value;
                    str_order = string.Format("[DDC] CLUTCH_ACTUATOR 선택 : {0}원 {1}개 (1EA ￦110,000)",
                        i_price.ToString("C"), ddc_int_val.Value);
                    break;

                case (int)DDC_ORDER.EXTERNAL_DAMPER:
                    i_price = 120000 * (int)ddc_int_val.Value;
                    str_order = string.Format("[DDC] EXTERNAL_DAMPER 선택 : {0}원 {1}개 (1EA ￦120,000)",
                        i_price.ToString("C"), ddc_int_val.Value);
                    break;
            }

            orderlst.Add(str_order);
            total_price += i_price;
            return i_price;
        }

        int f_hp_order(int i)
        {
            string str_order = string.Empty;
            int i_price = 0;

            switch (i)
            {
                case (int)HP_ORDER.CSC:
                    i_price = 50000 * (int)hp_int_val.Value;
                    str_order = string.Format("[HP] CSC 선택 : {0}원 {1}개 (1EA ￦50,000)",
                        i_price.ToString("C"), hp_int_val.Value);
                    break;

                case (int)HP_ORDER.DAMPER:
                    i_price = 70000 * (int)hp_int_val.Value;
                    str_order = string.Format("[HP] DAMPER 선택 : {0}원 {1}개 (1EA ￦70,000)",
                        i_price.ToString("C"), hp_int_val.Value);
                    break;

                case (int)HP_ORDER.CMC:
                    i_price = 80000 * (int)hp_int_val.Value;
                    str_order = string.Format("[HP] CMC 선택 : {0}원 {1}개 (1EA ￦80,000)",
                        i_price.ToString("C"), hp_int_val.Value);
                    break;

                case (int)HP_ORDER.CRC:
                    i_price = 90000 * (int)hp_int_val.Value;
                    str_order = string.Format("[HP] CRC 선택 : {0}원 {1}개 (1EA ￦90,000)",
                        i_price.ToString("C"), hp_int_val.Value);
                    break;
            }

            orderlst.Add(str_order);
            total_price += i_price;
            return i_price;
        }

        private void ddc_int_val_ValueChanged(object sender, int value)
        {

        }
    }
}

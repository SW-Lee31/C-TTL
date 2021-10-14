using HeadLamp_Manufacture0909.Adapter;
using HeadLamp_Manufacture0909.DAO;
using HeadLamp_Manufacture0909.FLow;
using HeadLamp_Manufacture0909.Model;
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
using Etimer = System.Windows.Forms.Timer;

namespace HeadLamp_Manufacture0909.UI.AdminUI
{
    public partial class AdminMainUI : UserControl
    {

        Etimer timer = new System.Windows.Forms.Timer();
        MainUI main;
        static AdminMainUI instance;

        public AdminMainUI()
        {
            InitializeComponent();
        }


        public AdminMainUI(object sender)
        {
            InitializeComponent();

            main = sender as MainUI;

            timer.Interval = 6000;
            timer.Tick += new EventHandler(but_refresh_Click);
            timer.Start();
        }

        public static AdminMainUI Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AdminMainUI();
                }
                return instance;
            }
        }

        public void pro_but_name_change(string name)
        {
            switch (name)
            {
                case "프로세스2":
                    pro2_but.Text = "프로세스2 작동";
                    break;
                case "프로세스3":
                    pro2_but.Text = "프로세스3 작동";
                    break;
                case "프로세스4":
                    pro2_but.Text = "프로세스4 작동";
                    break;
                case "프로세스5":
                    pro2_but.Text = "프로세스5 작동";
                    break;
            }
        }

        public void pro1_but_Click(object sender, EventArgs e)
        {

            if (pro1_but.Text == "프로세스1 작동")
            {
                if (OraMgr.Instance.show_pro_condition("프로세스1") == "정상작동")
                {
                    Console.WriteLine("프로세스1 가동");
                    main.timer_method(main.but_1_Click, "프로세스1");
                    pro1_but.Text = "프로세스1 중지";
                    pro1_but.Style = Sunny.UI.UIStyle.LightRed;
                }
                else
                {
                    MessageBox.Show("프로세스1은 수리 중입니다.");
                }
            }
            else if (pro1_but.Text == "프로세스1 중지")
            {
                Console.WriteLine("프로세스1 중지");
                main.timer_method_stop("프로세스1");
                pro1_but.Text = "프로세스1 작동";
                pro1_but.Style = Sunny.UI.UIStyle.LightGreen;
            }
        }

        public void upro2_but_Click(object sender, EventArgs e)
        {
            if (pro2_but.Text == "프로세스2 작동")
            {
                if (OraMgr.Instance.show_pro_condition("프로세스2") == "정상작동")
                {
                    Console.WriteLine("프로세스2 가동");
                    main.timer_method(main.but_2_Click, "프로세스2");
                    pro2_but.Text = "프로세스2 중지";
                    pro2_but.Style = Sunny.UI.UIStyle.LightRed;
                }
                else
                {
                    MessageBox.Show("프로세스2는 수리 중입니다.");
                }
            }
            else if (pro2_but.Text == "프로세스2 중지")
            {
                Console.WriteLine("프로세스2 중지");
                main.timer_method_stop("프로세스2");
                pro2_but.Text = "프로세스2 작동";
                pro2_but.Style = Sunny.UI.UIStyle.LightGreen;
            }
        }

        public void pro3_but_Click(object sender, EventArgs e)
        {
            if (pro3_but.Text == "프로세스3 작동")
            {
                if (OraMgr.Instance.show_pro_condition("프로세스3") == "정상작동")
                {
                    Console.WriteLine("프로세스3 가동");
                    main.timer_method(main.but_3_Click, "프로세스3");
                    pro3_but.Text = "프로세스3 중지";
                    pro3_but.Style = Sunny.UI.UIStyle.LightRed;
                }
                else
                {
                    MessageBox.Show("프로세스3은 수리 중입니다.");
                }
            }
            else if (pro3_but.Text == "프로세스3 중지")
            {
                Console.WriteLine("프로세스3 중지");
                main.timer_method_stop("프로세스3");
                pro3_but.Text = "프로세스3 작동";
                pro3_but.Style = Sunny.UI.UIStyle.LightGreen;
            }
        }

        public void pro4_but_Click(object sender, EventArgs e)
        {
            if (pro4_but.Text == "프로세스4 작동")
            {
                if (OraMgr.Instance.show_pro_condition("프로세스4") == "정상작동")
                {
                    Console.WriteLine("프로세스4 가동");
                    main.timer_method(main.but_4_Click, "프로세스4");
                    pro4_but.Text = "프로세스4 중지";
                    pro4_but.Style = Sunny.UI.UIStyle.LightRed;
                }
                else
                {
                    MessageBox.Show("프로세스4는 수리 중입니다.");
                }

            }
            else if (pro4_but.Text == "프로세스4 중지")
            {
                Console.WriteLine("프로세스4 중지");
                main.timer_method_stop("프로세스4");
                pro4_but.Text = "프로세스4 작동";
                pro4_but.Style = Sunny.UI.UIStyle.LightGreen;
            }
        }

        public void pro5_but_Click(object sender, EventArgs e)
        {
            if (pro5_but.Text == "프로세스5 작동")
            {
                if (OraMgr.Instance.show_pro_condition("프로세스5") == "정상작동")
                {
                    Console.WriteLine("프로세스5 가동");
                    main.timer_method(main.but_5_Click, "프로세스5");
                    pro5_but.Text = "프로세스5 중지";
                    pro5_but.Style = Sunny.UI.UIStyle.LightRed;
                }
                else
                {
                    MessageBox.Show("프로세스5는 수리 중입니다.");
                }

            }
            else if (pro5_but.Text == "프로세스5 중지")
            {
                Console.WriteLine("프로세스5 중지");
                main.timer_method_stop("프로세스5");
                pro5_but.Text = "프로세스5 작동";
                pro5_but.Style = Sunny.UI.UIStyle.LightGreen;
            }
        }

        private void all_act_but_Click(object sender, EventArgs e)
        {
            pro1_but_Click(sender, e);
            pro1_but.Text = "프로세스1 중지";
            pro1_but.Style = Sunny.UI.UIStyle.LightRed;
            Thread.Sleep(2000);
            upro2_but_Click(sender, e);
            pro2_but.Text = "프로세스2 중지";
            pro2_but.Style = Sunny.UI.UIStyle.LightRed;
            Thread.Sleep(3000);
            pro3_but_Click(sender, e);
            pro3_but.Text = "프로세스3 중지";
            pro3_but.Style = Sunny.UI.UIStyle.LightRed;
            Thread.Sleep(3000);
            pro4_but_Click(sender, e);
            pro4_but.Text = "프로세스4 중지";
            pro4_but.Style = Sunny.UI.UIStyle.LightRed;
            Thread.Sleep(3000);
            pro5_but_Click(sender, e);
            pro5_but.Text = "프로세스5 중지";
            pro5_but.Style = Sunny.UI.UIStyle.LightRed;
            Thread.Sleep(3000);
        }

        private void allstop_but_Click(object sender, EventArgs e)
        {
            main.timer_method_stop("프로세스1");
            pro1_but.Text = "프로세스1 작동";
            pro1_but.Style = Sunny.UI.UIStyle.LightGreen;
            main.timer_method_stop("프로세스2");
            pro2_but.Text = "프로세스2 작동";
            pro2_but.Style = Sunny.UI.UIStyle.LightGreen;
            main.timer_method_stop("프로세스3");
            pro3_but.Text = "프로세스3 작동";
            pro3_but.Style = Sunny.UI.UIStyle.LightGreen;
            main.timer_method_stop("프로세스4");
            pro4_but.Text = "프로세스4 작동";
            pro4_but.Style = Sunny.UI.UIStyle.LightGreen;
            main.timer_method_stop("프로세스5");
            pro5_but.Text = "프로세스5 작동";
            pro5_but.Style = Sunny.UI.UIStyle.LightGreen;
        }

        private void right_menu_panel_Click(object sender, EventArgs e)
        {

        }

        private void AdminMainUI_Load(object sender, EventArgs e)
        {
            initchart();
            but_controller.Style = Sunny.UI.UIStyle.Blue;
            allstop_but.Style = Sunny.UI.UIStyle.LightRed;
        }

        private void but_refresh_Click(object sender, EventArgs e)
        {
            initchart();

        }

        void initchart()
        {
            foreach (var series in compare_chart.Series)
            {
                series.Points.Clear();
            }

            int suc = OraMgr.Instance.show_invSuc_DB();
            int fail = OraMgr.Instance.show_invFail_DB();

            compare_chart.Series["process_success_amount"].Points.Add(suc);
            compare_chart.Series["process_fail_amount"].Points.Add(fail);

            output_pro_fair.Text = suc.ToString();
            utput_pro_fail.Text = fail.ToString();
        }


        private void but_controller_Click(object sender, EventArgs e)
        {
            new Admin_Pro_Controller().ShowDialog();
        }
    }
}

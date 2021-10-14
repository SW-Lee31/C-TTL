using HeadLamp_Manufacture0909.Adapter;
using HeadLamp_Manufacture0909.DAO;
using HeadLamp_Manufacture0909.FLow;
using HeadLamp_Manufacture0909.Model;
using HeadLamp_Manufacture0909.UI.AdminUI;
using HeadLamp_Manufacture0909.UI.DelUI;
using HeadLamp_Manufacture0909.UI.MenuUI;
using HeadLamp_Manufacture0909.UI.SIgn;
using HeadLamp_Manufacture0909.Util;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etimer = System.Windows.Forms.Timer;
using Timer = System.Threading.Timer;

namespace HeadLamp_Manufacture0909
{
    public partial class MainUI : MaterialForm
    {
        #region
#pragma warning disable CS0108
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x02;
        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg,
            int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();
#pragma warning restore CS0108
        #endregion

        Home homeUI = new Home();
        DelMainUI delUI = new DelMainUI();

        ThingSpeak Th_ele = new ThingSpeak();
        Random ran = new Random();
        ExTimer timer1, timer2, timer3, timer4, timer5, timer6;
        TimerPro wtimer, rtimer;

        const string UC_NAME_HOME = "Home";
        const string UC_NAME_PRO1 = "Pro1_infoUI";
        const string UC_NAME_PRO2 = "Pro2_infoUI";
        const string UC_NAME_PRO3 = "Pro3_infoUI";
        const string UC_NAME_PRO4 = "Pro4_infoUI";
        const string UC_NAME_PRO5 = "Pro5_infoUI";
        const string UC_NAME_DEL = "DelMainUI";
        public const string UC_NAME_ADMIN = "AdminMainUI";


        string[] fair_fail = new string[100];
        string[] temp = new string[]
        {
            "13", "24", "22", "56", "73", "97", "12", "67", "120", "4", "55", "23", "11", "53", "82", "18", "22"
        };
        string[] humi = new string[]
        {
            "13", "24", "22", "56", "73", "97", "12", "67", "120", "4", "55", "23", "11", "53", "82", "18", "22"
        };
        string[] dust = new string[]
        {
            "13", "24", "22", "56", "73", "97", "12", "67", "120", "4", "55", "23", "11", "53", "82", "18", "22"
        };
        int[] suc = new int[5];
        int[] fail = new int[5];

        public bool signup = false;
        bool pro1chk = false;
        bool pro2chk = false;
        bool pro3chk = false;
        bool pro4chk = false;
        bool pro5chk = false;

        public MainUI()
        {
            InitializeComponent();
            OraMgr.Instance.connectDB();

            for (int i = 0; i < 100; i++)
            {
                fair_fail[i] = "양호";

                if (i >= 98)
                {
                    fair_fail[i] = "불량";
                }
            }

            suc[0] = OraMgr.Instance.search_pro_s("프로세스1");
            suc[1] = OraMgr.Instance.search_pro_s("프로세스2");
            suc[2] = OraMgr.Instance.search_pro_s("프로세스3");
            suc[3] = OraMgr.Instance.search_pro_s("프로세스4");
            suc[4] = OraMgr.Instance.search_pro_s("프로세스5");
            fail[0] = OraMgr.Instance.search_pro_f("프로세스1");
            fail[1] = OraMgr.Instance.search_pro_f("프로세스2");
            fail[2] = OraMgr.Instance.search_pro_f("프로세스3");
            fail[3] = OraMgr.Instance.search_pro_f("프로세스4");
            fail[4] = OraMgr.Instance.search_pro_f("프로세스5");

            wtimer = new TimerPro(new Timer(new System.Threading.TimerCallback(writeHandler), null, 1000, 20000));
            rtimer = new TimerPro(new Timer(new System.Threading.TimerCallback(readHandler), null, 2000, 20000));
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            controllView(homeUI, UC_NAME_HOME);

            timer6 = new ExTimer(new Etimer());
            timer1 = new ExTimer(new Etimer());
            timer2 = new ExTimer(new Etimer());
            timer3 = new ExTimer(new Etimer());
            timer4 = new ExTimer(new Etimer());
            timer5 = new ExTimer(new Etimer());

            timer6.starTimer(20000, but_6_Click);
        }

        private void center_panel_Click(object sender, EventArgs e)
        {

        }

        private void close_but_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dia == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void min_but_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void info_but_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SW_Lee31에 의해 제작됨.", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void controllView(UserControl uc, string viewName)
        {
            center_panel.Controls.Clear();
            if (!center_panel.Controls.ContainsKey(viewName))
            {
                uc.Dock = DockStyle.Fill;
                center_panel.Controls.Add(uc);
            }
            center_panel.Controls[viewName].BringToFront();
        }

        private void topLayout_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void admin_but_Click(object sender, EventArgs e)
        {
            if (signup == false)
            {
                new Login(this).ShowDialog();
            }
            else
            {
                controllView(new AdminMainUI(this), UC_NAME_ADMIN);
            }
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {
            controllView(homeUI, UC_NAME_HOME);
        }

        private void pro_1_but_Click(object sender, EventArgs e)
        {
            controllView(new Pro1_infoUI(), UC_NAME_PRO1);
        }

        private void pro_2_but_Click(object sender, EventArgs e)
        {
            controllView(new Pro2_infoUI(), UC_NAME_PRO2);
        }

        private void pro_3_but_Click(object sender, EventArgs e)
        {
            controllView(new Pro3_infoUI(), UC_NAME_PRO3);
        }

        private void pro_4_but_Click(object sender, EventArgs e)
        {
            controllView(new Pro4_infoUI(), UC_NAME_PRO4);
        }

        private void pro_5_but_Click(object sender, EventArgs e)
        {
            controllView(new Pro5_infoUI(), UC_NAME_PRO5);
        }

        public void timer_method(EventHandler sender, string process)
        {
            switch (process)
            {
                case "프로세스1":
                    if (pro1chk == false)
                    {
                        timer1.starTimer(1000, new EventHandler(sender));
                        pro1chk = true;
                    }
                    else
                    {
                        timer1.runTImer();
                    }
                    break;
                case "프로세스2":
                    if (pro2chk == false)
                    {
                        timer2.starTimer(1000, new EventHandler(sender));
                        pro2chk = true;
                    }
                    else
                    {
                        timer2.runTImer();
                    }
                    break;
                case "프로세스3":
                    if (pro3chk == false)
                    {
                        timer3.starTimer(1000, new EventHandler(sender));
                        pro3chk = true;
                    }
                    else
                    {
                        timer3.runTImer();
                    }
                    break;
                case "프로세스4":
                    if (pro4chk == false)
                    {
                        timer4.starTimer(1000, new EventHandler(sender));
                        pro4chk = true;
                    }
                    else
                    {
                        timer4.runTImer();
                    }
                    break;
                case "프로세스5":
                    if (pro5chk == false)
                    {
                        timer5.starTimer(1000, new EventHandler(sender));
                        pro5chk = true;
                    }
                    else
                    {
                        timer5.runTImer();
                    }
                    break;
            }
        }

        public void timer_method_stop(string process)
        {
            switch (process)
            {
                case "프로세스1":
                    timer1.stopTimer();
                    break;
                case "프로세스2":
                    timer2.stopTimer();
                    break;
                case "프로세스3":
                    timer3.stopTimer();
                    break;
                case "프로세스4":
                    timer4.stopTimer();
                    break;
                case "프로세스5":
                    timer5.stopTimer();
                    break;
            }
        }

        public void random_info_create(string process_name)
        {
            Inventory item = new Inventory(DateTime.Now.ToString("yyyy년MM월dd일 HH: mm:ss"),
            process_name, fair_fail[ran.Next(fair_fail.Length)]);

            /*Console.WriteLine("생산시간 : {0}\t프로세스명 : {1}\t상태 : {2}", item.Time, item.Process,
                item.Condition);*/

            if (item.Condition == "불량")
            {
                ManufactureFlow.pro_fail_Instance.Add(item);
                fail[0]++;
            }
            else
            {
                ManufactureFlow.pro1_lst_Instance.Add(item);
                suc[0]++;
            }

            OraMgr.Instance.insertDB(item);
        }

        public void random_info_alter(string process_name, string time)
        {
            OraMgr.Instance.show_inv_DB();

            /*string[] processlst = new string[]
            {
                "프로세스1", "프로세스2", "프로세스3", "프로세스4"
            };

            string formal_process = string.Empty;*/

            switch (process_name)
            {
                case "프로세스2":
                    for (int i = 0; i < BaseAdapter.inv_lst_Instance.Count; i++)
                    {
                        if (BaseAdapter.inv_lst_Instance[i].Process == "프로세스1" &&
                            BaseAdapter.inv_lst_Instance[i].Condition != "불량")
                        {
                            BaseAdapter.inv_lst_Instance[i].Time = time;
                            BaseAdapter.inv_lst_Instance[i].Process = process_name;
                            BaseAdapter.inv_lst_Instance[i].Condition = fair_fail[ran.Next(fair_fail.Length)];

                            /*Console.WriteLine("생산시간 : {0}\t프로세스명 : {1}\t상태 : {2}", BaseAdapter.inv_lst_Instance[i].Time,
                                BaseAdapter.inv_lst_Instance[i].Process, BaseAdapter.inv_lst_Instance[i].Condition);*/

                            if (BaseAdapter.inv_lst_Instance[i].Condition == "양호")
                            {
                                suc[1]++;
                            }
                            else
                            {
                                fail[1]++;
                            }

                            OraMgr.Instance.updateDB_inv(BaseAdapter.inv_lst_Instance[i]);
                            break;
                        }
                    }
                    BaseAdapter.inv_lst_Instance.Clear();
                    break;
                case "프로세스3":
                    for (int i = 0; i < BaseAdapter.inv_lst_Instance.Count; i++)
                    {
                        if (BaseAdapter.inv_lst_Instance[i].Process == "프로세스2" &&
                            BaseAdapter.inv_lst_Instance[i].Condition != "불량")
                        {
                            BaseAdapter.inv_lst_Instance[i].Time = time;
                            BaseAdapter.inv_lst_Instance[i].Process = process_name;
                            BaseAdapter.inv_lst_Instance[i].Condition = fair_fail[ran.Next(fair_fail.Length)];

                            /*Console.WriteLine("생산시간 : {0}\t프로세스명 : {1}\t상태 : {2}", BaseAdapter.inv_lst_Instance[i].Time,
                                BaseAdapter.inv_lst_Instance[i].Process, BaseAdapter.inv_lst_Instance[i].Condition);*/

                            if (BaseAdapter.inv_lst_Instance[i].Condition == "양호")
                            {
                                suc[2]++;
                            }
                            else
                            {
                                fail[2]++;
                            }

                            OraMgr.Instance.updateDB_inv(BaseAdapter.inv_lst_Instance[i]);
                            break;
                        }
                    }
                    BaseAdapter.inv_lst_Instance.Clear();
                    break;
                case "프로세스4":
                    for (int i = 0; i < BaseAdapter.inv_lst_Instance.Count; i++)
                    {
                        if (BaseAdapter.inv_lst_Instance[i].Process == "프로세스3" &&
                            BaseAdapter.inv_lst_Instance[i].Condition != "불량")
                        {
                            BaseAdapter.inv_lst_Instance[i].Time = time;
                            BaseAdapter.inv_lst_Instance[i].Process = process_name;
                            BaseAdapter.inv_lst_Instance[i].Condition = fair_fail[ran.Next(fair_fail.Length)];

                            /*Console.WriteLine("생산시간 : {0}\t프로세스명 : {1}\t상태 : {2}", BaseAdapter.inv_lst_Instance[i].Time,
                                BaseAdapter.inv_lst_Instance[i].Process, BaseAdapter.inv_lst_Instance[i].Condition);*/

                            if (BaseAdapter.inv_lst_Instance[i].Condition == "양호")
                            {
                                suc[3]++;
                            }
                            else
                            {
                                fail[3]++;
                            }

                            OraMgr.Instance.updateDB_inv(BaseAdapter.inv_lst_Instance[i]);
                            break;
                        }
                    }
                    BaseAdapter.inv_lst_Instance.Clear();
                    break;
                case "프로세스5":
                    for (int i = 0; i < BaseAdapter.inv_lst_Instance.Count; i++)
                    {
                        if (BaseAdapter.inv_lst_Instance[i].Process == "프로세스4" &&
                            BaseAdapter.inv_lst_Instance[i].Condition != "불량")
                        {
                            BaseAdapter.inv_lst_Instance[i].Time = time;
                            BaseAdapter.inv_lst_Instance[i].Process = process_name;
                            BaseAdapter.inv_lst_Instance[i].Condition = fair_fail[ran.Next(fair_fail.Length)];

                            /* Console.WriteLine("생산시간 : {0}\t프로세스명 : {1}\t상태 : {2}", BaseAdapter.inv_lst_Instance[i].Time,
                                 BaseAdapter.inv_lst_Instance[i].Process, BaseAdapter.inv_lst_Instance[i].Condition);*/

                            if (BaseAdapter.inv_lst_Instance[i].Condition == "양호")
                            {
                                suc[4]++;
                            }
                            else
                            {
                                fail[4]++;
                            }

                            OraMgr.Instance.updateDB_inv(BaseAdapter.inv_lst_Instance[i]);

                            if (BaseAdapter.inv_lst_Instance[i].Condition != "불량")
                            {
                                OraMgr.Instance.insert_com_DB(BaseAdapter.inv_lst_Instance[i].Serial,
                                    BaseAdapter.inv_lst_Instance[i].Time);
                            }

                            break;
                        }

                        
                    }
                    BaseAdapter.inv_lst_Instance.Clear();
                    break;
            }
        }

        void add_pro_amount()
        {
            OraMgr.Instance.Update_Process_amount("프로세스1", suc[0], fail[0]);
            OraMgr.Instance.Update_Process_amount("프로세스2", suc[1], fail[1]);
            OraMgr.Instance.Update_Process_amount("프로세스3", suc[2], fail[2]);
            OraMgr.Instance.Update_Process_amount("프로세스4", suc[3], fail[3]);
            OraMgr.Instance.Update_Process_amount("프로세스5", suc[4], fail[4]);
        }

        public void but_1_Click(object sender, EventArgs e)
        {
            random_info_create("프로세스1");
        }

        public void but_2_Click(object sender, EventArgs e)
        {
            random_info_alter("프로세스2", DateTime.Now.ToString("yyyy년MM월dd일 HH: mm:ss"));
        }

        public void but_3_Click(object sender, EventArgs e)
        {
            random_info_alter("프로세스3", DateTime.Now.ToString("yyyy년MM월dd일 HH: mm:ss"));
        }

        public void but_4_Click(object sender, EventArgs e)
        {
            random_info_alter("프로세스4", DateTime.Now.ToString("yyyy년MM월dd일 HH: mm:ss"));
        }

        public void but_5_Click(object sender, EventArgs e)
        {
            random_info_alter("프로세스5", DateTime.Now.ToString("yyyy년MM월dd일 HH: mm: ss"));
        }

        private void monitor_but_Click(object sender, EventArgs e)
        {
            if (signup == false)
            {
                MessageBox.Show("관리자모드로 로그인 해주세요.");
            }
            else
            {
                controllView(delUI, UC_NAME_DEL);
            }
        }

        private void github_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SW-Lee31");
        }

        private void but_6_Click(object sender, EventArgs e)
        {
            add_pro_amount();

            OraMgr.Instance.Update_Process_status("프로세스1", temp[ran.Next(temp.Length)],
                humi[ran.Next(humi.Length)], dust[ran.Next(dust.Length)]);
            OraMgr.Instance.Update_Process_status("프로세스2", temp[ran.Next(temp.Length)],
                humi[ran.Next(humi.Length)], dust[ran.Next(dust.Length)]);
            OraMgr.Instance.Update_Process_status("프로세스3", temp[ran.Next(temp.Length)],
                humi[ran.Next(humi.Length)], dust[ran.Next(dust.Length)]);
            OraMgr.Instance.Update_Process_status("프로세스4", temp[ran.Next(temp.Length)],
                humi[ran.Next(humi.Length)], dust[ran.Next(dust.Length)]);
            OraMgr.Instance.Update_Process_status("프로세스5", temp[ran.Next(temp.Length)],
                humi[ran.Next(humi.Length)], dust[ran.Next(dust.Length)]);

            string[] chk1 = OraMgr.Instance.show_pro_status("프로세스1");
            string[] chk2 = OraMgr.Instance.show_pro_status("프로세스2");
            string[] chk3 = OraMgr.Instance.show_pro_status("프로세스3");
            string[] chk4 = OraMgr.Instance.show_pro_status("프로세스4");
            string[] chk5 = OraMgr.Instance.show_pro_status("프로세스5");
            chk_led(chk1, "프로세스1");
            chk_led(chk2, "프로세스2");
            chk_led(chk3, "프로세스3");
            chk_led(chk4, "프로세스4");
            chk_led(chk5, "프로세스5");
            initLed();
        }

        void chk_led(string[] chk, string process)
        {
            int chk_ele1 = int.Parse(chk[0]);
            int chk_ele2 = int.Parse(chk[1]);
            int chk_ele3 = int.Parse(chk[2]);

            switch (process)
            {
                case "프로세스1":
                    if (chk_ele1 < 100 && chk_ele2 < 100 && chk_ele3 < 100)
                    {
                        pro1_led.Color = Color.Green;
                        pro1_led.Blink = false;
                    }
                    else if (chk_ele1 > 100 && chk_ele2 < 100 && chk_ele3 < 100)
                    {
                        pro1_led.Color = Color.DarkOrange;
                        pro1_led.Blink = true;
                        pro1_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 < 100 && chk_ele2 > 100 && chk_ele3 < 100)
                    {
                        pro1_led.Color = Color.DarkOrange;
                        pro1_led.Blink = true;
                        pro1_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 < 100 && chk_ele2 < 100 && chk_ele3 > 100)
                    {
                        pro1_led.Color = Color.DarkOrange;
                        pro1_led.Blink = true;
                        pro1_led.BlinkInterval = 1000;

                    }
                    else if (chk_ele1 > 100 && chk_ele2 > 100 && chk_ele3 < 100)
                    {
                        pro1_led.Color = Color.DarkOrange;
                        pro1_led.Blink = true;
                        pro1_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 > 100 && chk_ele2 < 100 && chk_ele3 > 100)
                    {
                        pro1_led.Color = Color.DarkOrange;
                        pro1_led.Blink = true;
                        pro1_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 < 100 && chk_ele2 > 100 && chk_ele3 > 100)
                    {
                        pro1_led.Color = Color.DarkOrange;
                        pro1_led.Blink = true;
                        pro1_led.BlinkInterval = 1000;
                    }
                    else
                    {
                        pro1_led.Color = Color.Red;
                        pro1_led.Blink = true;
                        pro1_led.BlinkInterval = 500;
                    }
                    break;
                case "프로세스2":
                    if (chk_ele1 < 100 && chk_ele2 < 100 && chk_ele3 < 100)
                    {
                        pro2_led.Color = Color.Green;
                        pro2_led.Blink = false;
                    }
                    else if (chk_ele1 > 100 && chk_ele2 < 100 && chk_ele3 < 100)
                    {
                        pro2_led.Color = Color.DarkOrange;
                        pro2_led.Blink = true;
                        pro2_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 < 100 && chk_ele2 > 100 && chk_ele3 < 100)
                    {
                        pro2_led.Color = Color.DarkOrange;
                        pro2_led.Blink = true;
                        pro2_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 < 100 && chk_ele2 < 100 && chk_ele3 > 100)
                    {
                        pro2_led.Color = Color.DarkOrange;
                        pro2_led.Blink = true;
                        pro2_led.BlinkInterval = 1000;

                    }
                    else if (chk_ele1 > 100 && chk_ele2 > 100 && chk_ele3 < 100)
                    {
                        pro2_led.Color = Color.DarkOrange;
                        pro2_led.Blink = true;
                        pro2_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 > 100 && chk_ele2 < 100 && chk_ele3 > 100)
                    {
                        pro2_led.Color = Color.DarkOrange;
                        pro2_led.Blink = true;
                        pro2_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 < 100 && chk_ele2 > 100 && chk_ele3 > 100)
                    {
                        pro2_led.Color = Color.DarkOrange;
                        pro2_led.Blink = true;
                        pro2_led.BlinkInterval = 1000;
                    }
                    else
                    {
                        pro2_led.Color = Color.Red;
                        pro2_led.Blink = true;
                        pro2_led.BlinkInterval = 500;
                    }
                    break;
                case "프로세스3":
                    if (chk_ele1 < 100 && chk_ele2 < 100 && chk_ele3 < 100)
                    {
                        pro3_led.Color = Color.Green;
                        pro3_led.Blink = false;
                    }
                    else if (chk_ele1 > 100 && chk_ele2 < 100 && chk_ele3 < 100)
                    {
                        pro3_led.Color = Color.DarkOrange;
                        pro3_led.Blink = true;
                        pro3_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 < 100 && chk_ele2 > 100 && chk_ele3 < 100)
                    {
                        pro3_led.Color = Color.DarkOrange;
                        pro3_led.Blink = true;
                        pro3_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 < 100 && chk_ele2 < 100 && chk_ele3 > 100)
                    {
                        pro3_led.Color = Color.DarkOrange;
                        pro3_led.Blink = true;
                        pro3_led.BlinkInterval = 1000;

                    }
                    else if (chk_ele1 > 100 && chk_ele2 > 100 && chk_ele3 < 100)
                    {
                        pro3_led.Color = Color.DarkOrange;
                        pro3_led.Blink = true;
                        pro3_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 > 100 && chk_ele2 < 100 && chk_ele3 > 100)
                    {
                        pro3_led.Color = Color.DarkOrange;
                        pro3_led.Blink = true;
                        pro3_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 < 100 && chk_ele2 > 100 && chk_ele3 > 100)
                    {
                        pro3_led.Color = Color.DarkOrange;
                        pro3_led.Blink = true;
                        pro3_led.BlinkInterval = 1000;
                    }
                    else
                    {
                        pro3_led.Color = Color.Red;
                        pro3_led.Blink = true;
                        pro3_led.BlinkInterval = 500;
                    }
                    break;
                case "프로세스4":
                    if (chk_ele1 < 100 && chk_ele2 < 100 && chk_ele3 < 100)
                    {
                        pro4_led.Color = Color.Green;
                        pro4_led.Blink = false;
                    }
                    else if (chk_ele1 > 100 && chk_ele2 < 100 && chk_ele3 < 100)
                    {
                        pro4_led.Color = Color.DarkOrange;
                        pro4_led.Blink = true;
                        pro4_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 < 100 && chk_ele2 > 100 && chk_ele3 < 100)
                    {
                        pro4_led.Color = Color.DarkOrange;
                        pro4_led.Blink = true;
                        pro4_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 < 100 && chk_ele2 < 100 && chk_ele3 > 100)
                    {
                        pro4_led.Color = Color.DarkOrange;
                        pro4_led.Blink = true;
                        pro4_led.BlinkInterval = 1000;

                    }
                    else if (chk_ele1 > 100 && chk_ele2 > 100 && chk_ele3 < 100)
                    {
                        pro4_led.Color = Color.DarkOrange;
                        pro4_led.Blink = true;
                        pro4_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 > 100 && chk_ele2 < 100 && chk_ele3 > 100)
                    {
                        pro4_led.Color = Color.DarkOrange;
                        pro4_led.Blink = true;
                        pro4_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 < 100 && chk_ele2 > 100 && chk_ele3 > 100)
                    {
                        pro4_led.Color = Color.DarkOrange;
                        pro4_led.Blink = true;
                        pro4_led.BlinkInterval = 1000;
                    }
                    else
                    {
                        pro4_led.Color = Color.Red;
                        pro4_led.Blink = true;
                        pro4_led.BlinkInterval = 500;
                    }
                    break;
                case "프로세스5":
                    if (chk_ele1 < 100 && chk_ele2 < 100 && chk_ele3 < 100)
                    {
                        pro5_led.Color = Color.Green;
                        pro5_led.Blink = false;
                    }
                    else if (chk_ele1 > 100 && chk_ele2 < 100 && chk_ele3 < 100)
                    {
                        pro5_led.Color = Color.DarkOrange;
                        pro5_led.Blink = true;
                        pro5_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 < 100 && chk_ele2 > 100 && chk_ele3 < 100)
                    {
                        pro5_led.Color = Color.DarkOrange;
                        pro5_led.Blink = true;
                        pro5_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 < 100 && chk_ele2 < 100 && chk_ele3 > 100)
                    {
                        pro5_led.Color = Color.DarkOrange;
                        pro5_led.Blink = true;
                        pro5_led.BlinkInterval = 1000;

                    }
                    else if (chk_ele1 > 100 && chk_ele2 > 100 && chk_ele3 < 100)
                    {
                        pro5_led.Color = Color.DarkOrange;
                        pro5_led.Blink = true;
                        pro5_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 > 100 && chk_ele2 < 100 && chk_ele3 > 100)
                    {
                        pro5_led.Color = Color.DarkOrange;
                        pro5_led.Blink = true;
                        pro5_led.BlinkInterval = 1000;
                    }
                    else if (chk_ele1 < 100 && chk_ele2 > 100 && chk_ele3 > 100)
                    {
                        pro5_led.Color = Color.DarkOrange;
                        pro5_led.Blink = true;
                        pro5_led.BlinkInterval = 1000;
                    }
                    else
                    {
                        pro5_led.Color = Color.Red;
                        pro5_led.Blink = true;
                        pro5_led.BlinkInterval = 500;
                    }
                    break;
            }

        }

        void initLed()
        {
            int ledcount = 0;

            if (pro1_led.Color == Color.DarkOrange)
            {
                ledcount++;
            }
            if (pro2_led.Color == Color.DarkOrange)
            {
                ledcount++;
            }
            if (pro3_led.Color == Color.DarkOrange)
            {
                ledcount++;
            }
            if (pro4_led.Color == Color.DarkOrange)
            {
                ledcount++;
            }
            if (pro5_led.Color == Color.DarkOrange)
            {
                ledcount++;
            }

            if (ledcount >= 1)
            {
                led_alarm.Color = Color.DarkOrange;
                led_alarm.Blink = true;
                led_alarm.BlinkInterval = 1000;
                led_display.Text = "Check the Process";

            }
            else if (ledcount >= 3)
            {
                led_alarm.Color = Color.Red;
                led_alarm.Blink = true;
                led_alarm.BlinkInterval = 500;
                led_display.Text = "All Process Need STOP";
            }
            else if (ledcount < 1)
            {
                led_alarm.Color = Color.Green;
                led_alarm.Blink = false;
                led_display.Text = "No Problem Found";
            }
        }

        void writeHandler(object args)
        {
            string[] pro1_status = OraMgr.Instance.show_pro_status("프로세스1");
            string[] pro2_status = OraMgr.Instance.show_pro_status("프로세스2");

            bool chk = Th_ele.sendDataToThingSpeak(pro1_status[0], pro1_status[1], pro1_status[2],
                pro2_status[0], pro2_status[1], pro2_status[2], null, null);
        }

        void readHandler(object args)
        {
            Th_ele.readThingSpeak();

            string time = BaseAdapter.data_lst_Instance[BaseAdapter.data_lst_Instance.Count - 1].Time;
            int pro1_temp = int.Parse(BaseAdapter.data_lst_Instance[BaseAdapter.data_lst_Instance.Count - 1].Pro_1_temp);
            int pro1_humi = int.Parse(BaseAdapter.data_lst_Instance[BaseAdapter.data_lst_Instance.Count - 1].Pro_1_humi);
            int pro1_dust = int.Parse(BaseAdapter.data_lst_Instance[BaseAdapter.data_lst_Instance.Count - 1].Pro_1_dust);
            int pro2_temp = int.Parse(BaseAdapter.data_lst_Instance[BaseAdapter.data_lst_Instance.Count - 1].Pro_2_temp);
            int pro2_humi = int.Parse(BaseAdapter.data_lst_Instance[BaseAdapter.data_lst_Instance.Count - 1].Pro_2_humi);
            int pro2_dust = int.Parse(BaseAdapter.data_lst_Instance[BaseAdapter.data_lst_Instance.Count - 1].Pro_2_dust);

            Console.WriteLine("시간 : {0}", time);
            Console.WriteLine("####### 프로세스1 #######");
            Console.WriteLine("온도 : {0}\t습도 : {1}\t미세먼지 : {2}", pro1_temp, pro1_humi, pro1_dust);
            Console.WriteLine("####### 프로세스2 #######");
            Console.WriteLine("온도 : {0}\t습도 : {1}\t미세먼지 : {2}", pro2_temp, pro2_humi, pro2_dust);
        }

        private void top_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        /*private void top_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }*/

        /*
         UI스레드에서 작업스레드로 크로스 스레드 하는 법
        this.invoke(new Action -> 람다함수 (delegate()
        {
            UI스레드 내 컨트롤러 = 명령어..
        }));
        */
    }
}

using HeadLamp_Manufacture0909.Adapter;
using HeadLamp_Manufacture0909.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etimer = System.Windows.Forms.Timer;

namespace HeadLamp_Manufacture0909.UI.MenuUI
{
    public partial class Pro4_infoUI : UserControl
    {
        Etimer timer = new Timer();

        public Pro4_infoUI()
        {
            InitializeComponent();

            timer.Interval = 20000;
            timer.Tick += new EventHandler(but_refresh_Click);
            timer.Start();
        }

        private void Pro4_infoUI_Load(object sender, EventArgs e)
        {
            init_info();
        }

        void init_info()
        {
            itemview.Items.Clear();
            string[] status = OraMgr.Instance.show_pro_status("프로세스4");
            string con = OraMgr.Instance.show_pro_condition("프로세스4");

            output_pro4_temp.Text = status[0];
            output_pro4_humi.Text = status[1];
            output_pro4_dust.Text = status[2];
            output_pro4_online.Text = con;
            output_pro4_timer.Text = OraMgr.Instance.show_pro_time("프로세스4");
            output_pro4_fair.Text = OraMgr.Instance.pro_suc_amount("프로세스4").ToString();
            utput_pro4_fail.Text = OraMgr.Instance.pro_fail_amount("프로세스4").ToString();

            OraMgr.Instance.show_inv_DB();

            for (int i = 0; i < BaseAdapter.inv_lst_Instance.Count; i++)
            {
                if (BaseAdapter.inv_lst_Instance[i].Process == "프로세스4")
                {
                    itemview.Items.Add(new ListViewItem(
                        new string[]
                        {
                            BaseAdapter.inv_lst_Instance[i].Serial,
                            BaseAdapter.inv_lst_Instance[i].Time,
                            BaseAdapter.inv_lst_Instance[i].Condition
                        }));
                }
            }
            BaseAdapter.inv_lst_Instance.Clear();

        }

        private void but_refresh_Click(object sender, EventArgs e)
        {
            init_info();
        }
    }
}

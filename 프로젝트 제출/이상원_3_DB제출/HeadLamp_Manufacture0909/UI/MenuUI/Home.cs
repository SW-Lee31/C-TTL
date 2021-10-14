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
    public partial class Home : UserControl
    {
        Etimer timer = new Timer();

        public Home()
        {
            InitializeComponent();

            timer.Interval = 20000;
            timer.Tick += new EventHandler(but_refresh_Click);
            timer.Start();
        }

        private void uiSymbolLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolLabel3_Click(object sender, EventArgs e)
        {

        }

        private void but_refresh_Click(object sender, EventArgs e)
        {
            initchart_meter();
        }

        void initchart_meter()
        {
            string temp1 = OraMgr.Instance.show_pro_status("프로세스1")[0];
            string temp2 = OraMgr.Instance.show_pro_status("프로세스2")[0];
            string temp3 = OraMgr.Instance.show_pro_status("프로세스3")[0];
            string temp4 = OraMgr.Instance.show_pro_status("프로세스4")[0];
            string temp5 = OraMgr.Instance.show_pro_status("프로세스5")[0];

            temp_chart.Series["Process1_temp"].Points.Add(int.Parse(temp1));
            temp_chart.Series["Process2_temp"].Points.Add(int.Parse(temp2));
            temp_chart.Series["Process3_temp"].Points.Add(int.Parse(temp3));
            temp_chart.Series["Process4_temp"].Points.Add(int.Parse(temp4));
            temp_chart.Series["Process5_temp"].Points.Add(int.Parse(temp5));

            temp_meter1.Value = int.Parse(temp1);
            if (int.Parse(temp1) > 100)
            {
                temp_meter1.NeedleColor = Color.Red;
            }
            else
            {
                temp_meter1.NeedleColor = Color.YellowGreen;
            }

            temp_meter2.Value = int.Parse(temp2);
            if (int.Parse(temp2) > 100)
            {
                temp_meter2.NeedleColor = Color.Red;
            }
            else
            {
                temp_meter2.NeedleColor = Color.YellowGreen;
            }

            temp_meter3.Value = int.Parse(temp3);
            if (int.Parse(temp3) > 100)
            {
                temp_meter3.NeedleColor = Color.Red;
            }
            else
            {
                temp_meter3.NeedleColor = Color.YellowGreen;
            }

            temp_meter4.Value = int.Parse(temp4);
            if (int.Parse(temp4) > 100)
            {
                temp_meter4.NeedleColor = Color.Red;
            }
            else
            {
                temp_meter4.NeedleColor = Color.YellowGreen;
            }

            temp_meter5.Value = int.Parse(temp5);
            if (int.Parse(temp5) > 100)
            {
                temp_meter5.NeedleColor = Color.Red;
            }
            else
            {
                temp_meter5.NeedleColor = Color.YellowGreen;
            }
        }
    }
}

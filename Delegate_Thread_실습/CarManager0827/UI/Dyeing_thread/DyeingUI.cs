using CarManager0811.UI.Dyeing_thread;
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
    enum dyeing_process
    {
        방직,
        제직,
        염색,
        후처리,
        봉제
    }

    public partial class DyeingUI : UserControl
    {

        MainUI mainUI;

        int locationX;
        int locationY;
        List<ProcessUI> worklist = new List<ProcessUI>();

        public DyeingUI()
        {
            InitializeComponent();

        }

        public DyeingUI(MainUI mainUI)
        {
            InitializeComponent();

            this.mainUI = mainUI;
        }

        private void but_start_Click(object sender, EventArgs e)
        {
            locationX = this.locationX + this.Size.Width;
            locationY = this.locationY;

            for (int i = 0; i < process_num.Value; i++)
            {
                ProcessUI workUI = new ProcessUI(((dyeing_process)i).ToString());
                workUI.Location = new Point(locationX, locationY + workUI.Height * i);
                workUI.eventDelMessage += onEventDelMessage;
                workUI.Show();
                workUI.thread_start();
                worklist.Add(workUI);
                lb_show.Items.Add(string.Format("{0} : {1} 작업시작", DateTime.Now.ToString("G"), (dyeing_process)i));
            }
        }

        void remove_all_thread()
        {
            foreach (ProcessUI ui in worklist)
            {
                ui.thread_about();
            }
        }

        void onEventDelMessage(object sender, string str_result)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    ProcessUI ui = sender as ProcessUI;
                    lb_show.Items.Add(string.Format("{0} : {1} {2}", DateTime.Now.ToString("G"), ui.Str_work_name, str_result));
                }));
            }
            else
            {
                ProcessUI ui = sender as ProcessUI;
                lb_show.Items.Add(string.Format("{0} : {1} {2}", DateTime.Now.ToString("G"), ui.Str_work_name, str_result));
            }
        }
    }
}

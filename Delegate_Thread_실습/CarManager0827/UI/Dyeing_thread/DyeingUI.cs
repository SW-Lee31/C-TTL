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
            locationX = mainUI.Location.X + mainUI.Size.Width;
            locationY = mainUI.Location.Y;

            for (int i = 0; i < process_num.Value; i++)
            {
                ProcessUI workUI = new ProcessUI(((dyeing_process)i).ToString());
                workUI.eventDelMessage += onEventDelMessage;
                workUI.Show();
                workUI.Location = new Point(locationX, (locationY) + workUI.Height * i);
                workUI.thread_start();
                worklist.Add(workUI);
                lb_show.Items.Add(string.Format("{0} : {1} 작업시작", DateTime.Now.ToString("G"), (dyeing_process)i));
            }
        }

        void remove_all_thread()
        {
            foreach (ProcessUI ui in worklist)
            {
                ui.thread_abort();
            }
        }

        void onEventDelMessage(object sender, string str_result)
        {
            this.Invoke(new Action(() =>
            {
                ProcessUI ui = sender as ProcessUI;
                lb_show.Items.Add(string.Format("{0} : {1} {2}", DateTime.Now.ToString("G"), ui.Str_work_name, str_result));

                switch (str_result)
                {
                    case "작업 중지":
                        ui.threadPause();
                        break;
                    case "작업 완료":
                        ui.thread_abort();
                        ui.Close();
                        break;
                    case "작업 재개":
                        ui.threadResume();
                        break;
                }
            }));
            /*else
            {
                ProcessUI ui = sender as ProcessUI;
                lb_show.Items.Add(string.Format("{0} : {1} {2}", DateTime.Now.ToString("G"), ui.Str_work_name, str_result));
            }*/
        }
    }
}

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

namespace HeadLamp_Manufacture0909.UI.DelUI
{
    public partial class DelMainUI : UserControl
    {
        Etimer timer = new Etimer();

        public DelMainUI()
        {
            InitializeComponent();

            
        }

        private void DelMainUI_Load(object sender, EventArgs e)
        {
            initlistview();

            timer.Interval = 10000;
            timer.Tick += new EventHandler(but_refresh_Click);
            timer.Start();
        }

        void initlistview()
        {
            itemview.Items.Clear();
            OraMgr.Instance.show_del_info();

            for (int i = 0; i < BaseAdapter.del_lst_Instance.Count; i++)
            {
                itemview.Items.Add(new ListViewItem(
                    new string[]
                    {
                           (i + 1).ToString(),
                           BaseAdapter.del_lst_Instance[i].Del_seq,
                           BaseAdapter.del_lst_Instance[i].Mem_seq,
                           BaseAdapter.del_lst_Instance[i].Inv_seq,
                           BaseAdapter.del_lst_Instance[i].Curr_loc,
                           BaseAdapter.del_lst_Instance[i].Dest_loc,
                           BaseAdapter.del_lst_Instance[i].Admin_seq,
                           BaseAdapter.del_lst_Instance[i].Del_con
                    }));
            }
            BaseAdapter.del_lst_Instance.Clear();
        }

        private void but_refresh_Click(object sender, EventArgs e)
        {
            initlistview();
        }

        private void itemview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemview.SelectedItems.Count != 0)
            {
                string curr = itemview.FocusedItem.SubItems[4].Text;
                string dest = itemview.FocusedItem.SubItems[5].Text;

                System.Drawing.Point curpoint;
                Point destpoint;

                if (curr.Contains("대구"))
                {
                    curpoint = new Point(654, 232);
                    currpb.Location = curpoint;
                }
                if (dest.Contains("대구"))
                {
                    destpoint = new Point(654, 232);
                    destinationpb.Location = destpoint;
                }
                else if (dest.Contains("서울"))
                {
                    destpoint = new Point(584, 103);
                    destinationpb.Location = destpoint;
                }
                else if (dest.Contains("부산"))
                {
                    destpoint = new Point(676, 262);
                    destinationpb.Location = destpoint;
                }
                else if (dest.Contains("인천"))
                {
                    destpoint = new Point(561, 103);
                    destinationpb.Location = destpoint;
                }
                else if (dest.Contains("철원"))
                {
                    destpoint = new Point(644, 75);
                    destinationpb.Location = destpoint;
                }
                else if (dest.Contains("광주"))
                {
                    destpoint = new Point(577, 273);
                    destinationpb.Location = destpoint;
                }
                else if (dest.Contains("울산"))
                {
                    destpoint = new Point(668, 190);
                    destinationpb.Location = destpoint;
                }
                else if (dest.Contains("대전"))
                {
                    destpoint = new Point(603, 200);
                    destinationpb.Location = destpoint;
                }
                else if (dest.Contains("제주"))
                {
                    destpoint = new Point(552, 372);
                    destinationpb.Location = destpoint;
                }
            }

            /* 대구 : 654, 232,
             * 서울 : 584, 103,
             * 부산 : 676, 262,
             * 인천 : 561, 103,
             * 철원 : 644, 75,
             * 광주 : 577, 273,
             * 울산 : 668, 190,
             * 대전 : 603, 200,
             * 제주 : 552, 372 */
        }

        private void itemview_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void del_create_but_Click(object sender, EventArgs e)
        {
            new Add_del().Show();
        }
    }
}

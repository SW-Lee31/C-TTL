using CarManager0811.Handler;
using CarManager0811.Model;
using CarManager0811.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager0827
{
    partial class SalesUI : UserControl
    {
        List<Customer> list;
        BaseAdapter adapter;
        public SalesUI()
        {
            InitializeComponent();
        }

        public SalesUI(List<Customer> list)
        {
            InitializeComponent();
            this.list = list;
            
            /*initListView2();*/
            initGridView();
        }

        public SalesUI(BaseAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void SalesUI_Load(object sender, EventArgs e)
        {
            CommonUtil.colorListHeader(custListView, Color.Green, Color.White);

            custListView.Items.Clear();
            /*initListView2();*/
            initGridView();
        }

        private void custListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (custListView.SelectedItems.Count != 0)
            {
                int n = custListView.SelectedItems[0].Index;
                Console.WriteLine("n : " + n);
                string num = custListView.Items[n].SubItems[0].Text;
                string name = custListView.Items[n].SubItems[4].Text;
                string tel = custListView.Items[n].SubItems[2].Text;

                List<HobbyVo> hbList = adapter.getHobbyDB(name);
                List<string> strList = new List<string>();
                strList.Add(hbList[0].Hb1);
                strList.Add(hbList[0].Hb2);
                strList.Add(hbList[0].Hb3);
                strList.Add(hbList[0].Hb4);
                strList.Add(hbList[0].Hb5);
                strList.Add(hbList[0].Hb6);

                custGridView.Rows.Clear();               
                initGridView(strList);
            }
        }

       /* void initListView2()
        {
            List<SalesVo> list = adapter.getSalesDB();
            for (int i = 0; i < list.Count; i++)
            {
                custListView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1).ToString(),
                        list[i].CarName,
                        list[i].Price.ToString(),
                        list[i].InsuDate,
                        list[i].CustName,
                        list[i].CustTel,
                        list[i].JupsuDate,
                        list[i].Manager
                    }));
            }
        }*/

        void initGridView()
        {
            string[] gridData =
            {
                "1", "잠자기"
            };
            custGridView.Rows.Add(gridData);

            for (int i = 0; i < 3; i++)
            {
                custGridView.Rows.Add(new string[]
                {
                    (i+1).ToString(), "게임하기"
                });
            }
        }

        void initGridView(List<string> hbList)
        {
            for (int i = 0; i < hbList.Count; i++)
            {
                custGridView.Rows.Add(new string[]
                {
                    (i+1).ToString(), hbList[i]
                });
            }
        }

        private void searchUnion_Click(object sender, EventArgs e)
        {
            string carName = searchCar.Text;
            string custName = searchCust.Text;
            string jupsuDate = searchJupsu.Text;
            string manager = searchManager.Text;

            string[] searchArr = new string[]
            {
                carName, custName, jupsuDate, manager
            };

            List<SalesVo> list = adapter.getSearchUnionDB(searchArr);
            searchListView(list);
        }

        void searchListView(List<SalesVo> list)
        {
            custListView.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                custListView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1).ToString(),
                        list[i].CarName,
                        list[i].Price.ToString(),
                        list[i].InsuDate,
                        list[i].CustName,
                        list[i].CustTel,
                        list[i].JupsuDate,
                        list[i].Manager
                    }));
            }
        }
    }
}

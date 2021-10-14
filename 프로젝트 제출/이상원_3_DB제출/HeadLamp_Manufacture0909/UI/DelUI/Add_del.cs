using HeadLamp_Manufacture0909.Adapter;
using HeadLamp_Manufacture0909.DAO;
using HeadLamp_Manufacture0909.Model;
using MaterialSkin.Controls;
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
    public partial class Add_del : MaterialForm
    {
        Etimer timer = new Etimer();

        public Add_del()
        {
            InitializeComponent();

            timer.Interval = 300000;
            timer.Tick += new EventHandler(but_refresh_Click);
            timer.Start();
        }

        private void Add_del_Load(object sender, EventArgs e)
        { 
            initlistview();
            initadmin();
            initinven();
        }

        void initlistview()
        {
            memview.Items.Clear();
            OraMgr.Instance.show_mem_info();

            for (int i = 0; i < BaseAdapter.mem_lst_Instance.Count; i++)
            {

                memview.Items.Add(new ListViewItem(
                    new string[]
                    {
                           (i + 1).ToString(),
                           BaseAdapter.mem_lst_Instance[i].Mem_seq,
                           BaseAdapter.mem_lst_Instance[i].Name,
                           BaseAdapter.mem_lst_Instance[i].Dest
                    }));
            }
            BaseAdapter.mem_lst_Instance.Clear();
        }

        void initadmin()
        {
            input_admin.Items.Clear();

            OraMgr.Instance.show_admin_info_DB();

            for (int i = 0; i < BaseAdapter.ad_lst_Instance.Count; i++)
            {
                input_admin.Items.Add(BaseAdapter.ad_lst_Instance[i].Name);
            }

            BaseAdapter.ad_lst_Instance.Clear();
        }

        void initinven()
        {
            input_inv_seq.Items.Clear();

            List<string> inv_seq_lst = OraMgr.Instance.show_inv_suc();

            for (int i = 0; i < inv_seq_lst.Count; i++)
            {
                input_inv_seq.Items.Add(inv_seq_lst[i]);
            }
        }

        void data_insert()
        {
            string admin = OraMgr.Instance.admin_id_finder(input_admin.Text);
            string inv = input_inv_seq.Text;
            string memseq = memview.FocusedItem.SubItems[1].Text;
            string dest = memview.FocusedItem.SubItems[3].Text;
            string currloc = "대구";

            Del del = new Del(memseq, inv, currloc, dest, admin);
            OraMgr.Instance.insertDB(del);
            OraMgr.Instance.Update_inv_suc("배송대기", inv);
            
        }


        private void but_refresh_Click(object sender, EventArgs e)
        {
            initlistview();
            initadmin();
            initinven();
        }

        private void submit_but_Click(object sender, EventArgs e)
        {
            data_insert();

        }
    }
}

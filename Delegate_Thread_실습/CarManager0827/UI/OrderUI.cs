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

namespace CarManager0811.UI
{
    public partial class OrderUI : UserControl
    {
        public OrderUI()
        {
            InitializeComponent();

        }

        private void but_close_Load(object sender, EventArgs e)
        {
            initlistview();
        }

        private void but_order_Click(object sender, EventArgs e)
        {
            bool[] ddclst = new bool[]
            {
                radio_double.Checked,
                radio_actuater.Checked,
                radio_external.Checked
            };


        }

        void initlistview()
        {
            CommonUtil.serRowColor(order_listview, Color.Green, Color.Blue);
        }
    }
}

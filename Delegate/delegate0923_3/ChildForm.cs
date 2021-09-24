using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegate0923_3
{
    public delegate void DataGetEventHandler(string data);
    public partial class ChildForm : Form
    {
        public DataGetEventHandler dataSendEvent;

        public ChildForm()
        {
            InitializeComponent();
        }

        private void set_data_Click(object sender, EventArgs e)
        {
            dataSendEvent(input_text.Text);
        }
    }
}

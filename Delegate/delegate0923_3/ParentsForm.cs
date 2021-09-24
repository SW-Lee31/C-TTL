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
    public partial class ParentsForm : Form
    {
        ChildForm chform = new ChildForm();

        public ParentsForm()
        {
            InitializeComponent();
        }

        private void open_child_Click(object sender, EventArgs e)
        {
            chform.dataSendEvent += new DataGetEventHandler(this.Dataget);
            chform.Show();
        }

        private void get_data_Click(object sender, EventArgs e)
        {
            
        }

        void Dataget(string data)
        {
            output_text.Text = data;
        }
    }
}

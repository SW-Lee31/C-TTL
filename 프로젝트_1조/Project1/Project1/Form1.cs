using MaterialSkin.Controls;
using Project1.DAO;
using Project1.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : MaterialForm
    {
               
        public Form1()
        {
            Theme.initTheme(this);
            InitializeComponent();
            timer1.Start();

            OraMgr.Instance.connectDB();
        }

        /// <summary>
        ///  지정 판넬 윈폼창 이동
        /// </summary>
        private bool onClick;
        private Point startPoint = new Point(0, 0);

        private void moveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            onClick = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void moveWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (onClick)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void moveWindow_MouseUp(object sender, MouseEventArgs e)
        {
            onClick = false;
        }
        // -----------------------------------------------------------------

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // 시간 매초 마다 적용 //
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.NowTime.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
        }
        // -----------------------------------------------------

        private void RefreshBT_Click(object sender, EventArgs e)
        {

        }
    }
}

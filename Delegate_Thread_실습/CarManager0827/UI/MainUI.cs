using CarManager0811.Handler;
using CarManager0811.UI;
using MaterialSkin;
using MaterialSkin.Controls;
using oracleTest0827.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace CarManager0827
{
    public partial class MainUI : MaterialForm
    {
        // mouse 이동
#pragma warning disable CS0108
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x02;
        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg,
            int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();
#pragma warning restore CS0108

        BaseAdapter adapter = new BaseAdapter();

        public const string UC_NAME_ADDCUST = "AddCustUI";
        public const string UC_NAME_ADDCAR = "AddCarUI";
        public const string UC_NAME_SALES = "SalesUI";
        public const string UC_NAME_ADMIN = "AdminUI";
        public const string UC_NAME_ORDER = "OrderUI";
    

        public MainUI()
        {
            InitializeComponent();
            centerLayout.Controls.Add(new SalesUI(adapter));
            centerLayout.Dock = DockStyle.Fill;
            XMLParser.writeXML();
            // 오라클 DB 접속
            OraMgr.Instance.connectDB();
        }

        public void controllView(UserControl uc, string viewName)
        {
            centerLayout.Controls.Clear();
            if (!centerLayout.Controls.ContainsKey(viewName))
            {
                uc.Dock = DockStyle.Fill;
                centerLayout.Controls.Add(uc);
            }
            centerLayout.Controls[viewName].BringToFront();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            initTheme();
            MainLogin mLogin = new MainLogin();
            mLogin.eventLogin += loginSuccess;

            if (mLogin.ShowDialog().Equals(DialogResult.OK))
            {
                mLogin.Close();
            }
        }

        void loginSuccess(string UserName)
        {
            MessageBox.Show(UserName + "님으로 로그인하셨습니다.");
        }

        private void mainMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCustWin_Click(object sender, EventArgs e)
        {
            controllView(new AddCustUI(adapter), UC_NAME_ADDCUST);
        }

        private void addCarWin_Click(object sender, EventArgs e)
        {
            controllView(new AddCarUI(adapter), UC_NAME_ADDCAR);
        }

        private void salesWin_Click(object sender, EventArgs e)
        {
            controllView(new SalesUI(adapter), UC_NAME_SALES);
        }

        private void adminWin_Click(object sender, EventArgs e)
        {
            new LoginUI(this).ShowDialog();
        }

        private void helpWin_Click(object sender, EventArgs e)
        {
            XMLParser.readXML();
        }

        private void topLayout_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        void initTheme()
        {
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(this);
            skin.Theme = MaterialSkinManager.Themes.LIGHT;
            skin.ColorScheme = new ColorScheme(
                Primary.Indigo800,
                Primary.Indigo800,
                Primary.LightBlue500,
                Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void MainUI_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                topLayout.Refresh();
                initTheme();
            }
        }

        private void uiSymbolButton5_Click(object sender, EventArgs e)
        {
            controllView(new OrderUI(this), UC_NAME_ORDER);
        }

        /*
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        */
    }
}

using HeadLamp_Manufacture0909.DAO;
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

namespace HeadLamp_Manufacture0909.UI.AdminUI
{
    public partial class Admin_Pro_Controller : MaterialForm
    {
        public Admin_Pro_Controller()
        {
            InitializeComponent();
        }

        private void pro1_but_Click(object sender, EventArgs e)
        {
            if (pro1_but.Text == "프로세스1 수리(사용중단)")
            {
                OraMgr.Instance.Update_Process_status("프로세스1", "수리 중");
                pro1_but.Text = "프로세스1 사용";
                pro1_but.FillColor = Color.GreenYellow;
                pro1_but.FillHoverColor = Color.ForestGreen;
                pro1_but.FillPressColor = Color.ForestGreen;
                pro1_but.FillSelectedColor = Color.GreenYellow;
            }
            else if (pro1_but.Text == "프로세스1 사용")
            {
                OraMgr.Instance.Update_Process_status("프로세스1", "정상작동");
                pro1_but.Text = "프로세스1 수리(사용중단)";
                pro1_but.FillColor = Color.OrangeRed;
                pro1_but.FillHoverColor = Color.DarkRed;
                pro1_but.FillPressColor = Color.DarkRed;
                pro1_but.FillSelectedColor = Color.OrangeRed; 
            }
        }

        private void pro2_but_Click(object sender, EventArgs e)
        {
            if (pro2_but.Text == "프로세스2 수리(사용중단)")
            {
                OraMgr.Instance.Update_Process_status("프로세스2", "수리 중");
                pro2_but.Text = "프로세스2 사용";
                pro2_but.FillColor = Color.GreenYellow;
                pro2_but.FillHoverColor = Color.ForestGreen;
                pro2_but.FillPressColor = Color.ForestGreen;
                pro2_but.FillSelectedColor = Color.GreenYellow;
            }
            else if (pro2_but.Text == "프로세스2 사용")
            {
                OraMgr.Instance.Update_Process_status("프로세스2", "정상작동");
                pro2_but.Text = "프로세스2 수리(사용중단)";
                pro2_but.FillColor = Color.OrangeRed;
                pro2_but.FillHoverColor = Color.DarkRed;
                pro2_but.FillPressColor = Color.DarkRed;
                pro2_but.FillSelectedColor = Color.OrangeRed;
            }
        }

        private void pro3_but_Click(object sender, EventArgs e)
        {
            if (pro3_but.Text == "프로세스3 수리(사용중단)")
            {
                OraMgr.Instance.Update_Process_status("프로세스3", "수리 중");
                pro3_but.Text = "프로세스3 사용";
                pro3_but.FillColor = Color.GreenYellow;
                pro3_but.FillHoverColor = Color.ForestGreen;
                pro3_but.FillPressColor = Color.ForestGreen;
                pro3_but.FillSelectedColor = Color.GreenYellow;
            }
            else if (pro3_but.Text == "프로세스3 사용")
            {
                OraMgr.Instance.Update_Process_status("프로세스3", "정상작동");
                pro3_but.Text = "프로세스3 수리(사용중단)";
                pro3_but.FillColor = Color.OrangeRed;
                pro3_but.FillHoverColor = Color.DarkRed;
                pro3_but.FillPressColor = Color.DarkRed;
                pro3_but.FillSelectedColor = Color.OrangeRed;
            }
        }

        private void pro4_but_Click(object sender, EventArgs e)
        {
            if (pro4_but.Text == "프로세스4 수리(사용중단)")
            {
                OraMgr.Instance.Update_Process_status("프로세스4", "수리 중");
                pro4_but.Text = "프로세스4 사용";
                pro4_but.FillColor = Color.GreenYellow;
                pro4_but.FillHoverColor = Color.ForestGreen;
                pro4_but.FillPressColor = Color.ForestGreen;
                pro4_but.FillSelectedColor = Color.GreenYellow;
            }
            else if (pro4_but.Text == "프로세스4 사용")
            {
                OraMgr.Instance.Update_Process_status("프로세스4", "정상작동");
                pro4_but.Text = "프로세스4 수리(사용중단)";
                pro4_but.FillColor = Color.OrangeRed;
                pro4_but.FillHoverColor = Color.DarkRed;
                pro4_but.FillPressColor = Color.DarkRed;
                pro4_but.FillSelectedColor = Color.OrangeRed;
            }
        }

        private void pro5_but_Click(object sender, EventArgs e)
        {
            if (pro5_but.Text == "프로세스5 수리(사용중단)")
            {
                OraMgr.Instance.Update_Process_status("프로세스5", "수리 중");
                pro5_but.Text = "프로세스5 사용";
                pro5_but.FillColor = Color.GreenYellow;
                pro5_but.FillHoverColor = Color.ForestGreen;
                pro5_but.FillPressColor = Color.ForestGreen;
                pro5_but.FillSelectedColor = Color.GreenYellow;
            }
            else if (pro5_but.Text == "프로세스5 사용")
            {
                OraMgr.Instance.Update_Process_status("프로세스5", "정상작동");
                pro5_but.Text = "프로세스5 수리(사용중단)";
                pro5_but.FillColor = Color.OrangeRed;
                pro5_but.FillHoverColor = Color.DarkRed;
                pro5_but.FillPressColor = Color.DarkRed;
                pro5_but.FillSelectedColor = Color.OrangeRed;
            }
        }

        private void Admin_Pro_Controller_Load(object sender, EventArgs e)
        {
            if (OraMgr.Instance.show_pro_condition("프로세스1") == "정상작동")
            {
                pro1_but.Text = "프로세스1 수리(사용중단)";
                pro1_but.FillColor = Color.OrangeRed;
                pro1_but.FillHoverColor = Color.DarkRed;
                pro1_but.FillPressColor = Color.DarkRed;
                pro1_but.FillSelectedColor = Color.OrangeRed;
            }
            else if (OraMgr.Instance.show_pro_condition("프로세스1") == "수리 중")
            {
                pro1_but.Text = "프로세스1 사용";
                pro1_but.FillColor = Color.GreenYellow;
                pro1_but.FillHoverColor = Color.ForestGreen;
                pro1_but.FillPressColor = Color.ForestGreen;
                pro1_but.FillSelectedColor = Color.GreenYellow;
            }

            if (OraMgr.Instance.show_pro_condition("프로세스2") == "정상작동")
            {
                pro2_but.Text = "프로세스2 수리(사용중단)";
                pro2_but.FillColor = Color.OrangeRed;
                pro2_but.FillHoverColor = Color.DarkRed;
                pro2_but.FillPressColor = Color.DarkRed;
                pro2_but.FillSelectedColor = Color.OrangeRed;
            }
            else if (OraMgr.Instance.show_pro_condition("프로세스2") == "수리 중")
            {
                pro2_but.Text = "프로세스2 사용";
                pro2_but.FillColor = Color.GreenYellow;
                pro2_but.FillHoverColor = Color.ForestGreen;
                pro2_but.FillPressColor = Color.ForestGreen;
                pro2_but.FillSelectedColor = Color.GreenYellow;
            }

            if (OraMgr.Instance.show_pro_condition("프로세스3") == "정상작동")
            {
                pro3_but.Text = "프로세스3 수리(사용중단)";
                pro3_but.FillColor = Color.OrangeRed;
                pro3_but.FillHoverColor = Color.DarkRed;
                pro3_but.FillPressColor = Color.DarkRed;
                pro3_but.FillSelectedColor = Color.OrangeRed;
            }
            else if (OraMgr.Instance.show_pro_condition("프로세스3") == "수리 중")
            {
                pro3_but.Text = "프로세스3 사용";
                pro3_but.FillColor = Color.GreenYellow;
                pro3_but.FillHoverColor = Color.ForestGreen;
                pro3_but.FillPressColor = Color.ForestGreen;
                pro3_but.FillSelectedColor = Color.GreenYellow;
            }

            if (OraMgr.Instance.show_pro_condition("프로세스4") == "정상작동")
            {
                pro4_but.Text = "프로세스4 수리(사용중단)";
                pro4_but.FillColor = Color.OrangeRed;
                pro4_but.FillHoverColor = Color.DarkRed;
                pro4_but.FillPressColor = Color.DarkRed;
                pro4_but.FillSelectedColor = Color.OrangeRed;
            }
            else if (OraMgr.Instance.show_pro_condition("프로세스4") == "수리 중")
            {
                pro4_but.Text = "프로세스4 사용";
                pro4_but.FillColor = Color.GreenYellow;
                pro4_but.FillHoverColor = Color.ForestGreen;
                pro4_but.FillPressColor = Color.ForestGreen;
                pro4_but.FillSelectedColor = Color.GreenYellow;
            }

            if (OraMgr.Instance.show_pro_condition("프로세스5") == "정상작동")
            {
                pro5_but.Text = "프로세스5 수리(사용중단)";
                pro5_but.FillColor = Color.OrangeRed;
                pro5_but.FillHoverColor = Color.DarkRed;
                pro5_but.FillPressColor = Color.DarkRed;
                pro5_but.FillSelectedColor = Color.OrangeRed;
            }
            else if (OraMgr.Instance.show_pro_condition("프로세스5") == "수리 중")
            {
                pro5_but.Text = "프로세스5 사용";
                pro5_but.FillColor = Color.GreenYellow;
                pro5_but.FillHoverColor = Color.ForestGreen;
                pro5_but.FillPressColor = Color.ForestGreen;
                pro5_but.FillSelectedColor = Color.GreenYellow;
            }
        }
    }
}

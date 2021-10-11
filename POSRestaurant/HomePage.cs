using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSRestaurant.Func;

namespace POSRestaurant
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            pnl_Selected.Height = btn_Home.Height;
            pnl_Selected.Top = btn_Home.Top;
            panel_Menu1.BringToFront();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            pnl_Selected.Height = btn_Home.Height;
            pnl_Selected.Top = btn_Home.Top;
            panel_Menu1.BringToFront();
        }
        private void btn_Order_Click(object sender, EventArgs e)
        {
            pnl_Selected.Height = btn_Order.Height;
            pnl_Selected.Top = btn_Order.Top;
            panel_Order1.BringToFront();
            Function.panel_Order = panel_Order1;

        }
        private void btn_Bill_Click(object sender, EventArgs e)
        {
            pnl_Selected.Height = btn_Bill.Height;
            pnl_Selected.Top = btn_Bill.Top;
            panel_Bill1.BringToFront();
        }
        private void btn_Member_Click(object sender, EventArgs e)
        {
            pnl_Selected.Height = btn_Member.Height;
            pnl_Selected.Top = btn_Member.Top;
            panel_Member1.BringToFront();
        }
        private void btn_Setting_Click(object sender, EventArgs e)
        {
            pnl_Selected.Height = btn_Setting.Height;
            pnl_Selected.Top = btn_Setting.Top;
            panel_Setting1.BringToFront();
        }
        private void btn_Master_Click(object sender, EventArgs e)
        {
            pnl_Selected.Height = btn_Master.Height;
            pnl_Selected.Top = btn_Master.Top;
            panel_Master1.BringToFront();
        }
    }
}

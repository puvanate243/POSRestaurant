using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSRestaurant
{
    public partial class Panel_Master : UserControl
    {
        public Panel_Master()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            pnl_Selected.Height = btn_Item.Height;
            pnl_Selected.Top = btn_Item.Top;
            master_Item1.BringToFront();
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            pnl_Selected.Height = btn_Item.Height;
            pnl_Selected.Top = btn_Item.Top;
            master_Item1.BringToFront();
        }
        private void btn_Table_Click(object sender, EventArgs e)
        {
            pnl_Selected.Height = btn_Table.Height;
            pnl_Selected.Top = btn_Table.Top;
            master_Table1.BringToFront();
        }
        private void btn_User_Click(object sender, EventArgs e)
        {
            pnl_Selected.Height = btn_User.Height;
            pnl_Selected.Top = btn_User.Top;
            master_User1.BringToFront();
        }
    }
}

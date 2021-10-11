using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSRestaurant.Func;

namespace POSRestaurant
{
    public partial class Item_Picked : UserControl
    {
        public Item_Picked(string ItemId)
        {
            InitializeComponent();
            Setup(ItemId);
        }

        private string _id;
        public string ItemId
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string ItemName
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _count;
        public int ItemCount
        {
            get { return _count; }
            set { _count = value; }
        }

        private void Setup(string ItemId)
        {
            string sql_get_item = @"SELECT ITEM_ID,ITEM_NAME FROM MT_ITEM WHERE ITEM_ID = '" + ItemId+"'";
            DataTable dt_get_Item = Function.ConnectDatabase(sql_get_item);

            if (dt_get_Item.Rows.Count > 0)
            {
                _id = dt_get_Item.Rows[0]["ITEM_ID"].ToString();
                _name = dt_get_Item.Rows[0]["ITEM_NAME"].ToString();
                txt_ItemName.Text = _name;
                _count = 1;
                txt_cnt.Text = "x" + _count;
            }
        }

        public void UIUpdate()
        {
            txt_ItemName.Text = _name;
            txt_cnt.Text = "x" + _count;
        }

        
    }
}

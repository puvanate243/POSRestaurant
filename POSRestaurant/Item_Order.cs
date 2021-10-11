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
using System.IO;
using System.Data.SqlClient;


namespace POSRestaurant
{
    public partial class Item_Order : UserControl
    {
        public Item_Order(string ItemId)
        {
            InitializeComponent();
            RemoveButton(false);
            CreateItemOrder(ItemId);
            ShowImage(ItemId);
        }

        public void RemoveButton(bool mode)
        {
            if (!mode)
            {
                btn_Remove.Enabled = false;
                btn_Remove.BackColor = Color.LightGray;
                btn_Remove.FlatAppearance.BorderColor = Color.Gray;
            }
            else
            {
                btn_Remove.Enabled = true;
                btn_Remove.BackColor = Color.LightPink;
                btn_Remove.FlatAppearance.BorderColor = Color.Crimson;
            }
        }

        public void CreateItemOrder(string ItemId)
        {
            string sql_get_item = @"SELECT ITEM_ID,ITEM_NAME,ITEM_PRICE FROM MT_ITEM WHERE ITEM_ID = '"+ ItemId + "'";
            DataTable dt_get_item = Function.ConnectDatabase(sql_get_item);

            if (dt_get_item.Rows.Count > 0)
            {
                txt_ItemId.Text = dt_get_item.Rows[0]["ITEM_ID"].ToString();
                txt_ItemName.Text = dt_get_item.Rows[0]["ITEM_NAME"].ToString();
                txt_Price.Text = dt_get_item.Rows[0]["ITEM_PRICE"].ToString();
            }

        }

        private void ShowImage(string id)
        {
            string sql = "SELECT IMAGE FROM MT_IMAGE WHERE ITEM_ID = '" + id + "' ";
            SqlDataReader reader = Function.ConnectDatabaseSqlDataReader(sql);
            reader.Read();
            if (reader.HasRows)
            {
                byte[] img = (byte[])(reader[0]);
                string picture = Convert.ToBase64String(img);
                MemoryStream ms = new MemoryStream(Convert.FromBase64String(picture));
                Image Image = Image.FromStream(ms);
                if (Image != null)
                {
                    pictureBox1.Image = Image;
                }

            }
            else
            {
                pictureBox1.Image = null;
            }

        }

        private void btn_Pick_Click(object sender, EventArgs e)
        {
            Function.panel_Order.AddToCart(txt_ItemId.Text);
            RemoveButton(true);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (Function.panel_Order.RemoveFromCart(txt_ItemId.Text))
            {
                RemoveButton(false);
            }
        }
    }
}

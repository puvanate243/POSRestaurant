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
    public partial class Panel_Order : UserControl
    {
        public Panel_Order()
        {
            InitializeComponent();
            ScreenSetup();
        }

        private void ScreenSetup()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel2.Controls.Clear();
                string sql_get_item = @"SELECT ITEM_ID FROM MT_ITEM " + GetSearch();
                DataTable dt_get_item = Function.ConnectDatabase(sql_get_item);
                if(dt_get_item.Rows.Count > 0)
                {
                    for (int i = 0; i < dt_get_item.Rows.Count; i++)
                    {
                        string ITEM_ID = dt_get_item.Rows[i]["ITEM_ID"].ToString();
                        Item_Order item_Order = new Item_Order(ITEM_ID);
                        flowLayoutPanel1.Controls.Add(item_Order);
                    }
                }

                string sql_get_table = @"SELECT TABLE_ID,TABLE_NAME FROM MT_TABLE";
                DataTable dt_get_table = Function.ConnectDatabase(sql_get_table);
                if(dt_get_table.Rows.Count > 0)
                {
                    for(int i = 0; i < dt_get_table.Rows.Count; i++)
                    {
                        cbb_Table.Items.Add(dt_get_table.Rows[i]["TABLE_NAME"].ToString());
                    }
                    cbb_Table.SelectedIndex = 0;
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL ERROR!,PANEL ORDER (RSOP)");
                return;
            }
        }
        private string GetSearch()
        {
            string _search = "";

            if(txt_Search.Text != "")
            {
                _search += " WHERE ITEM_NAME LIKE '%"+ txt_Search.Text + "%' ";
            }

            return _search;
        }
        public void AddToCart(string ItemId)
        {
            bool NewItem = true;
            foreach (Control controls in flowLayoutPanel2.Controls)
            {
                Item_Picked item_Picked1 = (Item_Picked)controls;
                if (ItemId == item_Picked1.ItemId)
                {
                    item_Picked1.ItemCount += 1;
                    item_Picked1.UIUpdate();
                    NewItem = false;
                }
            }

            if (NewItem)
            {
                Item_Picked item_Picked = new Item_Picked(ItemId);
                flowLayoutPanel2.Controls.Add(item_Picked);
            }
        }
        public bool RemoveFromCart(string ItemId)
        {
            foreach (Control controls in flowLayoutPanel2.Controls)
            {
                Item_Picked item_Picked1 = (Item_Picked)controls;
                if (ItemId == item_Picked1.ItemId)
                {
                    item_Picked1.ItemCount -= 1;
                    if (item_Picked1.ItemCount == 0)
                    {
                        flowLayoutPanel2.Controls.Remove(controls);
                        return true;
                    }
                    else
                    {
                        item_Picked1.UIUpdate();
                        return false;
                    }
                }
            }

            return false;
        }

        private void chk_Takehome_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Takehome.Checked)
            {
                cbb_Table.Enabled = false;
            }
            else
            {
                cbb_Table.Enabled = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            ScreenSetup();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            ScreenSetup();
        }
        private void btn_Order_Click(object sender, EventArgs e)
        {
            if(flowLayoutPanel2.Controls.Count > 0)
            {
                double Amount = 0;
                double TotalAmount = 0;
                string Table_Name = cbb_Table.SelectedItem.ToString();
                string Table_ID = Function.GetIdByName_Table(Table_Name);
                string Header_ID = "0";
                string sql_get_header = @"SELECT [VALUE] FROM [SYSTEM]
                                            WHERE VARIABLE = 'BILL_NO'
                                            UPDATE [SYSTEM] SET
                                            [VALUE] = CONVERT(INT,[VALUE])+1
                                            WHERE VARIABLE = 'BILL_NO'";
                DataTable dt_get_header = Function.ConnectDatabase(sql_get_header);
                if(dt_get_header.Rows.Count > 0)
                {
                    Header_ID = dt_get_header.Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show("Please contact admin!","SQL ERROR!!");
                    return;
                }


                foreach (Control controls in flowLayoutPanel2.Controls)
                {
                    Item_Picked item_Picked1 = (Item_Picked)controls;
                    string ItemId = item_Picked1.ItemId;
                    string ItemName = item_Picked1.ItemName;
                    int ItemCount = item_Picked1.ItemCount;
                    double ItemPrice = 0;
                    

                    string sql_get_price = @"SELECT ITEM_PRICE FROM [MT_ITEM] WHERE ITEM_ID = '" + ItemId+"'";
                    DataTable dt_get_price = Function.ConnectDatabase(sql_get_price);
                    if(dt_get_price.Rows.Count > 0)
                    {
                        ItemPrice = Function.ConvertDouble(dt_get_price.Rows[0][0].ToString());
                    }

                    Amount = ItemPrice * ItemCount;
                    TotalAmount += Amount;
                    string sql_insert_bill = @"INSERT INTO [MT_BILL]
                                                   ([BILL_NO]
                                                   ,[BILL_DATE]
                                                   ,[ITEM_ID]
                                                   ,[ITEM_COUNT]
                                                   ,[ITEM_PRICE]
                                                   ,[ITEM_AMOUNT])
                                             VALUES
                                                   ('"+ Header_ID + "' "+
                                                   ",GETDATE()"+
                                                   ",'" + ItemId + "' " +
                                                   ",'"+ ItemCount + "'" +
                                                   ",'"+ ItemPrice + "'" +
                                                   ",'"+ Amount + "')";
                    Function.ConnectDatabase(sql_insert_bill);

                }

                if (chk_Takehome.Checked)
                {
                    Table_ID = "Take Home";
                }

                string sql_insert_header = @"INSERT INTO [MT_BILL_HEADER]
                                                   ([BILL_HEADER]
                                                   ,[BILL_DATE]
                                                   ,[TOTAL_AMOUNT]
                                                   ,[TABLE_ID])
                                             VALUES
                                                   ('"+ Header_ID + "'"+
                                                   ",GETDATE()"+
                                                   ",'"+ TotalAmount + "'"+
                                                   ",'"+ Function.GetIdByName_Table(Table_Name) + "')";
                Function.ConnectDatabase(sql_insert_header);

                MessageBox.Show("Created bill!", "SYSTEM");
                txt_Search.Text = "";
                ScreenSetup();
            }
            else
            {
                MessageBox.Show("Cart is empty!","SYSTEM");
                return;
            }
        }
    }
}

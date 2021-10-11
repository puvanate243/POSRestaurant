using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using POSRestaurant.Func;

namespace POSRestaurant
{
    public partial class Master_Item : UserControl
    {
        public Master_Item()
        {
            InitializeComponent();
            DataGridSetup();
        }

        private void DataGridSetup()
        {
            try
            {
                string sql_get_data = @"SELECT ITEM_ID,ITEM_NAME,ITEM_PRICE FROM MT_ITEM";
                DataTable dt_get_data = Function.ConnectDatabase(sql_get_data);
                if(dt_get_data.Rows.Count > 0)
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = dt_get_data;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"SQL ERROR!,MASTER ITEM (DGS)");
                return;
            }
        }


        private void UploadPicture()
        {
            try
            {
                if (txt_ItemId.Text == "")
                {
                    MessageBox.Show("Please input Item Id!", "SYSTEM");
                    return;
                }
                const string strConnection = "POSRestaurantDatabase";
                SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[strConnection].ConnectionString);
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
                string image = "";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    image = open.FileName;
                }
                else
                {
                    return;
                }

                conn.Open();
                Bitmap bmp = new Bitmap(image);
                FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
                byte[] bimage = new byte[fs.Length];
                fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                string sql = "";
                string mode = CheckImageDuplicate();
                if (mode == "")
                {
                    return;
                }
                else if (mode == "Insert")
                {
                    sql = "INSERT INTO MT_IMAGE values('" + txt_ItemId.Text + "',@imgdata)";
                }
                else if (mode == "Update")
                {
                    sql = "UPDATE MT_IMAGE SET IMAGE = @imgdata WHERE ITEM_ID = '" + txt_ItemId.Text + "'";
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@imgdata", SqlDbType.Image).Value = bimage;
                cmd.ExecuteNonQuery();
                conn.Close();

                ShowImage(txt_ItemId.Text);

                MessageBox.Show("Successful!", "SYSTEM");
                return;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL ERROR!,MASTER ITEM (ULP)");
                return;
            }
        }
        private string CheckImageDuplicate()
        {
            string sql = @"SELECT IMAGE FROM MT_IMAGE WHERE ITEM_ID = '" + txt_ItemId.Text + "'";
            DataTable dt = Function.ConnectDatabase(sql);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString() != "")
                {
                    DialogResult result = MessageBox.Show("Do you want to replace old image?", "SYSTEM",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        return "Update";
                    }
                    else if (result == DialogResult.No)
                    {
                        return "";
                    }
                }
                else
                {
                    return "Update";
                }

            }
            return "Insert";
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
                    pic_Item.Image = Image;
                }

            }
            else
            {
                pic_Item.Image = null;
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                txt_ItemId.Text = dataGridView1.SelectedRows[0].Cells["ITEM_ID"].Value.ToString();
                txt_ItemName.Text = dataGridView1.SelectedRows[0].Cells["ITEM_NAME"].Value.ToString();
                txt_Price.Text = dataGridView1.SelectedRows[0].Cells["ITEM_PRICE"].Value.ToString();
                ShowImage(txt_ItemId.Text);
            }
        }


        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (btn_Edit.Text == "EDIT")
            {
                txt_ItemId.Enabled = true;
                txt_ItemName.Enabled = true;
                txt_Price.Enabled = true;
                btn_Delete.Enabled = false;
                btn_New.Enabled = false;
                btn_Edit.Text = "CANCEL";
            }
            else if(btn_Edit.Text == "CANCEL")
            {
                dataGridView1.Rows[0].Selected = true;
                txt_ItemId.Enabled = false;
                txt_ItemName.Enabled = false;
                txt_Price.Enabled = false;
                btn_Delete.Enabled = true;
                btn_New.Enabled = true;
                btn_Edit.Text = "EDIT";
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(btn_Edit.Text == "CANCEL")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string sql_update_item = @"UPDATE MT_ITEM SET ITEM_NAME = N'" + txt_ItemName.Text + "',ITEM_PRICE = '"+ Function.ConvertDouble(txt_Price.Text) + "' WHERE ITEM_ID = '" + txt_ItemId.Text + "'";
                    Function.ConnectDatabase(sql_update_item);
                }
                else
                {
                    string sql_insert_item = @"INSERT INTO MT_ITEM VALUES ('" + txt_ItemId.Text + "',N'" + txt_ItemName.Text + "','"+ Function.ConvertDouble(txt_Price.Text) + "') ";
                    Function.ConnectDatabase(sql_insert_item);
                }

                DataGridSetup();

                txt_ItemId.Enabled = false;
                txt_ItemName.Enabled = false;
                txt_Price.Enabled = false;
                btn_Delete.Enabled = true;
                btn_Edit.Enabled = true;
                btn_New.Enabled = true;
                btn_Edit.Text = "EDIT";

                MessageBox.Show("Successful!", "SYSTEM");
                return;
            }
            else
            {
                MessageBox.Show("Don't have any update!","SYSTEM");
                return;
            }
        }
        private void btn_New_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            btn_Edit.Text = "CANCEL";
            btn_Delete.Enabled = false;

            txt_ItemId.Enabled = true;
            txt_ItemName.Enabled = true;
            txt_Price.Enabled = true;

            txt_ItemId.Text = "";
            txt_ItemName.Text = "";
            txt_Price.Text = "";
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_ItemId.Text == "")
                {
                    MessageBox.Show("Please select item!","SYSTEM");
                    return;
                }

                DialogResult result = MessageBox.Show("Do you want to delete this item?", "SYSTEM",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    string delete = @"DELETE FROM MT_ITEM WHERE ITEM_ID = '" + txt_ItemId.Text + "'";
                    Function.ConnectDatabase(delete);

                    DataGridSetup();

                    MessageBox.Show("Successful!", "SYSTEM");
                    return;

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"SQL ERROR!,ITEM MASTER (BTN_DL)");
                return;
            }
        }
        private void btn_Upload_Click(object sender, EventArgs e)
        {
            UploadPicture();
        }

        private void btn_ClearPic_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "DELETE FROM MT_IMAGE WHERE ITEM_ID = '" + txt_ItemId.Text + "'";
                Function.ConnectDatabase(sql);

                pic_Item.Image = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"SQL ERROR!");
                return;
            }
        }
    }
}

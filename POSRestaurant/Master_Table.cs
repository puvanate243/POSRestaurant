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
    public partial class Master_Table : UserControl
    {
        public Master_Table()
        {
            InitializeComponent();
            DataGridSetup();
        }

        private void DataGridSetup()
        {
            try
            {
                string sql = @"SELECT TABLE_ID,TABLE_NAME FROM MT_TABLE";
                DataTable dt = Function.ConnectDatabase(sql);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL ERROR!,TABLE MASTER (SU)");
                return;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                txt_TableId.Text = dataGridView1.SelectedRows[0].Cells["TABLE_ID"].Value.ToString();
                txt_TableName.Text = dataGridView1.SelectedRows[0].Cells["TABLE_NAME"].Value.ToString();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (btn_Edit.Text == "EDIT")
            {
                txt_TableId.Enabled = true;
                txt_TableName.Enabled = true;
                btn_Delete.Enabled = false;
                btn_New.Enabled = false;
                btn_Edit.Text = "CANCEL";
            }
            else if (btn_Edit.Text == "CANCEL")
            {
                dataGridView1.Rows[0].Selected = true;
                txt_TableId.Enabled = false;
                txt_TableName.Enabled = false;
                btn_Delete.Enabled = true;
                btn_New.Enabled = true;
                btn_Edit.Text = "EDIT";
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (btn_Edit.Text == "CANCEL")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string sql_update_item = @"UPDATE MT_TABLE SET TABLE_NAME = N'" + txt_TableName.Text + "' WHERE TABLE_ID = '" + txt_TableId.Text + "'";
                    Function.ConnectDatabase(sql_update_item);
                }
                else
                {
                    string sql_insert_item = @"INSERT INTO MT_TABLE VALUES ('" + txt_TableId.Text + "',N'" + txt_TableName.Text + "') ";
                    Function.ConnectDatabase(sql_insert_item);
                }

                DataGridSetup();

                txt_TableId.Enabled = false;
                txt_TableName.Enabled = false;
                btn_Delete.Enabled = true;
                btn_Edit.Enabled = true;
                btn_New.Enabled = true;
                btn_Edit.Text = "EDIT";

                MessageBox.Show("Successful!", "SYSTEM");
                return;
            }
            else
            {
                MessageBox.Show("Don't have any update!", "SYSTEM");
                return;
            }
        }
        private void btn_New_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            btn_Edit.Text = "CANCEL";
            btn_Delete.Enabled = false;

            txt_TableId.Enabled = true;
            txt_TableName.Enabled = true;

            txt_TableId.Text = "";
            txt_TableName.Text = "";
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_TableId.Text == "")
                {
                    MessageBox.Show("Please select table!", "SYSTEM");
                    return;
                }

                DialogResult result = MessageBox.Show("Do you want to delete this table?", "SYSTEM",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    string delete = @"DELETE FROM MT_TABLE WHERE TABLE_ID = '" + txt_TableId.Text + "'";
                    Function.ConnectDatabase(delete);

                    DataGridSetup();

                    MessageBox.Show("Successful!", "SYSTEM");
                    return;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL ERROR!,TABLE MASTER (BTN_DL)");
                return;
            }
        }
    }
}

namespace POSRestaurant
{
    partial class Master_Item
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txt_ItemId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pic_Item = new System.Windows.Forms.PictureBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_ClearPic = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.ITEM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel14.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Item)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Item Master";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Item Id";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Honeydew;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.txt_ItemId);
            this.panel14.Location = new System.Drawing.Point(240, 101);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(237, 30);
            this.panel14.TabIndex = 11;
            // 
            // txt_ItemId
            // 
            this.txt_ItemId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ItemId.Enabled = false;
            this.txt_ItemId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemId.Location = new System.Drawing.Point(5, 4);
            this.txt_ItemId.Name = "txt_ItemId";
            this.txt_ItemId.Size = new System.Drawing.Size(227, 20);
            this.txt_ItemId.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_ItemName);
            this.panel1.Location = new System.Drawing.Point(240, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 30);
            this.panel1.TabIndex = 13;
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ItemName.Enabled = false;
            this.txt_ItemName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemName.Location = new System.Drawing.Point(5, 4);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(227, 20);
            this.txt_ItemName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Item Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITEM_ID,
            this.ITEM_NAME,
            this.ITEM_PRICE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(60, 334);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(705, 288);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // pic_Item
            // 
            this.pic_Item.Location = new System.Drawing.Point(545, 49);
            this.pic_Item.Name = "pic_Item";
            this.pic_Item.Size = new System.Drawing.Size(220, 220);
            this.pic_Item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Item.TabIndex = 15;
            this.pic_Item.TabStop = false;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Edit.Location = new System.Drawing.Point(61, 255);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(100, 30);
            this.btn_Edit.TabIndex = 16;
            this.btn_Edit.Text = "EDIT";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Save.Location = new System.Drawing.Point(167, 255);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 30);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Upload.FlatAppearance.BorderSize = 0;
            this.btn_Upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Upload.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Upload.Location = new System.Drawing.Point(665, 284);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(100, 30);
            this.btn_Upload.TabIndex = 18;
            this.btn_Upload.Text = "ADD PIC";
            this.btn_Upload.UseVisualStyleBackColor = false;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Delete.Location = new System.Drawing.Point(273, 255);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 30);
            this.btn_Delete.TabIndex = 19;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_New.Location = new System.Drawing.Point(379, 255);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(100, 30);
            this.btn_New.TabIndex = 20;
            this.btn_New.Text = "NEW";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_ClearPic
            // 
            this.btn_ClearPic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ClearPic.FlatAppearance.BorderSize = 0;
            this.btn_ClearPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearPic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearPic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_ClearPic.Location = new System.Drawing.Point(545, 284);
            this.btn_ClearPic.Name = "btn_ClearPic";
            this.btn_ClearPic.Size = new System.Drawing.Size(100, 30);
            this.btn_ClearPic.TabIndex = 21;
            this.btn_ClearPic.Text = "CLEAR PIC";
            this.btn_ClearPic.UseVisualStyleBackColor = false;
            this.btn_ClearPic.Click += new System.EventHandler(this.btn_ClearPic_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_Price);
            this.panel2.Location = new System.Drawing.Point(240, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 30);
            this.panel2.TabIndex = 14;
            // 
            // txt_Price
            // 
            this.txt_Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Price.Enabled = false;
            this.txt_Price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(5, 4);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(227, 20);
            this.txt_Price.TabIndex = 7;
            // 
            // ITEM_ID
            // 
            this.ITEM_ID.DataPropertyName = "ITEM_ID";
            this.ITEM_ID.HeaderText = "Item Id";
            this.ITEM_ID.Name = "ITEM_ID";
            this.ITEM_ID.ReadOnly = true;
            this.ITEM_ID.Width = 150;
            // 
            // ITEM_NAME
            // 
            this.ITEM_NAME.DataPropertyName = "ITEM_NAME";
            this.ITEM_NAME.HeaderText = "Item Name";
            this.ITEM_NAME.Name = "ITEM_NAME";
            this.ITEM_NAME.ReadOnly = true;
            this.ITEM_NAME.Width = 300;
            // 
            // ITEM_PRICE
            // 
            this.ITEM_PRICE.DataPropertyName = "ITEM_PRICE";
            this.ITEM_PRICE.HeaderText = "Price";
            this.ITEM_PRICE.Name = "ITEM_PRICE";
            this.ITEM_PRICE.ReadOnly = true;
            this.ITEM_PRICE.Width = 120;
            // 
            // Master_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_ClearPic);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.pic_Item);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Master_Item";
            this.Size = new System.Drawing.Size(820, 675);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Item)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txt_ItemId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_ItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pic_Item;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_ClearPic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_PRICE;
    }
}

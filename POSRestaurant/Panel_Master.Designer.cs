namespace POSRestaurant
{
    partial class Panel_Master
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Item = new System.Windows.Forms.Button();
            this.pnl_Selected = new System.Windows.Forms.Panel();
            this.btn_Table = new System.Windows.Forms.Button();
            this.btn_User = new System.Windows.Forms.Button();
            this.master_Item1 = new POSRestaurant.Master_Item();
            this.master_Table1 = new POSRestaurant.Master_Table();
            this.master_User1 = new POSRestaurant.Master_User();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "Master";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.btn_User);
            this.panel1.Controls.Add(this.btn_Table);
            this.panel1.Controls.Add(this.pnl_Selected);
            this.panel1.Controls.Add(this.btn_Item);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 675);
            this.panel1.TabIndex = 9;
            // 
            // btn_Item
            // 
            this.btn_Item.FlatAppearance.BorderSize = 0;
            this.btn_Item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Item.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Item.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Item.Location = new System.Drawing.Point(30, 99);
            this.btn_Item.Name = "btn_Item";
            this.btn_Item.Size = new System.Drawing.Size(140, 40);
            this.btn_Item.TabIndex = 10;
            this.btn_Item.Text = "ITEM";
            this.btn_Item.UseVisualStyleBackColor = true;
            this.btn_Item.Click += new System.EventHandler(this.btn_Item_Click);
            // 
            // pnl_Selected
            // 
            this.pnl_Selected.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnl_Selected.Location = new System.Drawing.Point(0, 98);
            this.pnl_Selected.Name = "pnl_Selected";
            this.pnl_Selected.Size = new System.Drawing.Size(29, 42);
            this.pnl_Selected.TabIndex = 11;
            // 
            // btn_Table
            // 
            this.btn_Table.FlatAppearance.BorderSize = 0;
            this.btn_Table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Table.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Table.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Table.Location = new System.Drawing.Point(30, 145);
            this.btn_Table.Name = "btn_Table";
            this.btn_Table.Size = new System.Drawing.Size(140, 40);
            this.btn_Table.TabIndex = 12;
            this.btn_Table.Text = "TABLE";
            this.btn_Table.UseVisualStyleBackColor = true;
            this.btn_Table.Click += new System.EventHandler(this.btn_Table_Click);
            // 
            // btn_User
            // 
            this.btn_User.FlatAppearance.BorderSize = 0;
            this.btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_User.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_User.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_User.Location = new System.Drawing.Point(30, 191);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(140, 40);
            this.btn_User.TabIndex = 13;
            this.btn_User.Text = "USER";
            this.btn_User.UseVisualStyleBackColor = true;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // master_Item1
            // 
            this.master_Item1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.master_Item1.Location = new System.Drawing.Point(180, 0);
            this.master_Item1.Name = "master_Item1";
            this.master_Item1.Size = new System.Drawing.Size(820, 675);
            this.master_Item1.TabIndex = 10;
            // 
            // master_Table1
            // 
            this.master_Table1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.master_Table1.Location = new System.Drawing.Point(180, 0);
            this.master_Table1.Name = "master_Table1";
            this.master_Table1.Size = new System.Drawing.Size(820, 675);
            this.master_Table1.TabIndex = 11;
            // 
            // master_User1
            // 
            this.master_User1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.master_User1.Location = new System.Drawing.Point(180, 0);
            this.master_User1.Name = "master_User1";
            this.master_User1.Size = new System.Drawing.Size(820, 675);
            this.master_User1.TabIndex = 12;
            // 
            // Panel_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.master_User1);
            this.Controls.Add(this.master_Table1);
            this.Controls.Add(this.master_Item1);
            this.Controls.Add(this.panel1);
            this.Name = "Panel_Master";
            this.Size = new System.Drawing.Size(1000, 675);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Item;
        private System.Windows.Forms.Panel pnl_Selected;
        private Master_Item master_Item1;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_Table;
        private Master_Table master_Table1;
        private Master_User master_User1;
    }
}

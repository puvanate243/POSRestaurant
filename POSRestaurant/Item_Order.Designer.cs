namespace POSRestaurant
{
    partial class Item_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item_Order));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_ItemName = new System.Windows.Forms.Label();
            this.btn_Pick = new System.Windows.Forms.Button();
            this.txt_Price = new System.Windows.Forms.Label();
            this.txt_ItemId = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemName.Location = new System.Drawing.Point(15, 164);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(166, 33);
            this.txt_ItemName.TabIndex = 12;
            this.txt_ItemName.Text = "Beef Burger";
            this.txt_ItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Pick
            // 
            this.btn_Pick.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Pick.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_Pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pick.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pick.Location = new System.Drawing.Point(13, 246);
            this.btn_Pick.Name = "btn_Pick";
            this.btn_Pick.Size = new System.Drawing.Size(85, 35);
            this.btn_Pick.TabIndex = 11;
            this.btn_Pick.Text = "ADD";
            this.btn_Pick.UseVisualStyleBackColor = false;
            this.btn_Pick.Click += new System.EventHandler(this.btn_Pick_Click);
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(42, 202);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(113, 33);
            this.txt_Price.TabIndex = 10;
            this.txt_Price.Text = "2.79 $";
            this.txt_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ItemId
            // 
            this.txt_ItemId.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemId.Location = new System.Drawing.Point(15, 0);
            this.txt_ItemId.Name = "txt_ItemId";
            this.txt_ItemId.Size = new System.Drawing.Size(166, 33);
            this.txt_ItemId.TabIndex = 13;
            this.txt_ItemId.Text = "U01";
            this.txt_ItemId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_ItemId.Visible = false;
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.Pink;
            this.btn_Remove.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remove.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Location = new System.Drawing.Point(101, 246);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(85, 35);
            this.btn_Remove.TabIndex = 14;
            this.btn_Remove.Text = "REMOVE";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // Item_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.txt_ItemId);
            this.Controls.Add(this.txt_ItemName);
            this.Controls.Add(this.btn_Pick);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Item_Order";
            this.Size = new System.Drawing.Size(200, 290);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txt_ItemName;
        private System.Windows.Forms.Button btn_Pick;
        private System.Windows.Forms.Label txt_Price;
        private System.Windows.Forms.Label txt_ItemId;
        private System.Windows.Forms.Button btn_Remove;
    }
}

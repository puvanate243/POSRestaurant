namespace POSRestaurant
{
    partial class Item_Picked
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
            this.txt_ItemName = new System.Windows.Forms.Label();
            this.txt_cnt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemName.Location = new System.Drawing.Point(3, 0);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(207, 30);
            this.txt_ItemName.TabIndex = 8;
            this.txt_ItemName.Text = "ItemName";
            this.txt_ItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_cnt
            // 
            this.txt_cnt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cnt.Location = new System.Drawing.Point(229, 0);
            this.txt_cnt.Name = "txt_cnt";
            this.txt_cnt.Size = new System.Drawing.Size(72, 30);
            this.txt_cnt.TabIndex = 9;
            this.txt_cnt.Text = "1x";
            this.txt_cnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Item_Picked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.txt_cnt);
            this.Controls.Add(this.txt_ItemName);
            this.Name = "Item_Picked";
            this.Size = new System.Drawing.Size(300, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txt_ItemName;
        private System.Windows.Forms.Label txt_cnt;
    }
}

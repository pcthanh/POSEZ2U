namespace POSEZ2U.UC
{
    partial class UCOrder
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNameItem = new System.Windows.Forms.Label();
            this.lblQuanityItem = new System.Windows.Forms.Label();
            this.lblPriceItem = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblNameItem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQuanityItem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPriceItem, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(287, 37);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNameItem
            // 
            this.lblNameItem.AutoSize = true;
            this.lblNameItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameItem.Location = new System.Drawing.Point(3, 0);
            this.lblNameItem.Name = "lblNameItem";
            this.lblNameItem.Size = new System.Drawing.Size(137, 37);
            this.lblNameItem.TabIndex = 0;
            this.lblNameItem.Text = "Com chien";
            this.lblNameItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameItem.Click += new System.EventHandler(this.UCOrder_Click);
            // 
            // lblQuanityItem
            // 
            this.lblQuanityItem.AutoSize = true;
            this.lblQuanityItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuanityItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanityItem.Location = new System.Drawing.Point(146, 0);
            this.lblQuanityItem.Name = "lblQuanityItem";
            this.lblQuanityItem.Size = new System.Drawing.Size(65, 37);
            this.lblQuanityItem.TabIndex = 0;
            this.lblQuanityItem.Text = "1";
            this.lblQuanityItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPriceItem
            // 
            this.lblPriceItem.AutoSize = true;
            this.lblPriceItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPriceItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceItem.Location = new System.Drawing.Point(217, 0);
            this.lblPriceItem.Name = "lblPriceItem";
            this.lblPriceItem.Size = new System.Drawing.Size(67, 37);
            this.lblPriceItem.TabIndex = 0;
            this.lblPriceItem.Text = "4.00";
            this.lblPriceItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCOrder";
            this.Size = new System.Drawing.Size(287, 37);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lblNameItem;
        public System.Windows.Forms.Label lblQuanityItem;
        public System.Windows.Forms.Label lblPriceItem;
    }
}

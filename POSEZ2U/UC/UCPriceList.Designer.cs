namespace POSEZ2U.UC
{
    partial class UCPriceList
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
            this.lblPriceSizeProduct = new System.Windows.Forms.Label();
            this.lblPriceNameProduct = new System.Windows.Forms.Label();
            this.lblPriceProduct = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.Controls.Add(this.lblPriceSizeProduct, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPriceNameProduct, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPriceProduct, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 47);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPriceSizeProduct
            // 
            this.lblPriceSizeProduct.AutoSize = true;
            this.lblPriceSizeProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPriceSizeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceSizeProduct.Location = new System.Drawing.Point(220, 0);
            this.lblPriceSizeProduct.Name = "lblPriceSizeProduct";
            this.lblPriceSizeProduct.Size = new System.Drawing.Size(167, 47);
            this.lblPriceSizeProduct.TabIndex = 0;
            this.lblPriceSizeProduct.Text = "Portions";
            this.lblPriceSizeProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPriceSizeProduct.Click += new System.EventHandler(this.UCPriceList_Click);
            // 
            // lblPriceNameProduct
            // 
            this.lblPriceNameProduct.AutoSize = true;
            this.lblPriceNameProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPriceNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceNameProduct.Location = new System.Drawing.Point(3, 0);
            this.lblPriceNameProduct.Name = "lblPriceNameProduct";
            this.lblPriceNameProduct.Size = new System.Drawing.Size(211, 47);
            this.lblPriceNameProduct.TabIndex = 0;
            this.lblPriceNameProduct.Text = "Product";
            this.lblPriceNameProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPriceNameProduct.Click += new System.EventHandler(this.UCPriceList_Click);
            // 
            // lblPriceProduct
            // 
            this.lblPriceProduct.AutoSize = true;
            this.lblPriceProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPriceProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceProduct.Location = new System.Drawing.Point(393, 0);
            this.lblPriceProduct.Name = "lblPriceProduct";
            this.lblPriceProduct.Size = new System.Drawing.Size(82, 47);
            this.lblPriceProduct.TabIndex = 0;
            this.lblPriceProduct.Text = "Price";
            this.lblPriceProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPriceProduct.Click += new System.EventHandler(this.UCPriceList_Click);
            // 
            // UCPriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCPriceList";
            this.Size = new System.Drawing.Size(478, 47);
            this.Load += new System.EventHandler(this.UCPriceList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lblPriceSizeProduct;
        public System.Windows.Forms.Label lblPriceNameProduct;
        public System.Windows.Forms.Label lblPriceProduct;
    }
}

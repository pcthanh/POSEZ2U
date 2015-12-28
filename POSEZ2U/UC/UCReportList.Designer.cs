namespace POSEZ2U.UC
{
    partial class UCReportList
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
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblIINVNumber = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.Controls.Add(this.lblOrderID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIINVNumber, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCreateDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInvoice, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotal, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 47);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(203, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(83, 47);
            this.lblOrderID.TabIndex = 2;
            this.lblOrderID.Text = "OrderID";
            this.lblOrderID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIINVNumber
            // 
            this.lblIINVNumber.AutoSize = true;
            this.lblIINVNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIINVNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIINVNumber.Location = new System.Drawing.Point(92, 0);
            this.lblIINVNumber.Name = "lblIINVNumber";
            this.lblIINVNumber.Size = new System.Drawing.Size(105, 47);
            this.lblIINVNumber.TabIndex = 1;
            this.lblIINVNumber.Text = "INV Number";
            this.lblIINVNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDate.Location = new System.Drawing.Point(292, 0);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(105, 47);
            this.lblCreateDate.TabIndex = 0;
            this.lblCreateDate.Text = "Create Date";
            this.lblCreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCreateDate.Click += new System.EventHandler(this.UCPriceList_Click);
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.Location = new System.Drawing.Point(3, 0);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(83, 47);
            this.lblInvoice.TabIndex = 0;
            this.lblInvoice.Text = "InvoiceID";
            this.lblInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvoice.Click += new System.EventHandler(this.UCPriceList_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(403, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 47);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotal.Click += new System.EventHandler(this.UCPriceList_Click);
            // 
            // UCReportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCReportList";
            this.Size = new System.Drawing.Size(491, 47);
            this.Load += new System.EventHandler(this.UCPriceList_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lblCreateDate;
        public System.Windows.Forms.Label lblInvoice;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblOrderID;
        public System.Windows.Forms.Label lblIINVNumber;
    }
}

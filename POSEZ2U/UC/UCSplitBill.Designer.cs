namespace POSEZ2U.UC
{
    partial class UCSplitBill
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
            this.lblMethodType = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lblMethodType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblClose, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(271, 42);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lblMethodType
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lblMethodType, 2);
            this.lblMethodType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMethodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethodType.Location = new System.Drawing.Point(0, 0);
            this.lblMethodType.Margin = new System.Windows.Forms.Padding(0);
            this.lblMethodType.Name = "lblMethodType";
            this.lblMethodType.Size = new System.Drawing.Size(180, 42);
            this.lblMethodType.TabIndex = 0;
            this.lblMethodType.Text = "label1";
            this.lblMethodType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClose
            // 
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(180, 0);
            this.lblClose.Margin = new System.Windows.Forms.Padding(0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(91, 42);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblClose.Click += new System.EventHandler(this.UCSplitBill_Click);
            // 
            // UCSplitBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCSplitBill";
            this.Size = new System.Drawing.Size(271, 42);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lblMethodType;
        public System.Windows.Forms.Label lblClose;
    }
}

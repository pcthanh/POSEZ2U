namespace POSEZ2U.UC
{
    partial class UCPortion
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
            this.lblPortion = new System.Windows.Forms.Label();
            this.lblMultiply = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lblPortion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMultiply, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPrice, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(548, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPortion
            // 
            this.lblPortion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPortion.Location = new System.Drawing.Point(3, 0);
            this.lblPortion.Name = "lblPortion";
            this.lblPortion.Size = new System.Drawing.Size(176, 40);
            this.lblPortion.TabIndex = 0;
            this.lblPortion.Text = "Portion";
            this.lblPortion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMultiply
            // 
            this.lblMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMultiply.Location = new System.Drawing.Point(185, 0);
            this.lblMultiply.Name = "lblMultiply";
            this.lblMultiply.Size = new System.Drawing.Size(176, 40);
            this.lblMultiply.TabIndex = 0;
            this.lblMultiply.Text = "Multiply";
            this.lblMultiply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Location = new System.Drawing.Point(367, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(178, 40);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCPortion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCPortion";
            this.Size = new System.Drawing.Size(548, 40);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPortion;
        private System.Windows.Forms.Label lblMultiply;
        private System.Windows.Forms.Label lblPrice;
    }
}

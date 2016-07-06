namespace POSEZ2U.UC
{
    partial class UCRefund
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRefund));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcRefund = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRefund = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcRefund)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pcRefund);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 27);
            this.panel1.TabIndex = 0;
            // 
            // pcRefund
            // 
            this.pcRefund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcRefund.Image = ((System.Drawing.Image)(resources.GetObject("pcRefund.Image")));
            this.pcRefund.Location = new System.Drawing.Point(0, 10);
            this.pcRefund.Name = "pcRefund";
            this.pcRefund.Size = new System.Drawing.Size(68, 17);
            this.pcRefund.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcRefund.TabIndex = 1;
            this.pcRefund.TabStop = false;
            this.pcRefund.Click += new System.EventHandler(this.UCRefund_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 10);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblRefund);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 25);
            this.panel2.TabIndex = 1;
            // 
            // lblRefund
            // 
            this.lblRefund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefund.ForeColor = System.Drawing.Color.White;
            this.lblRefund.Location = new System.Drawing.Point(0, 0);
            this.lblRefund.Name = "lblRefund";
            this.lblRefund.Size = new System.Drawing.Size(68, 25);
            this.lblRefund.TabIndex = 0;
            this.lblRefund.Text = "REFUND";
            this.lblRefund.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRefund.Click += new System.EventHandler(this.UCRefund_Click);
            // 
            // UCRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCRefund";
            this.Size = new System.Drawing.Size(68, 52);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcRefund)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblRefund;
        private System.Windows.Forms.PictureBox pcRefund;
    }
}

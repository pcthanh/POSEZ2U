namespace POSEZ2U.UC
{
    partial class UCBtnPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBtnPayment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPayment = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPayment = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPayment)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbPayment);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 27);
            this.panel1.TabIndex = 0;
            // 
            // pbPayment
            // 
            this.pbPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPayment.Image = ((System.Drawing.Image)(resources.GetObject("pbPayment.Image")));
            this.pbPayment.Location = new System.Drawing.Point(0, 10);
            this.pbPayment.Name = "pbPayment";
            this.pbPayment.Size = new System.Drawing.Size(68, 17);
            this.pbPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPayment.TabIndex = 1;
            this.pbPayment.TabStop = false;
            this.pbPayment.Click += new System.EventHandler(this.UCBtnPayment_Click);
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
            this.panel2.Controls.Add(this.lblPayment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 25);
            this.panel2.TabIndex = 1;
            // 
            // lblPayment
            // 
            this.lblPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.White;
            this.lblPayment.Location = new System.Drawing.Point(0, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(68, 25);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "PAYMENT";
            this.lblPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPayment.Click += new System.EventHandler(this.UCBtnPayment_Click);
            // 
            // UCBtnPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCBtnPayment";
            this.Size = new System.Drawing.Size(68, 52);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPayment)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.PictureBox pbPayment;
    }
}

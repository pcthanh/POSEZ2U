namespace POSEZ2U.UC
{
    partial class UCPePrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPePrint));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbRePrint = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPrePrint = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRePrint)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbRePrint);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 27);
            this.panel1.TabIndex = 0;
            // 
            // pbRePrint
            // 
            this.pbRePrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRePrint.Image = ((System.Drawing.Image)(resources.GetObject("pbRePrint.Image")));
            this.pbRePrint.Location = new System.Drawing.Point(0, 10);
            this.pbRePrint.Name = "pbRePrint";
            this.pbRePrint.Size = new System.Drawing.Size(68, 17);
            this.pbRePrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRePrint.TabIndex = 1;
            this.pbRePrint.TabStop = false;
            this.pbRePrint.Click += new System.EventHandler(this.UCPePrint_Click);
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
            this.panel2.Controls.Add(this.lblPrePrint);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 25);
            this.panel2.TabIndex = 1;
            // 
            // lblPrePrint
            // 
            this.lblPrePrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrePrint.ForeColor = System.Drawing.Color.White;
            this.lblPrePrint.Location = new System.Drawing.Point(0, 0);
            this.lblPrePrint.Name = "lblPrePrint";
            this.lblPrePrint.Size = new System.Drawing.Size(68, 25);
            this.lblPrePrint.TabIndex = 0;
            this.lblPrePrint.Text = "P.DOCKET";
            this.lblPrePrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrePrint.Click += new System.EventHandler(this.UCPePrint_Click);
            // 
            // UCPePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCPePrint";
            this.Size = new System.Drawing.Size(68, 52);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRePrint)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbRePrint;
        private System.Windows.Forms.Label lblPrePrint;
    }
}

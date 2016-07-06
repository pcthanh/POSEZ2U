namespace POSEZ2U.UC
{
    partial class UCAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAcc = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pcAcc = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 95);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblAcc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 44);
            this.panel2.TabIndex = 1;
            // 
            // lblAcc
            // 
            this.lblAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcc.Location = new System.Drawing.Point(0, 0);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(184, 44);
            this.lblAcc.TabIndex = 0;
            this.lblAcc.Text = "ACCOUNTS";
            this.lblAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAcc.Click += new System.EventHandler(this.UCAccount_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pcAcc);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 51);
            this.panel3.TabIndex = 2;
            // 
            // pcAcc
            // 
            this.pcAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcAcc.Image = ((System.Drawing.Image)(resources.GetObject("pcAcc.Image")));
            this.pcAcc.Location = new System.Drawing.Point(0, 0);
            this.pcAcc.Name = "pcAcc";
            this.pcAcc.Size = new System.Drawing.Size(39, 51);
            this.pcAcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcAcc.TabIndex = 1;
            this.pcAcc.TabStop = false;
            this.pcAcc.Click += new System.EventHandler(this.UCAccount_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(39, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(145, 51);
            this.panel4.TabIndex = 0;
            this.panel4.Click += new System.EventHandler(this.UCAccount_Click);
            // 
            // UCAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCAccount";
            this.Size = new System.Drawing.Size(194, 95);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.PictureBox pcAcc;
    }
}

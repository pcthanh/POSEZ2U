namespace POSEZ2U.UC
{
    partial class UCVoidAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCVoidAll));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVoidAll = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbVoidAll = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoidAll)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbVoidAll);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 27);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblVoidAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 25);
            this.panel2.TabIndex = 1;
            // 
            // lblVoidAll
            // 
            this.lblVoidAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVoidAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoidAll.ForeColor = System.Drawing.Color.White;
            this.lblVoidAll.Location = new System.Drawing.Point(0, 0);
            this.lblVoidAll.Name = "lblVoidAll";
            this.lblVoidAll.Size = new System.Drawing.Size(68, 25);
            this.lblVoidAll.TabIndex = 0;
            this.lblVoidAll.Text = "VOID ALL";
            this.lblVoidAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVoidAll.Click += new System.EventHandler(this.UCVoidAll_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 10);
            this.panel3.TabIndex = 0;
            // 
            // pbVoidAll
            // 
            this.pbVoidAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbVoidAll.Image = ((System.Drawing.Image)(resources.GetObject("pbVoidAll.Image")));
            this.pbVoidAll.Location = new System.Drawing.Point(0, 10);
            this.pbVoidAll.Name = "pbVoidAll";
            this.pbVoidAll.Size = new System.Drawing.Size(68, 17);
            this.pbVoidAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoidAll.TabIndex = 1;
            this.pbVoidAll.TabStop = false;
            this.pbVoidAll.Click += new System.EventHandler(this.UCVoidAll_Click);
            // 
            // UCVoidAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCVoidAll";
            this.Size = new System.Drawing.Size(68, 52);
           
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVoidAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblVoidAll;
        private System.Windows.Forms.PictureBox pbVoidAll;
        private System.Windows.Forms.Panel panel3;

    }
}

namespace POSEZ2U.UC
{
    partial class UCVoidItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCVoidItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbVoid = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVoid = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbVoid);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 27);
            this.panel1.TabIndex = 0;
            // 
            // pbVoid
            // 
            this.pbVoid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbVoid.Image = ((System.Drawing.Image)(resources.GetObject("pbVoid.Image")));
            this.pbVoid.Location = new System.Drawing.Point(0, 10);
            this.pbVoid.Name = "pbVoid";
            this.pbVoid.Size = new System.Drawing.Size(68, 17);
            this.pbVoid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoid.TabIndex = 0;
            this.pbVoid.TabStop = false;
            this.pbVoid.Click += new System.EventHandler(this.UCVoidItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblVoid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 25);
            this.panel2.TabIndex = 1;
            // 
            // lblVoid
            // 
            this.lblVoid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoid.ForeColor = System.Drawing.Color.White;
            this.lblVoid.Location = new System.Drawing.Point(0, 0);
            this.lblVoid.Name = "lblVoid";
            this.lblVoid.Size = new System.Drawing.Size(68, 25);
            this.lblVoid.TabIndex = 0;
            this.lblVoid.Text = "VOID";
            this.lblVoid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVoid.Click += new System.EventHandler(this.UCVoidItem_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 10);
            this.panel3.TabIndex = 0;
            // 
            // UCVoidItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCVoidItem";
            this.Size = new System.Drawing.Size(68, 52);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVoid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblVoid;
        private System.Windows.Forms.PictureBox pbVoid;
        private System.Windows.Forms.Panel panel3;
    }
}

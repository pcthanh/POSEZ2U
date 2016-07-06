namespace POSEZ2U.UC
{
    partial class UCRice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcPrice = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcPrice)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pcPrice);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 27);
            this.panel1.TabIndex = 0;
            // 
            // pcPrice
            // 
            this.pcPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcPrice.Image = ((System.Drawing.Image)(resources.GetObject("pcPrice.Image")));
            this.pcPrice.Location = new System.Drawing.Point(0, 10);
            this.pcPrice.Name = "pcPrice";
            this.pcPrice.Size = new System.Drawing.Size(68, 17);
            this.pcPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcPrice.TabIndex = 1;
            this.pcPrice.TabStop = false;
            this.pcPrice.Click += new System.EventHandler(this.UCRice_Click);
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
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 25);
            this.panel2.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(0, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(68, 25);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "PRICE";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrice.Click += new System.EventHandler(this.UCRice_Click);
            // 
            // UCRice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCRice";
            this.Size = new System.Drawing.Size(68, 52);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcPrice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pcPrice;
        private System.Windows.Forms.Label lblPrice;
    }
}

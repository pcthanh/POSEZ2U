namespace POSEZ2U.UC
{
    partial class UCPreOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPreOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPreOrder = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPreOrder = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreOrder)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbPreOrder);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 27);
            this.panel1.TabIndex = 0;
            // 
            // pbPreOrder
            // 
            this.pbPreOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPreOrder.Image = ((System.Drawing.Image)(resources.GetObject("pbPreOrder.Image")));
            this.pbPreOrder.Location = new System.Drawing.Point(0, 10);
            this.pbPreOrder.Name = "pbPreOrder";
            this.pbPreOrder.Size = new System.Drawing.Size(68, 17);
            this.pbPreOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreOrder.TabIndex = 1;
            this.pbPreOrder.TabStop = false;
            this.pbPreOrder.Click += new System.EventHandler(this.UCPreOrder_Click);
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
            this.panel2.Controls.Add(this.lblPreOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 25);
            this.panel2.TabIndex = 1;
            // 
            // lblPreOrder
            // 
            this.lblPreOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPreOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreOrder.ForeColor = System.Drawing.Color.White;
            this.lblPreOrder.Location = new System.Drawing.Point(0, 0);
            this.lblPreOrder.Name = "lblPreOrder";
            this.lblPreOrder.Size = new System.Drawing.Size(68, 25);
            this.lblPreOrder.TabIndex = 0;
            this.lblPreOrder.Text = "PRE.ORD";
            this.lblPreOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPreOrder.Click += new System.EventHandler(this.UCPreOrder_Click);
            // 
            // UCPreOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCPreOrder";
            this.Size = new System.Drawing.Size(68, 52);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbPreOrder;
        private System.Windows.Forms.Label lblPreOrder;
    }
}

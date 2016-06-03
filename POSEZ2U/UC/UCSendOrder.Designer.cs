namespace POSEZ2U.UC
{
    partial class UCSendOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSendOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBSendOrder = new System.Windows.Forms.PictureBox();
            this.lblSendOrder = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBSendOrder)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pBSendOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 63);
            this.panel1.TabIndex = 0;
            // 
            // pBSendOrder
            // 
            this.pBSendOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBSendOrder.Image = ((System.Drawing.Image)(resources.GetObject("pBSendOrder.Image")));
            this.pBSendOrder.Location = new System.Drawing.Point(0, 0);
            this.pBSendOrder.Name = "pBSendOrder";
            this.pBSendOrder.Size = new System.Drawing.Size(74, 63);
            this.pBSendOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBSendOrder.TabIndex = 4;
            this.pBSendOrder.TabStop = false;
            this.pBSendOrder.Click += new System.EventHandler(this.UCSendOrder_Click);
            // 
            // lblSendOrder
            // 
            this.lblSendOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSendOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendOrder.ForeColor = System.Drawing.Color.White;
            this.lblSendOrder.Location = new System.Drawing.Point(0, 0);
            this.lblSendOrder.Name = "lblSendOrder";
            this.lblSendOrder.Size = new System.Drawing.Size(74, 45);
            this.lblSendOrder.TabIndex = 1;
            this.lblSendOrder.Text = "S.ORDER";
            this.lblSendOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSendOrder.Click += new System.EventHandler(this.UCSendOrder_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSendOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 45);
            this.panel2.TabIndex = 1;
            // 
            // UCSendOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCSendOrder";
            this.Size = new System.Drawing.Size(74, 108);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBSendOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSendOrder;
        private System.Windows.Forms.PictureBox pBSendOrder;
        private System.Windows.Forms.Panel panel2;
    }
}

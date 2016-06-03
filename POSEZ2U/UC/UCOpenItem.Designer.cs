namespace POSEZ2U.UC
{
    partial class UCOpenItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCOpenItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbOpenItem = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOpenItem = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenItem)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbOpenItem);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 27);
            this.panel1.TabIndex = 0;
            // 
            // pbOpenItem
            // 
            this.pbOpenItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbOpenItem.Image = ((System.Drawing.Image)(resources.GetObject("pbOpenItem.Image")));
            this.pbOpenItem.Location = new System.Drawing.Point(0, 10);
            this.pbOpenItem.Name = "pbOpenItem";
            this.pbOpenItem.Size = new System.Drawing.Size(68, 17);
            this.pbOpenItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOpenItem.TabIndex = 1;
            this.pbOpenItem.TabStop = false;
            this.pbOpenItem.Click += new System.EventHandler(this.UCOpenItem_Click);
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
            this.panel2.Controls.Add(this.lblOpenItem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 25);
            this.panel2.TabIndex = 1;
            // 
            // lblOpenItem
            // 
            this.lblOpenItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOpenItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenItem.ForeColor = System.Drawing.Color.White;
            this.lblOpenItem.Location = new System.Drawing.Point(0, 0);
            this.lblOpenItem.Name = "lblOpenItem";
            this.lblOpenItem.Size = new System.Drawing.Size(68, 25);
            this.lblOpenItem.TabIndex = 0;
            this.lblOpenItem.Text = "OPEN ITEM";
            this.lblOpenItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOpenItem.Click += new System.EventHandler(this.UCOpenItem_Click);
            // 
            // UCOpenItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCOpenItem";
            this.Size = new System.Drawing.Size(68, 52);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenItem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbOpenItem;
        private System.Windows.Forms.Label lblOpenItem;

    }
}

namespace POSEZ2U.UC
{
    partial class UCFloorPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFloorPlan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFloor = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pcFloor = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcFloor)).BeginInit();
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
            this.panel2.Controls.Add(this.lblFloor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 44);
            this.panel2.TabIndex = 1;
            // 
            // lblFloor
            // 
            this.lblFloor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloor.Location = new System.Drawing.Point(0, 0);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(184, 44);
            this.lblFloor.TabIndex = 0;
            this.lblFloor.Text = "FLOOR PLAN";
            this.lblFloor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFloor.Click += new System.EventHandler(this.UCFloorPlan_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pcFloor);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 51);
            this.panel3.TabIndex = 2;
            // 
            // pcFloor
            // 
            this.pcFloor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcFloor.Image = ((System.Drawing.Image)(resources.GetObject("pcFloor.Image")));
            this.pcFloor.Location = new System.Drawing.Point(0, 0);
            this.pcFloor.Name = "pcFloor";
            this.pcFloor.Size = new System.Drawing.Size(39, 51);
            this.pcFloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcFloor.TabIndex = 1;
            this.pcFloor.TabStop = false;
            this.pcFloor.Click += new System.EventHandler(this.UCFloorPlan_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(39, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(145, 51);
            this.panel4.TabIndex = 0;
            this.panel4.Click += new System.EventHandler(this.UCFloorPlan_Click);
            // 
            // UCFloorPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCFloorPlan";
            this.Size = new System.Drawing.Size(194, 95);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcFloor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.PictureBox pcFloor;
    }
}

namespace POSEZ2U.UC
{
    partial class UCAddseat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddseat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbAddseat = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAddseat = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddseat)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbAddseat);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 27);
            this.panel1.TabIndex = 0;
            // 
            // pbAddseat
            // 
            this.pbAddseat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAddseat.Image = ((System.Drawing.Image)(resources.GetObject("pbAddseat.Image")));
            this.pbAddseat.Location = new System.Drawing.Point(0, 10);
            this.pbAddseat.Name = "pbAddseat";
            this.pbAddseat.Size = new System.Drawing.Size(68, 17);
            this.pbAddseat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddseat.TabIndex = 1;
            this.pbAddseat.TabStop = false;
            this.pbAddseat.Click += new System.EventHandler(this.UCAddseat_Click);
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
            this.panel2.Controls.Add(this.lblAddseat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 25);
            this.panel2.TabIndex = 1;
            // 
            // lblAddseat
            // 
            this.lblAddseat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddseat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddseat.ForeColor = System.Drawing.Color.White;
            this.lblAddseat.Location = new System.Drawing.Point(0, 0);
            this.lblAddseat.Name = "lblAddseat";
            this.lblAddseat.Size = new System.Drawing.Size(68, 25);
            this.lblAddseat.TabIndex = 0;
            this.lblAddseat.Text = "ADD SEAT";
            this.lblAddseat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddseat.Click += new System.EventHandler(this.UCAddseat_Click);
            // 
            // UCAddseat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCAddseat";
            this.Size = new System.Drawing.Size(68, 52);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddseat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAddseat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbAddseat;
    }
}

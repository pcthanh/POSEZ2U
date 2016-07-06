namespace POSEZ2U.UC
{
    partial class UCNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNote));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbNote = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNote = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNote)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbNote);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 27);
            this.panel1.TabIndex = 0;
            // 
            // pbNote
            // 
            this.pbNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbNote.Image = ((System.Drawing.Image)(resources.GetObject("pbNote.Image")));
            this.pbNote.Location = new System.Drawing.Point(0, 10);
            this.pbNote.Name = "pbNote";
            this.pbNote.Size = new System.Drawing.Size(68, 17);
            this.pbNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNote.TabIndex = 1;
            this.pbNote.TabStop = false;
            this.pbNote.Click += new System.EventHandler(this.UCNote_Click);
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
            this.panel2.Controls.Add(this.lblNote);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 25);
            this.panel2.TabIndex = 1;
            // 
            // lblNote
            // 
            this.lblNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(0, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(68, 25);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "NOTE";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNote.Click += new System.EventHandler(this.UCNote_Click);
            // 
            // UCNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCNote";
            this.Size = new System.Drawing.Size(68, 52);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNote)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbNote;
        private System.Windows.Forms.Label lblNote;
    }
}

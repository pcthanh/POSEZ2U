namespace POSEZ2U.UC
{
    partial class UCProductIncl
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
            this.lblNameGroupIncl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameGroupIncl
            // 
            this.lblNameGroupIncl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblNameGroupIncl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameGroupIncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameGroupIncl.Location = new System.Drawing.Point(0, 0);
            this.lblNameGroupIncl.Name = "lblNameGroupIncl";
            this.lblNameGroupIncl.Size = new System.Drawing.Size(107, 44);
            this.lblNameGroupIncl.TabIndex = 1;
            this.lblNameGroupIncl.Text = "Coffee";
            this.lblNameGroupIncl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNameGroupIncl.Click += new System.EventHandler(this.UCProductIncl_Click);
            // 
            // UCProductIncl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNameGroupIncl);
            this.Name = "UCProductIncl";
            this.Size = new System.Drawing.Size(107, 44);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblNameGroupIncl;
    }
}

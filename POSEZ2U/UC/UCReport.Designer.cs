namespace POSEZ2U.UC
{
    partial class UCReport
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
            this.lblTitleReport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleReport
            // 
            this.lblTitleReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleReport.Location = new System.Drawing.Point(0, 0);
            this.lblTitleReport.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitleReport.Name = "lblTitleReport";
            this.lblTitleReport.Size = new System.Drawing.Size(184, 32);
            this.lblTitleReport.TabIndex = 0;
            this.lblTitleReport.Text = "label1";
            this.lblTitleReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitleReport.Click += new System.EventHandler(this.UCReport_Click);
            // 
            // UCReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitleReport);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCReport";
            this.Size = new System.Drawing.Size(184, 32);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTitleReport;

    }
}

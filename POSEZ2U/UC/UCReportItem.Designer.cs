namespace POSEZ2U.UC
{
    partial class UCReportItem
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
            this.lblTitelReportItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitelReportItem
            // 
            this.lblTitelReportItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitelReportItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitelReportItem.Location = new System.Drawing.Point(0, 0);
            this.lblTitelReportItem.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitelReportItem.Name = "lblTitelReportItem";
            this.lblTitelReportItem.Size = new System.Drawing.Size(194, 37);
            this.lblTitelReportItem.TabIndex = 0;
            this.lblTitelReportItem.Text = "label1";
            this.lblTitelReportItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitelReportItem.Click += new System.EventHandler(this.UCReportItem_Click);
            // 
            // UCReportItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitelReportItem);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCReportItem";
            this.Size = new System.Drawing.Size(194, 37);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTitelReportItem;

    }
}

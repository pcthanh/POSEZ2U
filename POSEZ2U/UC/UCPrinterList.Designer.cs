namespace POSEZ2U.UC
{
    partial class UCPrinterList
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
            this.lblPrintList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrintList
            // 
            this.lblPrintList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrintList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintList.Location = new System.Drawing.Point(0, 0);
            this.lblPrintList.Name = "lblPrintList";
            this.lblPrintList.Size = new System.Drawing.Size(177, 37);
            this.lblPrintList.TabIndex = 0;
            this.lblPrintList.Text = "label1";
            this.lblPrintList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrintList.Click += new System.EventHandler(this.UCPrinterList_Click);
            // 
            // UCPrinterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrintList);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCPrinterList";
            this.Size = new System.Drawing.Size(177, 37);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblPrintList;
    }
}

namespace POSEZ2U.UC
{
    partial class UCPrintSetting
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
            this.lblPrintSetting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrintSetting
            // 
            this.lblPrintSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrintSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintSetting.Location = new System.Drawing.Point(0, 0);
            this.lblPrintSetting.Name = "lblPrintSetting";
            this.lblPrintSetting.Size = new System.Drawing.Size(177, 37);
            this.lblPrintSetting.TabIndex = 0;
            this.lblPrintSetting.Text = "Print Setting";
            this.lblPrintSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrintSetting.Click += new System.EventHandler(this.UCPrintSetting_Click);
            // 
            // UCPrintSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrintSetting);
            this.Name = "UCPrintSetting";
            this.Size = new System.Drawing.Size(177, 37);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrintSetting;
    }
}

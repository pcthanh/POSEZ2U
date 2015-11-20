namespace POSEZ2U.UC
{
    partial class UCProductSetting
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
            this.lblNameProductSetting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameProductSetting
            // 
            this.lblNameProductSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameProductSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProductSetting.Location = new System.Drawing.Point(0, 0);
            this.lblNameProductSetting.Name = "lblNameProductSetting";
            this.lblNameProductSetting.Size = new System.Drawing.Size(231, 47);
            this.lblNameProductSetting.TabIndex = 0;
            this.lblNameProductSetting.Text = "label1";
            this.lblNameProductSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameProductSetting.Click += new System.EventHandler(this.UCProductSetting_Click);
            // 
            // UCProductSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNameProductSetting);
            this.Name = "UCProductSetting";
            this.Size = new System.Drawing.Size(231, 47);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblNameProductSetting;
    }
}

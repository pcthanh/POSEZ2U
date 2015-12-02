namespace POSEZ2U.UC
{
    partial class UCUserSetting
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
            this.lblUserSetting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserSetting
            // 
            this.lblUserSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserSetting.Location = new System.Drawing.Point(0, 0);
            this.lblUserSetting.Name = "lblUserSetting";
            this.lblUserSetting.Size = new System.Drawing.Size(177, 37);
            this.lblUserSetting.TabIndex = 0;
            this.lblUserSetting.Text = "User List";
            this.lblUserSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserSetting.Click += new System.EventHandler(this.UCUserSetting_Click);
            // 
            // UCUserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUserSetting);
            this.Name = "UCUserSetting";
            this.Size = new System.Drawing.Size(177, 37);
           
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblUserSetting;
    }
}

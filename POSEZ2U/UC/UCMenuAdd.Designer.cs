namespace POSEZ2U.UC
{
    partial class UCMenuAdd
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
            this.lblGroupName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGroupName
            // 
            this.lblGroupName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupName.Location = new System.Drawing.Point(0, 0);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(228, 31);
            this.lblGroupName.TabIndex = 0;
            this.lblGroupName.Text = "label1";
            this.lblGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGroupName.Click += new System.EventHandler(this.UCMenuAdd_Click);
            // 
            // UCMenuAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGroupName);
            this.Name = "UCMenuAdd";
            this.Size = new System.Drawing.Size(228, 31);
            
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblGroupName;
    }
}

namespace POSEZ2U.UC
{
    partial class UCGroup
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
            this.lblNameGroup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameGroup
            // 
            this.lblNameGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameGroup.Location = new System.Drawing.Point(0, 0);
            this.lblNameGroup.Name = "lblNameGroup";
            this.lblNameGroup.Size = new System.Drawing.Size(107, 44);
            this.lblNameGroup.TabIndex = 0;
            this.lblNameGroup.Text = "Coffee";
            this.lblNameGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNameGroup.Click += new System.EventHandler(this.UCGroup_Click);
            // 
            // UCGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.lblNameGroup);
            this.Name = "UCGroup";
            this.Size = new System.Drawing.Size(107, 44);
            //base.Click += new System.EventHandler(this.UCGroup_Click);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblNameGroup;
    }
}

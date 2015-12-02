namespace POSEZ2U.UC
{
    partial class UCUserList
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
            this.lblUserList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserList
            // 
            this.lblUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserList.Location = new System.Drawing.Point(0, 0);
            this.lblUserList.Name = "lblUserList";
            this.lblUserList.Size = new System.Drawing.Size(177, 37);
            this.lblUserList.TabIndex = 0;
            this.lblUserList.Text = "Thien";
            this.lblUserList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserList.Click += new System.EventHandler(this.UCUserList_Click);
            // 
            // UCUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUserList);
            this.Name = "UCUserList";
            this.Size = new System.Drawing.Size(177, 37);
           
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblUserList;
    }
}

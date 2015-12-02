namespace POSEZ2U.UC
{
    partial class UCMenuList
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
            this.lblMenuListName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMenuListName
            // 
            this.lblMenuListName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMenuListName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuListName.Location = new System.Drawing.Point(0, 0);
            this.lblMenuListName.Name = "lblMenuListName";
            this.lblMenuListName.Size = new System.Drawing.Size(245, 37);
            this.lblMenuListName.TabIndex = 0;
            this.lblMenuListName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMenuListName.Click += new System.EventHandler(this.UCMenuList_Click);
            // 
            // UCMenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblMenuListName);
            this.Name = "UCMenuList";
            this.Size = new System.Drawing.Size(245, 37);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblMenuListName;
    }
}

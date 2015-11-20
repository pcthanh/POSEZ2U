namespace POSEZ2U.UC
{
    partial class UCGroupListItem
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
            this.lblGroupListItemName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGroupListItemName
            // 
            this.lblGroupListItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGroupListItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupListItemName.Location = new System.Drawing.Point(0, 0);
            this.lblGroupListItemName.Name = "lblGroupListItemName";
            this.lblGroupListItemName.Size = new System.Drawing.Size(262, 47);
            this.lblGroupListItemName.TabIndex = 0;
            this.lblGroupListItemName.Text = "label1";
            this.lblGroupListItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGroupListItemName.Click += new System.EventHandler(this.UCGroupListItem_Click);
            // 
            // UCGroupListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblGroupListItemName);
            this.Name = "UCGroupListItem";
            this.Size = new System.Drawing.Size(262, 47);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblGroupListItemName;
    }
}

namespace POSEZ2U.UC
{
    partial class UCItemOfCategoryPrint
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemName.Location = new System.Drawing.Point(0, 0);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(118, 40);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "label1";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblItemName.Click += new System.EventHandler(this.UCItemOfCategoryPrint_Click);
            // 
            // UCItemOfCategoryPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblItemName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UCItemOfCategoryPrint";
            this.Size = new System.Drawing.Size(118, 40);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblItemName;

    }
}

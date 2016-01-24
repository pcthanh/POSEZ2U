namespace POSEZ2U.UC
{
    partial class UCCategoryPrint
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
            this.lblNameCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameCategory
            // 
            this.lblNameCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCategory.Location = new System.Drawing.Point(0, 0);
            this.lblNameCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameCategory.Name = "lblNameCategory";
            this.lblNameCategory.Size = new System.Drawing.Size(149, 37);
            this.lblNameCategory.TabIndex = 0;
            this.lblNameCategory.Text = "label1";
            this.lblNameCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameCategory.Click += new System.EventHandler(this.UCCategoryPrint_Click);
            // 
            // UCCategoryPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNameCategory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCCategoryPrint";
            this.Size = new System.Drawing.Size(149, 37);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblNameCategory;

    }
}

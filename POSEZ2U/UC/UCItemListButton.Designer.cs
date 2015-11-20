namespace POSEZ2U.UC
{
    partial class UCItemListButton
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
            this.lblItemListButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblItemListButton
            // 
            this.lblItemListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblItemListButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemListButton.Location = new System.Drawing.Point(0, 0);
            this.lblItemListButton.Name = "lblItemListButton";
            this.lblItemListButton.Size = new System.Drawing.Size(107, 44);
            this.lblItemListButton.TabIndex = 0;
            this.lblItemListButton.Text = "label1";
            this.lblItemListButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblItemListButton.Click += new System.EventHandler(this.UCItemListButton_Click);
            // 
            // UCItemListButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblItemListButton);
            this.Name = "UCItemListButton";
            this.Size = new System.Drawing.Size(107, 44);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblItemListButton;
    }
}

namespace POSEZ2U.UC
{
    partial class UCModifierItem
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
            this.lblModifierItemName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblModifierItemName
            // 
            this.lblModifierItemName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModifierItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifierItemName.Location = new System.Drawing.Point(0, 0);
            this.lblModifierItemName.Name = "lblModifierItemName";
            this.lblModifierItemName.Size = new System.Drawing.Size(262, 47);
            this.lblModifierItemName.TabIndex = 0;
            this.lblModifierItemName.Text = "label1";
            this.lblModifierItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblModifierItemName.Click += new System.EventHandler(this.UCModifierItem_Click);
            // 
            // UCModifierItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblModifierItemName);
            this.Name = "UCModifierItem";
            this.Size = new System.Drawing.Size(262, 47);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblModifierItemName;
    }
}

namespace POSEZ2U.UC
{
    partial class UCModifierOfMenu
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
            this.lblModifierOfMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblModifierOfMenu
            // 
            this.lblModifierOfMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModifierOfMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifierOfMenu.ForeColor = System.Drawing.Color.White;
            this.lblModifierOfMenu.Location = new System.Drawing.Point(0, 0);
            this.lblModifierOfMenu.Name = "lblModifierOfMenu";
            this.lblModifierOfMenu.Size = new System.Drawing.Size(137, 68);
            this.lblModifierOfMenu.TabIndex = 0;
            this.lblModifierOfMenu.Text = "label1";
            this.lblModifierOfMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblModifierOfMenu.Click += new System.EventHandler(this.UCModifierOfMenu_Click);
            // 
            // UCModifierOfMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lblModifierOfMenu);
            this.Name = "UCModifierOfMenu";
            this.Size = new System.Drawing.Size(137, 68);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblModifierOfMenu;
    }
}

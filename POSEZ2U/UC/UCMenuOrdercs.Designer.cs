
﻿namespace POSEZ2U.UC
{
    partial class UCMenuOrdercs
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
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameGroup
            // 
            this.lblNameGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNameGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameGroup.ForeColor = System.Drawing.Color.White;
            this.lblNameGroup.Location = new System.Drawing.Point(0, 0);
            this.lblNameGroup.Name = "lblNameGroup";
            this.lblNameGroup.Size = new System.Drawing.Size(130, 32);
            this.lblNameGroup.TabIndex = 0;
            this.lblNameGroup.Text = "Com";
            this.lblNameGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameGroup.Click += new System.EventHandler(this.UCMenuOrdercs_Click);
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.White;
            this.lblCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblCount.Location = new System.Drawing.Point(88, 32);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(42, 40);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "11";
            this.lblCount.Click += new System.EventHandler(this.UCMenuOrdercs_Click);
            // 
            // UCMenuOrdercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblNameGroup);
            this.Name = "UCMenuOrdercs";
            this.Size = new System.Drawing.Size(130, 72);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblNameGroup;
        public System.Windows.Forms.Label lblCount;
    }
}

namespace POSEZ2U.UC
{
    partial class UCGroupMenuOrder
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
            this.lblGroupNameMenuOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGroupNameMenuOrder
            // 
            this.lblGroupNameMenuOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGroupNameMenuOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupNameMenuOrder.Location = new System.Drawing.Point(0, 0);
            this.lblGroupNameMenuOrder.Name = "lblGroupNameMenuOrder";
            this.lblGroupNameMenuOrder.Size = new System.Drawing.Size(137, 47);
            this.lblGroupNameMenuOrder.TabIndex = 0;
            this.lblGroupNameMenuOrder.Text = "label1";
            this.lblGroupNameMenuOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGroupNameMenuOrder.Click += new System.EventHandler(this.UCGroupMenuOrder_Click);
            // 
            // UCGroupMenuOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblGroupNameMenuOrder);
            this.Name = "UCGroupMenuOrder";
            this.Size = new System.Drawing.Size(137, 47);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblGroupNameMenuOrder;
    }
}

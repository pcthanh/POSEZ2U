namespace POSEZ2U.UC
{
    partial class UCAllPayMent
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
            this.lblStt = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMethodPayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStt
            // 
            this.lblStt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.lblStt.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStt.ForeColor = System.Drawing.Color.White;
            this.lblStt.Location = new System.Drawing.Point(0, 0);
            this.lblStt.Name = "lblStt";
            this.lblStt.Size = new System.Drawing.Size(57, 29);
            this.lblStt.TabIndex = 0;
            this.lblStt.Text = "#1";
            this.lblStt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRemove
            // 
            this.lblRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.Location = new System.Drawing.Point(290, 0);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(29, 28);
            this.lblRemove.TabIndex = 0;
            this.lblRemove.Text = "X";
            this.lblRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(186, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 28);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "$9.80";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMethodPayment
            // 
            this.lblMethodPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethodPayment.Location = new System.Drawing.Point(89, 0);
            this.lblMethodPayment.Name = "lblMethodPayment";
            this.lblMethodPayment.Size = new System.Drawing.Size(70, 28);
            this.lblMethodPayment.TabIndex = 0;
            this.lblMethodPayment.Text = "Cash";
            this.lblMethodPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCAllPayMent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMethodPayment);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lblStt);
            this.Name = "UCAllPayMent";
            this.Size = new System.Drawing.Size(314, 29);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblStt;
        public System.Windows.Forms.Label lblRemove;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblMethodPayment;
    }
}

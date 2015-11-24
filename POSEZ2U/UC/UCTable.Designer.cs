namespace POSEZ2U.UC
{
    partial class UCTable
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
            this.lbTableNo = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTableNo
            // 
            this.lbTableNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableNo.Location = new System.Drawing.Point(3, 0);
            this.lbTableNo.Name = "lbTableNo";
            this.lbTableNo.Size = new System.Drawing.Size(104, 23);
            this.lbTableNo.TabIndex = 0;
            this.lbTableNo.Text = "TableNo";
            this.lbTableNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTableNo.Click += new System.EventHandler(this.UCTable_Click);
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(0, 46);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(104, 29);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Time";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTime.Click += new System.EventHandler(this.UCTable_Click);
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotal.Location = new System.Drawing.Point(3, 89);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(104, 26);
            this.lbSubTotal.TabIndex = 0;
            this.lbSubTotal.Text = "SubTotal";
            this.lbSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSubTotal.Click += new System.EventHandler(this.UCTable_Click);
            // 
            // UCTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbSubTotal);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbTableNo);
            this.Name = "UCTable";
            this.Size = new System.Drawing.Size(105, 123);
            
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbTableNo;
        public System.Windows.Forms.Label lbTime;
        public System.Windows.Forms.Label lbSubTotal;
    }
}

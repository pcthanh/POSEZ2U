namespace POSEZ2U.UC
{
    partial class UCSeat
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
            this.lblSeat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSeat
            // 
            this.lblSeat.BackColor = System.Drawing.Color.Black;
            this.lblSeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat.ForeColor = System.Drawing.Color.White;
            this.lblSeat.Location = new System.Drawing.Point(0, 0);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(287, 37);
            this.lblSeat.TabIndex = 0;
            this.lblSeat.Text = "label1";
            this.lblSeat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSeat);
            this.Name = "UCSeat";
            this.Size = new System.Drawing.Size(287, 37);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblSeat;
    }
}

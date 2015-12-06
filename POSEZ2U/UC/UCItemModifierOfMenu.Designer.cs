namespace POSEZ2U
{
    partial class UCItemModifierOfMenu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNameItenModifierMenu = new System.Windows.Forms.Label();
            this.lblQtyItenModifierMenu = new System.Windows.Forms.Label();
            this.lblPriceItenModifierMenu = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblNameItenModifierMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQtyItenModifierMenu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPriceItenModifierMenu, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(220, 29);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNameItenModifierMenu
            // 
            this.lblNameItenModifierMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameItenModifierMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameItenModifierMenu.Location = new System.Drawing.Point(3, 0);
            this.lblNameItenModifierMenu.Name = "lblNameItenModifierMenu";
            this.lblNameItenModifierMenu.Size = new System.Drawing.Size(104, 29);
            this.lblNameItenModifierMenu.TabIndex = 0;
            this.lblNameItenModifierMenu.Text = "label1";
            this.lblNameItenModifierMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameItenModifierMenu.Click += new System.EventHandler(this.UCItemModifierOfMenu_Click);
            // 
            // lblQtyItenModifierMenu
            // 
            this.lblQtyItenModifierMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtyItenModifierMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyItenModifierMenu.Location = new System.Drawing.Point(113, 0);
            this.lblQtyItenModifierMenu.Name = "lblQtyItenModifierMenu";
            this.lblQtyItenModifierMenu.Size = new System.Drawing.Size(49, 29);
            this.lblQtyItenModifierMenu.TabIndex = 0;
            this.lblQtyItenModifierMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQtyItenModifierMenu.Click += new System.EventHandler(this.UCItemModifierOfMenu_Click);
            // 
            // lblPriceItenModifierMenu
            // 
            this.lblPriceItenModifierMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPriceItenModifierMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceItenModifierMenu.Location = new System.Drawing.Point(168, 0);
            this.lblPriceItenModifierMenu.Name = "lblPriceItenModifierMenu";
            this.lblPriceItenModifierMenu.Size = new System.Drawing.Size(49, 29);
            this.lblPriceItenModifierMenu.TabIndex = 0;
            this.lblPriceItenModifierMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPriceItenModifierMenu.Click += new System.EventHandler(this.UCItemModifierOfMenu_Click);
            // 
            // UCItemModifierOfMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.Name = "UCItemModifierOfMenu";
            this.Size = new System.Drawing.Size(220, 29);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lblNameItenModifierMenu;
        public System.Windows.Forms.Label lblQtyItenModifierMenu;
        public System.Windows.Forms.Label lblPriceItenModifierMenu;
    }
}

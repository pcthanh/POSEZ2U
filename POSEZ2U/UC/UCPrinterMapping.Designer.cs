namespace POSEZ2U.UC
{
    partial class UCPrinterMapping
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
            this.cbGroupItem = new System.Windows.Forms.ComboBox();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.cbPrinter = new System.Windows.Forms.ComboBox();
            this.cbTemplate = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.cbGroupItem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbItem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbPrinter, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbTemplate, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(516, 38);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cbGroupItem
            // 
            this.cbGroupItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbGroupItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGroupItem.FormattingEnabled = true;
            this.cbGroupItem.Location = new System.Drawing.Point(0, 0);
            this.cbGroupItem.Margin = new System.Windows.Forms.Padding(0);
            this.cbGroupItem.Name = "cbGroupItem";
            this.cbGroupItem.Size = new System.Drawing.Size(129, 37);
            this.cbGroupItem.TabIndex = 0;
            this.cbGroupItem.SelectedIndexChanged += new System.EventHandler(this.cbGroupItem_SelectedIndexChanged);
            // 
            // cbItem
            // 
            this.cbItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(129, 0);
            this.cbItem.Margin = new System.Windows.Forms.Padding(0);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(129, 37);
            this.cbItem.TabIndex = 0;
            // 
            // cbPrinter
            // 
            this.cbPrinter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrinter.FormattingEnabled = true;
            this.cbPrinter.Location = new System.Drawing.Point(258, 0);
            this.cbPrinter.Margin = new System.Windows.Forms.Padding(0);
            this.cbPrinter.Name = "cbPrinter";
            this.cbPrinter.Size = new System.Drawing.Size(129, 37);
            this.cbPrinter.TabIndex = 0;
            // 
            // cbTemplate
            // 
            this.cbTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTemplate.FormattingEnabled = true;
            this.cbTemplate.Location = new System.Drawing.Point(387, 0);
            this.cbTemplate.Margin = new System.Windows.Forms.Padding(0);
            this.cbTemplate.Name = "cbTemplate";
            this.cbTemplate.Size = new System.Drawing.Size(129, 37);
            this.cbTemplate.TabIndex = 0;
            // 
            // UCPrinterMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCPrinterMapping";
            this.Size = new System.Drawing.Size(516, 38);
            this.Load += new System.EventHandler(this.UCPrinterMapping_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ComboBox cbGroupItem;
        public System.Windows.Forms.ComboBox cbItem;
        public System.Windows.Forms.ComboBox cbPrinter;
        public System.Windows.Forms.ComboBox cbTemplate;
    }
}

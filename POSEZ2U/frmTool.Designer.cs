namespace POSEZ2U
{
    partial class frmTool
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnJoinTable = new System.Windows.Forms.Button();
            this.btnTranferTable = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnJoinTable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTranferTable, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(185, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnJoinTable
            // 
            this.btnJoinTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJoinTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnJoinTable.FlatAppearance.BorderSize = 0;
            this.btnJoinTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinTable.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnJoinTable.Location = new System.Drawing.Point(3, 3);
            this.btnJoinTable.Name = "btnJoinTable";
            this.btnJoinTable.Size = new System.Drawing.Size(86, 51);
            this.btnJoinTable.TabIndex = 0;
            this.btnJoinTable.Text = "JOIN TABLE";
            this.btnJoinTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJoinTable.UseVisualStyleBackColor = true;
            this.btnJoinTable.Click += new System.EventHandler(this.btnJoinTable_Click);
            // 
            // btnTranferTable
            // 
            this.btnTranferTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTranferTable.FlatAppearance.BorderSize = 0;
            this.btnTranferTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranferTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranferTable.Location = new System.Drawing.Point(95, 3);
            this.btnTranferTable.Name = "btnTranferTable";
            this.btnTranferTable.Size = new System.Drawing.Size(87, 51);
            this.btnTranferTable.TabIndex = 0;
            this.btnTranferTable.Text = "TRANSFER";
            this.btnTranferTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTranferTable.UseVisualStyleBackColor = true;
            this.btnTranferTable.Click += new System.EventHandler(this.btnTranferTable_Click);
            // 
            // frmTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(185, 57);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnJoinTable;
        private System.Windows.Forms.Button btnTranferTable;
    }
}
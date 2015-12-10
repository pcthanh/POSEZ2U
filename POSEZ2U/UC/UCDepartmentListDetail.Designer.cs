namespace POSEZ2U.UC
{
    partial class UCDepartmentListDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTilte = new System.Windows.Forms.Label();
            this.lbRoleName = new System.Windows.Forms.Label();
            this.txtRoleName = new POSEZ2U.UC.UCTextBoxKeyBoard();
            this.lbPermisstion = new System.Windows.Forms.Label();
            this.flpPermission = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(466, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 42);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 42);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flpPermission, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbPermisstion, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbTilte, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbRoleName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRoleName, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.6109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.6109F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.61333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.60828F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.55658F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 310);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbTilte
            // 
            this.lbTilte.AutoSize = true;
            this.lbTilte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lbTilte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTilte.ForeColor = System.Drawing.Color.White;
            this.lbTilte.Location = new System.Drawing.Point(3, 0);
            this.lbTilte.Name = "lbTilte";
            this.lbTilte.Size = new System.Drawing.Size(547, 39);
            this.lbTilte.TabIndex = 0;
            this.lbTilte.Text = "Add Role";
            this.lbTilte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRoleName
            // 
            this.lbRoleName.AutoSize = true;
            this.lbRoleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRoleName.Location = new System.Drawing.Point(3, 39);
            this.lbRoleName.Name = "lbRoleName";
            this.lbRoleName.Size = new System.Drawing.Size(547, 39);
            this.lbRoleName.TabIndex = 2;
            this.lbRoleName.Text = "Role Name";
            this.lbRoleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRoleName
            // 
            this.txtRoleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtRoleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRoleName.Location = new System.Drawing.Point(3, 81);
            this.txtRoleName.Multiline = true;
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(547, 33);
            this.txtRoleName.TabIndex = 3;
            // 
            // lbPermisstion
            // 
            this.lbPermisstion.AutoSize = true;
            this.lbPermisstion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPermisstion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPermisstion.Location = new System.Drawing.Point(3, 117);
            this.lbPermisstion.Name = "lbPermisstion";
            this.lbPermisstion.Size = new System.Drawing.Size(547, 39);
            this.lbPermisstion.TabIndex = 9;
            this.lbPermisstion.Text = "Permission";
            this.lbPermisstion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpPermission
            // 
            this.flpPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPermission.Location = new System.Drawing.Point(3, 159);
            this.flpPermission.Name = "flpPermission";
            this.flpPermission.Size = new System.Drawing.Size(547, 148);
            this.flpPermission.TabIndex = 10;
            // 
            // UCDepartmentListDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "UCDepartmentListDetail";
            this.Size = new System.Drawing.Size(553, 513);
            this.Load += new System.EventHandler(this.UCDepartmentListDetail_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label lbTilte;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnSave;
        public UCTextBoxKeyBoard txtRoleName;
        public System.Windows.Forms.Label lbRoleName;
        private System.Windows.Forms.Label lbPermisstion;
        private System.Windows.Forms.FlowLayoutPanel flpPermission;
    }
}

namespace POSEZ2U
 {
     partial class frmSettingAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettingAll));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.ucFloorPlan1 = new POSEZ2U.UC.UCFloorPlan();
            this.ucInventory1 = new POSEZ2U.UC.UCInventory();
            this.ucAccount = new POSEZ2U.UC.UCAccount();
            this.ucStore1 = new POSEZ2U.UC.UCStore();
            this.ucDatabase = new POSEZ2U.UC.UCDatabase();
            this.uCbtnPrinter = new POSEZ2U.UC.UCbtnPrinter();
            this.ucUser = new POSEZ2U.UC.UCUser();
            this.ucProduct = new POSEZ2U.UC.UCProduct();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 10);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 428);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 63);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.23529F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.76471F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblNameUser, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(562, 10);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(170, 43);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.ForeColor = System.Drawing.Color.Blue;
            this.lblNameUser.Location = new System.Drawing.Point(50, 0);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(117, 43);
            this.lblNameUser.TabIndex = 1;
            this.lblNameUser.Text = "LOC";
            this.lblNameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(10, 10);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 43);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Back to Main Menu";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(732, 10);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 43);
            this.panel10.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(10, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(732, 10);
            this.panel9.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(10, 53);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(732, 10);
            this.panel8.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 63);
            this.panel7.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 418);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(732, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 418);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(722, 418);
            this.panel5.TabIndex = 6;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ucFloorPlan1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ucInventory1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ucAccount, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(210, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(207, 418);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(200, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 418);
            this.panel6.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ucStore1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ucDatabase, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.uCbtnPrinter, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ucUser, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucProduct, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 418);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 37);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // ucFloorPlan1
            // 
            this.ucFloorPlan1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ucFloorPlan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFloorPlan1.Location = new System.Drawing.Point(0, 0);
            this.ucFloorPlan1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.ucFloorPlan1.Name = "ucFloorPlan1";
            this.ucFloorPlan1.Size = new System.Drawing.Size(207, 82);
            this.ucFloorPlan1.TabIndex = 3;
            // 
            // ucInventory1
            // 
            this.ucInventory1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ucInventory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInventory1.Location = new System.Drawing.Point(0, 83);
            this.ucInventory1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ucInventory1.Name = "ucInventory1";
            this.ucInventory1.Size = new System.Drawing.Size(207, 80);
            this.ucInventory1.TabIndex = 4;
            // 
            // ucAccount
            // 
            this.ucAccount.BackColor = System.Drawing.Color.White;
            this.ucAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAccount.Location = new System.Drawing.Point(0, 166);
            this.ucAccount.Margin = new System.Windows.Forms.Padding(0);
            this.ucAccount.Name = "ucAccount";
            this.ucAccount.Size = new System.Drawing.Size(207, 83);
            this.ucAccount.TabIndex = 5;
            this.ucAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // ucStore1
            // 
            this.ucStore1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ucStore1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStore1.Location = new System.Drawing.Point(0, 249);
            this.ucStore1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ucStore1.Name = "ucStore1";
            this.ucStore1.Size = new System.Drawing.Size(200, 80);
            this.ucStore1.TabIndex = 6;
            // 
            // ucDatabase
            // 
            this.ucDatabase.BackColor = System.Drawing.Color.White;
            this.ucDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDatabase.Location = new System.Drawing.Point(0, 332);
            this.ucDatabase.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ucDatabase.Name = "ucDatabase";
            this.ucDatabase.Size = new System.Drawing.Size(200, 83);
            this.ucDatabase.TabIndex = 6;
            this.ucDatabase.Load += new System.EventHandler(this.ucDatabase_Load);
            this.ucDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // uCbtnPrinter
            // 
            this.uCbtnPrinter.BackColor = System.Drawing.Color.White;
            this.uCbtnPrinter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uCbtnPrinter.Location = new System.Drawing.Point(0, 166);
            this.uCbtnPrinter.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.uCbtnPrinter.Name = "uCbtnPrinter";
            this.uCbtnPrinter.Size = new System.Drawing.Size(200, 80);
            this.uCbtnPrinter.TabIndex = 6;
            this.uCbtnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
            // 
            // ucUser
            // 
            this.ucUser.BackColor = System.Drawing.Color.White;
            this.ucUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUser.Location = new System.Drawing.Point(0, 83);
            this.ucUser.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ucUser.Name = "ucUser";
            this.ucUser.Size = new System.Drawing.Size(200, 80);
            this.ucUser.TabIndex = 6;
            this.ucUser.Click += new System.EventHandler(this.btnUserSetting_Click);
            // 
            // ucProduct
            // 
            this.ucProduct.BackColor = System.Drawing.Color.White;
            this.ucProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProduct.Location = new System.Drawing.Point(0, 0);
            this.ucProduct.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ucProduct.Name = "ucProduct";
            this.ucProduct.Size = new System.Drawing.Size(200, 80);
            this.ucProduct.TabIndex = 6;
            this.ucProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // frmSettingAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(742, 491);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettingAll";
            this.ShowInTaskbar = false;
            this.Text = "frmSettingAll";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSettingAll_Load);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

         }

         #endregion

         private UC.UCInfoTop ucInfoTop1;
         private System.Windows.Forms.Panel panel1;
         private System.Windows.Forms.Panel panel2;
         private System.Windows.Forms.Panel panel3;
         private System.Windows.Forms.Panel panel4;
         private System.Windows.Forms.Panel panel5;
         private System.Windows.Forms.Button btnLogOut;
         private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
         private System.Windows.Forms.PictureBox pictureBox6;
         public System.Windows.Forms.Label lblNameUser;
         private System.Windows.Forms.Panel panel9;
         private System.Windows.Forms.Panel panel8;
         private System.Windows.Forms.Panel panel7;
         private System.Windows.Forms.Panel panel10;
         private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
         private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
         private System.Windows.Forms.Panel panel6;
         private UC.UCProduct ucProduct;
         private UC.UCUser ucUser;
         private UC.UCbtnPrinter uCbtnPrinter;
         private UC.UCDatabase ucDatabase;
         private UC.UCStore ucStore1;
         private UC.UCFloorPlan ucFloorPlan1;
         private UC.UCInventory ucInventory1;
         private UC.UCAccount ucAccount;
     }
 }
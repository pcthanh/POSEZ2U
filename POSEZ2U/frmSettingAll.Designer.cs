﻿namespace POSEZ2U
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnUserSetting = new System.Windows.Forms.Button();
            this.btnPrinter = new System.Windows.Forms.Button();
            this.ucInfoTop1 = new POSEZ2U.UC.UCInfoTop();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 10);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 48);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 392);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(732, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 392);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 51);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(722, 392);
            this.panel5.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnProduct, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUserSetting, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPrinter, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 198);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnProduct
            // 
            this.btnProduct.BackgroundImage = global::POSEZ2U.Properties.Resources.u1294;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduct.Location = new System.Drawing.Point(3, 3);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(173, 93);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "PRODUCT";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnUserSetting
            // 
            this.btnUserSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserSetting.FlatAppearance.BorderSize = 0;
            this.btnUserSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSetting.Location = new System.Drawing.Point(3, 102);
            this.btnUserSetting.Name = "btnUserSetting";
            this.btnUserSetting.Size = new System.Drawing.Size(173, 93);
            this.btnUserSetting.TabIndex = 1;
            this.btnUserSetting.Text = "UserSetting";
            this.btnUserSetting.UseVisualStyleBackColor = true;
            this.btnUserSetting.Click += new System.EventHandler(this.btnUserSetting_Click);
            // 
            // btnPrinter
            // 
            this.btnPrinter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrinter.FlatAppearance.BorderSize = 0;
            this.btnPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinter.Location = new System.Drawing.Point(182, 3);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(174, 93);
            this.btnPrinter.TabIndex = 2;
            this.btnPrinter.Text = "Printer Setting";
            this.btnPrinter.UseVisualStyleBackColor = true;
            this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
            // 
            // ucInfoTop1
            // 
            this.ucInfoTop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucInfoTop1.Location = new System.Drawing.Point(0, 0);
            this.ucInfoTop1.Name = "ucInfoTop1";
            this.ucInfoTop1.Size = new System.Drawing.Size(742, 41);
            this.ucInfoTop1.TabIndex = 0;
            // 
            // frmSettingAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(742, 491);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucInfoTop1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettingAll";
            this.Text = "frmSettingAll";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

         }

         #endregion

         private UC.UCInfoTop ucInfoTop1;
         private System.Windows.Forms.Panel panel1;
         private System.Windows.Forms.Panel panel2;
         private System.Windows.Forms.Panel panel3;
         private System.Windows.Forms.Panel panel4;
         private System.Windows.Forms.Panel panel5;
         private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
         private System.Windows.Forms.Button btnProduct;
         private System.Windows.Forms.Button btnUserSetting;
         private System.Windows.Forms.Button btnPrinter;
     }
 }
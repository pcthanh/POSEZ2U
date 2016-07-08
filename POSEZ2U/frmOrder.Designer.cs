
﻿namespace POSEZ2U
{
    partial class frmOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flpGroupMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.flpOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucOpenTill1 = new POSEZ2U.UC.UCOpenTill();
            this.ucPreOrder = new POSEZ2U.UC.UCPreOrder();
            this.ucCancelOrder = new POSEZ2U.UC.UCCancelOrder();
            this.ucPePrint = new POSEZ2U.UC.UCPePrint();
            this.ucVoidAll = new POSEZ2U.UC.UCVoidAll();
            this.ucVoidItem = new POSEZ2U.UC.UCVoidItem();
            this.ucSendOrder = new POSEZ2U.UC.UCSendOrder();
            this.btnJoinTable = new System.Windows.Forms.Button();
            this.btnTransferTable = new System.Windows.Forms.Button();
            this.ucOpenItem = new POSEZ2U.UC.UCOpenItem();
            this.ucPrintBill = new POSEZ2U.UC.UCPrintBill();
            this.ucNote = new POSEZ2U.UC.UCNote();
            this.ucBtnPayment = new POSEZ2U.UC.UCBtnPayment();
            this.ucRice = new POSEZ2U.UC.UCRice();
            this.ucRefund = new POSEZ2U.UC.UCRefund();
            this.ucAddseat = new POSEZ2U.UC.UCAddseat();
            this.panel8 = new System.Windows.Forms.Panel();
            this.ucKeyPadOrder1 = new POSEZ2U.UC.UCKeyPadOrder();
            this.panel11 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.timeChangeColor = new System.Windows.Forms.Timer(this.components);
            this.ucInfoTop1 = new POSEZ2U.UC.UCInfoTop();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 10);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 429);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLogOut);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 481);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 47);
            this.panel3.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(10, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(148, 40);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Back to FloorPlan";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(944, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 429);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.flpGroupMenu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(629, 48);
            this.panel5.TabIndex = 5;
            // 
            // flpGroupMenu
            // 
            this.flpGroupMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGroupMenu.Location = new System.Drawing.Point(0, 0);
            this.flpGroupMenu.Name = "flpGroupMenu";
            this.flpGroupMenu.Size = new System.Drawing.Size(629, 48);
            this.flpGroupMenu.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel13);
            this.panel6.Controls.Add(this.panel12);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(649, 52);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(295, 429);
            this.panel6.TabIndex = 6;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.flpOrder);
            this.panel13.Controls.Add(this.panel16);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 100);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(295, 329);
            this.panel13.TabIndex = 1;
            // 
            // flpOrder
            // 
            this.flpOrder.AutoScroll = true;
            this.flpOrder.AutoSize = true;
            this.flpOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOrder.Location = new System.Drawing.Point(0, 0);
            this.flpOrder.Name = "flpOrder";
            this.flpOrder.Size = new System.Drawing.Size(295, 288);
            this.flpOrder.TabIndex = 0;
            this.flpOrder.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flpOrder_Scroll);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel16.Controls.Add(this.lblSubtotal);
            this.panel16.Controls.Add(this.label1);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(0, 288);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(295, 41);
            this.panel16.TabIndex = 1;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblSubtotal.Location = new System.Drawing.Point(139, 7);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(153, 28);
            this.lblSubtotal.TabIndex = 1;
            this.lblSubtotal.Text = "label2";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUBTOTAL";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.tableLayoutPanel2);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(295, 100);
            this.panel12.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.94915F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.05085F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCustomerName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblStatus, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblTable, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblSeat, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(295, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(111, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(181, 25);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Status";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(111, 25);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(181, 25);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Table";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTable
            // 
            this.lblTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(111, 50);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(181, 25);
            this.lblTable.TabIndex = 0;
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "No # Seat";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSeat
            // 
            this.lblSeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat.Location = new System.Drawing.Point(111, 75);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(181, 25);
            this.lblSeat.TabIndex = 0;
            this.lblSeat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(639, 52);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 429);
            this.panel7.TabIndex = 7;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel9);
            this.panel10.Controls.Add(this.panel8);
            this.panel10.Controls.Add(this.ucKeyPadOrder1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(10, 288);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(629, 193);
            this.panel10.TabIndex = 10;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tableLayoutPanel1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(448, 193);
            this.panel9.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.41072F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.ucOpenTill1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucPreOrder, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ucCancelOrder, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ucPePrint, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ucVoidAll, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucVoidItem, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucSendOrder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnJoinTable, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnTransferTable, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucOpenItem, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucPrintBill, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucNote, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.ucBtnPayment, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.ucRice, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucRefund, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucAddseat, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 193);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ucOpenTill1
            // 
            this.ucOpenTill1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(145)))), ((int)(((byte)(116)))));
            this.ucOpenTill1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOpenTill1.Location = new System.Drawing.Point(296, 64);
            this.ucOpenTill1.Margin = new System.Windows.Forms.Padding(0);
            this.ucOpenTill1.Name = "ucOpenTill1";
            this.ucOpenTill1.Size = new System.Drawing.Size(74, 64);
            this.ucOpenTill1.TabIndex = 3;
            this.ucOpenTill1.Click += new System.EventHandler(this.ucOpenTill1_Click);
            // 
            // ucPreOrder
            // 
            this.ucPreOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(85)))), ((int)(((byte)(204)))));
            this.ucPreOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPreOrder.Location = new System.Drawing.Point(152, 128);
            this.ucPreOrder.Margin = new System.Windows.Forms.Padding(0);
            this.ucPreOrder.Name = "ucPreOrder";
            this.ucPreOrder.Size = new System.Drawing.Size(70, 65);
            this.ucPreOrder.TabIndex = 6;
            this.ucPreOrder.Click += new System.EventHandler(this.btnPrevOrder_Click);
            // 
            // ucCancelOrder
            // 
            this.ucCancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(33)))), ((int)(((byte)(0)))));
            this.ucCancelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCancelOrder.Location = new System.Drawing.Point(74, 128);
            this.ucCancelOrder.Margin = new System.Windows.Forms.Padding(0);
            this.ucCancelOrder.Name = "ucCancelOrder";
            this.ucCancelOrder.Size = new System.Drawing.Size(78, 65);
            this.ucCancelOrder.TabIndex = 5;
            this.ucCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // ucPePrint
            // 
            this.ucPePrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.ucPePrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPePrint.Location = new System.Drawing.Point(0, 128);
            this.ucPePrint.Margin = new System.Windows.Forms.Padding(0);
            this.ucPePrint.Name = "ucPePrint";
            this.ucPePrint.Size = new System.Drawing.Size(74, 65);
            this.ucPePrint.TabIndex = 2;
            this.ucPePrint.Click += new System.EventHandler(this.btnReprint_Click);
            // 
            // ucVoidAll
            // 
            this.ucVoidAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucVoidAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucVoidAll.Location = new System.Drawing.Point(152, 64);
            this.ucVoidAll.Margin = new System.Windows.Forms.Padding(0);
            this.ucVoidAll.Name = "ucVoidAll";
            this.ucVoidAll.Size = new System.Drawing.Size(70, 64);
            this.ucVoidAll.TabIndex = 2;
            this.ucVoidAll.Load += new System.EventHandler(this.ucVoidAll_Load);
            this.ucVoidAll.Click += new System.EventHandler(this.btnVoidAll_Click);
            // 
            // ucVoidItem
            // 
            this.ucVoidItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucVoidItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucVoidItem.Location = new System.Drawing.Point(74, 64);
            this.ucVoidItem.Margin = new System.Windows.Forms.Padding(0);
            this.ucVoidItem.Name = "ucVoidItem";
            this.ucVoidItem.Size = new System.Drawing.Size(78, 64);
            this.ucVoidItem.TabIndex = 2;
            this.ucVoidItem.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // ucSendOrder
            // 
            this.ucSendOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.ucSendOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSendOrder.Location = new System.Drawing.Point(0, 0);
            this.ucSendOrder.Margin = new System.Windows.Forms.Padding(0);
            this.ucSendOrder.Name = "ucSendOrder";
            this.tableLayoutPanel1.SetRowSpan(this.ucSendOrder, 2);
            this.ucSendOrder.Size = new System.Drawing.Size(74, 128);
            this.ucSendOrder.TabIndex = 1;
            this.ucSendOrder.Load += new System.EventHandler(this.ucSendOrder_Load);
            this.ucSendOrder.Click += new System.EventHandler(this.btnSendOrder_Click);
            // 
            // btnJoinTable
            // 
            this.btnJoinTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btnJoinTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnJoinTable.FlatAppearance.BorderSize = 0;
            this.btnJoinTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinTable.Location = new System.Drawing.Point(74, 0);
            this.btnJoinTable.Margin = new System.Windows.Forms.Padding(0);
            this.btnJoinTable.Name = "btnJoinTable";
            this.btnJoinTable.Size = new System.Drawing.Size(78, 64);
            this.btnJoinTable.TabIndex = 1;
            this.btnJoinTable.Text = "Join Table";
            this.btnJoinTable.UseVisualStyleBackColor = false;
            this.btnJoinTable.Visible = false;
            // 
            // btnTransferTable
            // 
            this.btnTransferTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btnTransferTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTransferTable.FlatAppearance.BorderSize = 0;
            this.btnTransferTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferTable.Location = new System.Drawing.Point(152, 0);
            this.btnTransferTable.Margin = new System.Windows.Forms.Padding(0);
            this.btnTransferTable.Name = "btnTransferTable";
            this.btnTransferTable.Size = new System.Drawing.Size(70, 64);
            this.btnTransferTable.TabIndex = 1;
            this.btnTransferTable.Text = "Transfer Table";
            this.btnTransferTable.UseVisualStyleBackColor = false;
            this.btnTransferTable.Visible = false;
            // 
            // ucOpenItem
            // 
            this.ucOpenItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ucOpenItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOpenItem.Location = new System.Drawing.Point(222, 64);
            this.ucOpenItem.Margin = new System.Windows.Forms.Padding(0);
            this.ucOpenItem.Name = "ucOpenItem";
            this.ucOpenItem.Size = new System.Drawing.Size(74, 64);
            this.ucOpenItem.TabIndex = 6;
            this.ucOpenItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // ucPrintBill
            // 
            this.ucPrintBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ucPrintBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPrintBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPrintBill.Location = new System.Drawing.Point(370, 64);
            this.ucPrintBill.Margin = new System.Windows.Forms.Padding(0);
            this.ucPrintBill.Name = "ucPrintBill";
            this.ucPrintBill.Size = new System.Drawing.Size(78, 64);
            this.ucPrintBill.TabIndex = 7;
            this.ucPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // ucNote
            // 
            this.ucNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.ucNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNote.Location = new System.Drawing.Point(222, 128);
            this.ucNote.Margin = new System.Windows.Forms.Padding(0);
            this.ucNote.Name = "ucNote";
            this.ucNote.Size = new System.Drawing.Size(74, 65);
            this.ucNote.TabIndex = 8;
            this.ucNote.Load += new System.EventHandler(this.ucNote_Load);
            this.ucNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // ucBtnPayment
            // 
            this.ucBtnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.SetColumnSpan(this.ucBtnPayment, 2);
            this.ucBtnPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBtnPayment.Location = new System.Drawing.Point(296, 128);
            this.ucBtnPayment.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnPayment.Name = "ucBtnPayment";
            this.ucBtnPayment.Size = new System.Drawing.Size(152, 65);
            this.ucBtnPayment.TabIndex = 9;
            this.ucBtnPayment.Load += new System.EventHandler(this.ucBtnPayment_Load);
            this.ucBtnPayment.Click += new System.EventHandler(this.btnPayMent_Click);
            // 
            // ucRice
            // 
            this.ucRice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.ucRice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRice.Location = new System.Drawing.Point(370, 0);
            this.ucRice.Margin = new System.Windows.Forms.Padding(0);
            this.ucRice.Name = "ucRice";
            this.ucRice.Size = new System.Drawing.Size(78, 64);
            this.ucRice.TabIndex = 10;
            this.ucRice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // ucRefund
            // 
            this.ucRefund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(28)))));
            this.ucRefund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRefund.Location = new System.Drawing.Point(296, 0);
            this.ucRefund.Margin = new System.Windows.Forms.Padding(0);
            this.ucRefund.Name = "ucRefund";
            this.ucRefund.Size = new System.Drawing.Size(74, 64);
            this.ucRefund.TabIndex = 11;
            // 
            // ucAddseat
            // 
            this.ucAddseat.BackColor = System.Drawing.Color.Black;
            this.ucAddseat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddseat.Location = new System.Drawing.Point(222, 0);
            this.ucAddseat.Margin = new System.Windows.Forms.Padding(0);
            this.ucAddseat.Name = "ucAddseat";
            this.ucAddseat.Size = new System.Drawing.Size(74, 64);
            this.ucAddseat.TabIndex = 12;
            this.ucAddseat.Load += new System.EventHandler(this.ucAddseat_Load);
            this.ucAddseat.Click += new System.EventHandler(this.btnAddSeat_Click);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(448, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 193);
            this.panel8.TabIndex = 0;
            // 
            // ucKeyPadOrder1
            // 
            this.ucKeyPadOrder1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucKeyPadOrder1.Location = new System.Drawing.Point(458, 0);
            this.ucKeyPadOrder1.Name = "ucKeyPadOrder1";
            this.ucKeyPadOrder1.Size = new System.Drawing.Size(171, 193);
            this.ucKeyPadOrder1.TabIndex = 0;
            this.ucKeyPadOrder1.txtResult = null;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(214)))), ((int)(((byte)(216)))));
            this.panel11.Controls.Add(this.flowLayoutPanel1);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(10, 100);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(629, 188);
            this.panel11.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(629, 168);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(629, 10);
            this.panel15.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 178);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(629, 10);
            this.panel14.TabIndex = 0;
            // 
            // timeChangeColor
            // 
            this.timeChangeColor.Interval = 200;
            this.timeChangeColor.Tick += new System.EventHandler(this.timeChangeColor_Tick);
            // 
            // ucInfoTop1
            // 
            this.ucInfoTop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucInfoTop1.Location = new System.Drawing.Point(0, 0);
            this.ucInfoTop1.Name = "ucInfoTop1";
            this.ucInfoTop1.Size = new System.Drawing.Size(954, 42);
            this.ucInfoTop1.TabIndex = 0;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(214)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(954, 528);
            this.ControlBox = false;
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucInfoTop1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrder";
            this.ShowInTaskbar = false;
            this.Text = "frmOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UC.UCInfoTop ucInfoTop1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private UC.UCKeyPadOrder ucKeyPadOrder1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnJoinTable;
        private System.Windows.Forms.Button btnTransferTable;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpGroupMenu;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.FlowLayoutPanel flpOrder;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Timer timeChangeColor;
        private UC.UCSendOrder ucSendOrder;
        private UC.UCVoidItem ucVoidItem;
        private UC.UCVoidAll ucVoidAll;
        private UC.UCOpenItem ucOpenItem;
        private UC.UCOpenTill ucOpenTill1;
        private UC.UCPrintBill ucPrintBill;
        private UC.UCPePrint ucPePrint;
        private UC.UCCancelOrder ucCancelOrder;
        private UC.UCPreOrder ucPreOrder;
        private UC.UCNote ucNote;
        private UC.UCBtnPayment ucBtnPayment;
        private UC.UCRice ucRice;
        private UC.UCRefund ucRefund;
        private UC.UCAddseat ucAddseat;
    }
}
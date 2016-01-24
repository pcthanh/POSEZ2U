﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelPOS.ModelEntity;
using ServicePOS.Model;
using ServicePOS;

namespace POSEZ2U
{
    public partial class frmAddPrinter : Form
    {
        public frmAddPrinter()
        {
            InitializeComponent();
        }
        private IPrinterSettingServer _printService;
        private IPrinterSettingServer PrintService
        {
            get { return _printService ?? (_printService = new PrinterSettingServer()); }
            set { _printService = value; }
        }
        private void frmAddPrinter_Load(object sender, EventArgs e)
        {
            LoadPrinterMachine();
        }
        private void LoadPrinterMachine()
        {
            foreach (string s in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cbPrinter.Items.Add(s);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PrinterModel item = new PrinterModel();
            item.PrinterName = cbPrinter.SelectedItem.ToString();
            item.PrintName = txtPrintName.Text;
            item.Header = txtHeader.Text;
            item.PrinterType = cbPrintType.SelectedIndex;
            int result= PrintService.InsertPrinter(item);
            if (result == 1)
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
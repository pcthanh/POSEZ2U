using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSEZ2U.Class;
using ServicePOS;

namespace POSEZ2U.UC
{
    public partial class UCPrinterJobDetail : UserControl
    {
        public UCPrinterJobDetail()
        {
            InitializeComponent();
        }


        private IPrinterService _printerService;
        private IPrinterService PrinterService
        {
            get { return _printerService ?? (_printerService = new PrinterService()); }
            set { _printerService = value; }
        }

        public void LoadPriterMappByPrinteJobID(int PrinteJobID)
        {
            flpPriterMap.Controls.Clear();
            var data = PrinterService.GetPrintJobDetailList(PrinteJobID).ToList();
            foreach (var item in data)
            {

                UCPrinterMapping map = new UCPrinterMapping();
                map.Width = flpPriterMap.Width - 5;
                flpPriterMap.Controls.Add(map);

                map.Tag = item;

                foreach (KeyValueModel category in map.cbGroupItem.Items)
                {
                    if (category.Key == item.CategoryID)
                    {
                        map.cbGroupItem.Text = category.Value;
                    }
                }

                foreach (KeyValueModel product in map.cbItem.Items)
                {
                    if (product.Key == item.ProductID)
                    {
                        map.cbItem.Text = product.Value;
                    }
                }

                foreach (KeyValueModel printe in map.cbPrinter.Items)
                {
                    if (printe.Key == item.PrinterID)
                    {
                        map.cbPrinter.Text = printe.Value;
                    }
                }


               

            }
          
        }

        public void LoadPriterMapp()
        {
            UCPrinterMapping map = new UCPrinterMapping();
            map.Width = flpPriterMap.Width-5;
            flpPriterMap.Controls.Add(map);
        }

        private void UCPrinterJobDetail_Load(object sender, EventArgs e)
        {
            //LoadPriterMapp();
            this.cbPrintContent.DisplayMember = "Value";
            this.cbPrintContent.ValueMember = "Key";

            var temp = new KeyValueModel();
            temp.Key = 1;
            temp.Value = "All Lines";
            this.cbPrintContent.Items.Add(temp);
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            this.LoadPriterMapp();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}

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
using ServicePOS.Model;

namespace POSEZ2U.UC
{
    public partial class UCPrinterMapping : UserControl
    {


        private IPrinterService _printerService;
        private IPrinterService PrinterService
        {
            get { return _printerService ?? (_printerService = new PrinterService()); }
            set { _printerService = value; }
        }

        public UCPrinterMapping()
        {
            InitializeComponent();
        }

        private void UCPrinterMapping_Load(object sender, EventArgs e)
        {

            getInnitData();

        }

        public void getInnitData()
        {

            var data = new PrintJobDetailModel();

            data.ID = 0;
            data.PrinteJobID = 0;
            data.CategoryID = 0;
            data.ProductID = 0;
            data.PrinterID = 0;
            data.TemplatesID = 0;

            this.Tag = data;

            // get cbTemplate
            this.cbTemplate.DisplayMember = "Value";
            this.cbTemplate.ValueMember = "Key";


            var temp = new KeyValueModel();
            temp.Key = 1;
            temp.Value = "Template";
            this.cbTemplate.Items.Add(temp);
            this.cbTemplate.SelectedIndex = 0;


            // get cbPrinter
            this.cbPrinter.DisplayMember = "Value";
            this.cbPrinter.ValueMember = "Key";

            var dataPrinter = PrinterService.GetListPrinter().ToList();
            foreach (var item in dataPrinter)
            {
                var tempprint = new KeyValueModel();
                tempprint.Key = item.ID;
                tempprint.Value = item.PrintName;
                this.cbPrinter.Items.Add(tempprint); 
            }

            this.cbPrinter.SelectedIndex = 0;

            // get Group 

            this.cbGroupItem.DisplayMember = "Value";
            this.cbGroupItem.ValueMember = "Key";

            var datagroup = PrinterService.GetCategoryList().ToList();


            var tempgroup1 = new KeyValueModel();
            tempgroup1.Key = 0;
            tempgroup1.Value = "-- All --";
            this.cbGroupItem.Items.Add(tempgroup1);


            foreach (var itemgroup in datagroup)
            {
                var tempgroup = new KeyValueModel();
                tempgroup.Key = itemgroup.CategoryID;
                tempgroup.Value = itemgroup.CategoryName;
                this.cbGroupItem.Items.Add(tempgroup);
            }

            this.cbGroupItem.SelectedIndex = 0;

            // get Item 

            this.cbItem.DisplayMember = "Value";
            this.cbItem.ValueMember = "Key";

            this.cbItem.Items.Add(tempgroup1);
            this.cbItem.SelectedIndex = 0;
        }

        private void cbGroupItem_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.cbItem.Items.Clear();

            var cbGroup = (KeyValueModel)cbGroupItem.SelectedItem;

            var datagroup = PrinterService.GetProductListByCategory(cbGroup.Key).ToList();

            var temp = new KeyValueModel();
            temp.Key = 0;
            temp.Value = "-- All --";
            this.cbItem.Items.Add(temp);

            foreach (var item in datagroup)
            {
                var tempitem = new KeyValueModel();
                tempitem.Key = item.ProductID;
                tempitem.Value = item.ProductNameDesc;
                this.cbItem.Items.Add(tempitem);
            }

            this.cbItem.SelectedIndex = 0;
        }
    }
}

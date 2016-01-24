using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemLog;
using POSEZ2U.Class;
using ServicePOS;
using POSEZ2U.UC;
using ServicePOS.Model;

namespace POSEZ2U
{
    public partial class frmSettingPrint : Form
    {
        public frmSettingPrint()
        {
            InitializeComponent();
        }
        public delegate void ResetPrinterList(int i);

        int flag;
        int CategoryID;
        int PriterID;
        public List<PrintJobDetailModel> LstPrinterJob = new List<PrintJobDetailModel>();
        private IPrinterService _printerService;
        private IPrinterService PrinterService
        {
            get { return _printerService ?? (_printerService = new PrinterService()); }
            set { _printerService = value; }
        }

        private ICatalogueService _catalogeService;
        private ICatalogueService CatalogeService
        {
            get { return _catalogeService ?? (_catalogeService = new CatalogueService()); }
            set { _catalogeService = value; }
        }

        private IProductService _productService;
        private IProductService ProductService
        {
            get { return _productService ?? (_productService = new ProductService()); }
            set { _productService = value; }
        }

        private IPrinterSettingServer _printService;
        private IPrinterSettingServer PrintService
        {
            get { return _printService ?? (_printService = new PrinterSettingServer()); }
            set { _printService = value; }
        }
        private void LoadPrinterSetting()
        {
            try
            {
                string[] str = { "Print Jobs" };
                int i = 1;
                foreach (string item in str)
                {
                    UCPrintSetting ucPSetting = new UCPrintSetting();
                    ucPSetting.lblPrintSetting.Text = item;
                    ucPSetting.Tag = i + "";
                    i++;
                    ucPSetting.Width = flpPrintSetting.Width;
                    ucPSetting.Click += ucPSetting_Click;
                    flpPrintSetting.Controls.Add(ucPSetting);

                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmPrinterSetting:::::::::::::::::::LoadPrinterSetting::::::::::::::::" + ex.Message);
            }
        }

        void ucPSetting_Click(object sender, EventArgs e)
        {
            UCPrintSetting ucP = (UCPrintSetting)sender;
            flag = Convert.ToInt32(ucP.Tag);
            foreach (Control ctr in flpPrintSetting.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucP.BackColor = Color.FromArgb(0, 153, 51);
            ucP.ForeColor = Color.FromArgb(255, 255, 255);
            LoadDataOfPrinter();
        }

        private void LoadDataOfPrinter()
        {
            flpPrintList.Controls.Clear();
            var listData = PrinterService.GetListPrinter();

            foreach (PrinterModel item in listData)
            {
                UCPrinterList ucPList = new UCPrinterList();
                ucPList.lblPrintList.Text = item.PrintName;
                ucPList.Tag = item;
                ucPList.Click += ucPList_Click;
                ucPList.Width = flpPrintList.Width;
                flpPrintList.Controls.Add(ucPList);
            }


        }

        void ucPList_Click(object sender, EventArgs e)
        {
            UCPrinterList ucP = (UCPrinterList)sender;
            PrinterModel priter = (PrinterModel)ucP.Tag;
            PriterID = priter.ID;
            //flag = Convert.ToInt32(ucP.Tag);
            foreach (Control ctr in flpPrintList.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucP.BackColor = Color.FromArgb(0, 153, 51);
            ucP.ForeColor = Color.FromArgb(255, 255, 255);
            LoadCategory();
        }

        private void LoadCategory()
        {
            flpGroup.Controls.Clear();
            var lst = CatalogeService.GetListCategory();
            foreach (CategoryModel item in lst)
            {
                UCCategoryPrint ucCategory = new UCCategoryPrint();
                ucCategory.lblNameCategory.Text = item.CategoryNameSort;
                ucCategory.Tag = item;
                ucCategory.Click += ucCategory_Click;
                ucCategory.Width = flpGroup.Width;
                flpGroup.Controls.Add(ucCategory);
            }
        }

        void ucCategory_Click(object sender, EventArgs e)
        {
            UCCategoryPrint ucP = (UCCategoryPrint)sender;
            //flag = Convert.ToInt32(ucP.Tag);
            CategoryModel cate = (CategoryModel)ucP.Tag;
            CategoryID = cate.CategoryID;
            foreach (Control ctr in flpGroup.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                {
                    ctr.BackColor = Color.FromArgb(255, 255, 255);
                    ctr.ForeColor = Color.FromArgb(51, 51, 51);
                }
            }
            ucP.BackColor = Color.FromArgb(0, 153, 51);
            ucP.ForeColor = Color.FromArgb(255, 255, 255);
            LoadItemOfCategory(cate.CategoryID);
        }
        private void LoadItemOfCategory(int CategoryID)
        {
            try
            {
                flpItem.Controls.Clear();
                LstPrinterJob.Clear();
                var lst = ProductService.GetProdutcByCategoryPrint(CategoryID);
                var lstPrintJob = PrintService.GetItem(CategoryID,PriterID);
                foreach (PrinteJobDetailModel joblst in lstPrintJob)
                {
                    PrintJobDetailModel itemjob = new PrintJobDetailModel();
                    itemjob.CategoryID = joblst.CategoryID;
                    itemjob.ProductID = joblst.ProductID;
                    itemjob.PrinterID = joblst.PrinterID;
                    LstPrinterJob.Add(itemjob);
                }
                foreach (ProductionModel item in lst)
                {
                    UCItemOfCategoryPrint ucItem = new UCItemOfCategoryPrint();
                    
                        ucItem.lblItemName.Text = item.ProductNameSort;
                        ucItem.Tag = item;
                        ucItem.BackColor = Color.FromArgb(228, 228, 228);
                        ucItem.Click += ucItem_Click;
                    

                    flpItem.Controls.Add(ucItem);
                }
                foreach (PrinteJobDetailModel joblst in lstPrintJob)
                {
                    foreach (Control ctr in flpItem.Controls)
                    {
                        ProductionModel pro = (ProductionModel)ctr.Tag;
                        if (joblst.ProductID == pro.ProductID)
                        {
                            ctr.BackColor = Color.FromArgb(0, 153, 51);
                            ctr.ForeColor = Color.FromArgb(255, 255, 255);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogPOS.WriteLog("frmSettingPrint::::::::::::::::LoadItemOfCategory:::::::::::::::" + ex.Message);
            }
            
        }

        void ucItem_Click(object sender, EventArgs e)
        {
            UCItemOfCategoryPrint ucItem = (UCItemOfCategoryPrint)sender;
            if (ucItem.BackColor == Color.FromArgb(228, 228, 228))
            {
                ucItem.BackColor = Color.FromArgb(0, 153, 51);
                ucItem.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                ucItem.BackColor =Color.FromArgb(228, 228, 228);
                ucItem.ForeColor = Color.FromArgb(51,51,51);
            }
        }
        private void frmSettingPrint_Load(object sender, EventArgs e)
        {
            this.LoadPrinterSetting();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = 0;
            foreach (PrintJobDetailModel item in LstPrinterJob)
            {
                PrintService.DeletePrintJob(item.CategoryID??0, item.ProductID??0, item.PrinterID??0);            
            }
            
            foreach (Control ctr in flpItem.Controls)
            {
                if (ctr is UCItemOfCategoryPrint)
                {
                    if (ctr.BackColor == Color.FromArgb(0, 153, 51))
                    {
                        ProductionModel pro = (ProductionModel)ctr.Tag;
                        PrinteJobDetailModel item = new PrinteJobDetailModel();
                        item.CategoryID = pro.CategoryID;
                        item.ProductID = pro.ProductID;
                        item.PrinterID = PriterID;
                        PrintService.InsertPrinterMapping(item);
                    }
                }
            }
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddPrinter_Click(object sender, EventArgs e)
        {
            frmAddPrinter frm = new frmAddPrinter();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadDataOfPrinter();
            }
        }
    }
}

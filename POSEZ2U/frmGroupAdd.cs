﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSEZ2U.Class;
using POSEZ2U.UC;
using ServicePOS;
using ServicePOS.Model;

namespace POSEZ2U
{
    public partial class frmGroupAdd : Form
    {

        #region Variables & Constructors
        private ICatalogueService _catalogeService;
        private ICatalogueService CatalogeService
        {
            get { return _catalogeService ?? (_catalogeService = new CatalogueService()); }
            set { _catalogeService = value; }
        }
        #endregion


        public int categoryid = 0;
        public List<ProductionModel> listmap = new List<ProductionModel>();
        public List<ProductionModel> listall = new List<ProductionModel>();
        public frmGroupAdd(int _categoryid)
        {
            InitializeComponent();
            categoryid = _categoryid;
            listmap = CatalogeService.GetProductByCategoryID(categoryid).ToList();
            listall = CatalogeService.GetAllListProductByCategory(categoryid).ToList();
        }
        //string[] str = { "Green Tea" };
        private void LoadThisGroupItems()
        {
            flpThisgroupitems.Controls.Clear();

            for (int i = 0; i < listmap.Count; i++)
            {
                UCMenuAdd ucMenuAdd = new UCMenuAdd();
                ucMenuAdd.lblGroupName.Text = listmap[i].ProductNameDesc;
                ucMenuAdd.Tag = listmap[i];
                ucMenuAdd.Click += flpThisgroupitems_Click;
                flpThisgroupitems.Controls.Add(ucMenuAdd);
            }
        }
        private void LoadAllItem()
        {
            flpAllitems.Controls.Clear();
            foreach (var item in listall)
            {
                    UCMenuAdd ucMenuAddAll = new UCMenuAdd();
                    ucMenuAddAll.lblGroupName.Text = item.ProductNameDesc;
                    ucMenuAddAll.Tag = item;
                    ucMenuAddAll.Click += ucMenuAddAll_Click;
                    flpAllitems.Controls.Add(ucMenuAddAll);
            }
        }

        void ucMenuAddAll_Click(object sender, EventArgs e)
        {
            UCMenuAdd ucMenuAll = (UCMenuAdd)sender;
            if (ucMenuAll.BackColor == Color.FromArgb(0, 102, 204))
            {
                ucMenuAll.BackColor = DefaultBackColor;
                ucMenuAll.ForeColor = DefaultForeColor;
            }
            else
            {
                ucMenuAll.BackColor = Color.FromArgb(0, 102, 204);
                ucMenuAll.ForeColor = Color.FromArgb(255, 255, 255);
            }
            
        }
        void flpThisgroupitems_Click(object sender, EventArgs e)
        {
            UCMenuAdd ucMenuAll = (UCMenuAdd)sender;
            if (ucMenuAll.BackColor == Color.FromArgb(0, 102, 204))
            {
                ucMenuAll.BackColor = DefaultBackColor;
                ucMenuAll.ForeColor = DefaultForeColor;
            }
            else
            {
                ucMenuAll.BackColor = Color.FromArgb(0, 102, 204);
                ucMenuAll.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmMenuAdd_Load(object sender, EventArgs e)
        {
            LoadThisGroupItems();
            LoadAllItem();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in flpAllitems.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 102, 204))
                {
                    UCMenuAdd ucMenuGet = (UCMenuAdd)ctr;
                    ProductionModel itemlef = (ProductionModel)(ucMenuGet.Tag);
                    ProductionModel item = new ProductionModel();
                    item.ProductID = itemlef.ProductID;
                    item.ProductNameDesc = itemlef.ProductNameDesc;
                    listmap.Add(item);
                    var index = -1;
                    for(int i=0;i<listall.Count;i++)
                    {
                        if (listall[i].ProductID == item.ProductID)
                        {
                            index = i;
                        }
                    }
                    if (index> - 1)
                    {
                        listall.RemoveAt(index);
                    }
                }
            }
            LoadThisGroupItems();
            LoadAllItem();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var result = CatalogeService.SaveDataMapProductToCategory(listmap, categoryid, 0);
            if (result == 1)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Save data product fail.", "Messenger");
            }
            
           
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in flpThisgroupitems.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 102, 204))
                {
                    UCMenuAdd ucMenuGet = (UCMenuAdd)ctr;
                    ProductionModel itemlef = (ProductionModel)(ucMenuGet.Tag);
                    ProductionModel item = new ProductionModel();
                    item.ProductID = itemlef.ProductID;
                    item.ProductNameDesc = itemlef.ProductNameDesc;
                    listall.Add(item);
                    var index = -1;
                    for (int i = 0; i < listmap.Count; i++)
                    {
                        if (listmap[i].ProductID == item.ProductID)
                        {
                            index = i;
                        }
                    }
                    if (index > -1)
                    {
                        listmap.RemoveAt(index);
                    }
                }
            }
            LoadThisGroupItems();
            LoadAllItem();
        }

        private void btnAllLeft_Click(object sender, EventArgs e)
        {
            foreach (var item in listall)
            {
                listmap.Add(item);
            }
            listall=new List<ProductionModel>();
            LoadThisGroupItems();
            LoadAllItem();
        }

        private void btnAllRight_Click(object sender, EventArgs e)
        {
            foreach (var item in listmap)
            {
                listall.Add(item);
            }
            listmap = new List<ProductionModel>();
            LoadThisGroupItems();
            LoadAllItem();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var listAllSearch = new List<ProductionModel>();
                listall = new List<ProductionModel>();
                listAllSearch = CatalogeService.GetSearchAllListProductByCategory(categoryid, txtSearch.Text).ToList();
                flpAllitems.AutoScroll = true;
                List<string> str = new List<string>();
                for (var i = 0; i < listmap.Count(); i++)
                {
                    str.Add(listmap[i].ProductNameDesc);
                }
                foreach (var item in listAllSearch)
                {
                    if (!str.Contains(item.ProductNameDesc))
                    {
                        listall.Add(item);
                    }
                }
                LoadAllItem();
            }
            catch (Exception ex)
            {
                SystemLog.LogPOS.WriteLog("frmGroupAdd:::::::::::::::::::txtSearch_TextChanged:::::::::::::::::" + ex.Message);
            }
        }
    }
}

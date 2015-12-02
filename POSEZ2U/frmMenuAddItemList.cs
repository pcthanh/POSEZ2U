using System;
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
    public partial class frmMenuAddItemList : Form
    {
        #region Variables & Constructors
        private IMapModifireToProduct _mapModifireToProductService;
        private IMapModifireToProduct MapModifireToProductService
        {
            get { return _mapModifireToProductService ?? (_mapModifireToProductService = new MapModifireToProductService()); }
            set { _mapModifireToProductService = value; }
        }
        #endregion
        #region Variables & Constructors
        private IModifireService _modifireService;
        private IModifireService ModifireService
        {
            get { return _modifireService ?? (_modifireService = new ModifireService()); }
            set { _modifireService = value; }
        }
        #endregion
        public int productID = 0;
        public List<ModifireModel> listAllItem = new List<ModifireModel>();
        public List<ModifireModel> listItem = new List<ModifireModel>();
        public frmMenuAddItemList(int _productID)
        {
            InitializeComponent();
            productID = _productID;
            listAllItem = ModifireService.GetModifireAllList(productID).ToList();
            listItem = ModifireService.GetListModifireToProduct(productID).ToList();
        }
        private void LoadThisGroupItems()
        {
            flpThisgroupitems.Controls.Clear();
            foreach (var item in listItem)
            {
                UCMenuAdd ucMenuAdd = new UCMenuAdd();
                ucMenuAdd.lblGroupName.Text = item.ModifireName;
                ucMenuAdd.Tag = item;
                ucMenuAdd.Click += ucMenuAdd_Click;
                flpThisgroupitems.Controls.Add(ucMenuAdd);
            }
        }
        private void LoadAllItem()
        {
            flpAllitems.Controls.Clear();
            foreach (var item in listAllItem)
            {
                UCMenuAdd ucMenuAddAll = new UCMenuAdd();
                ucMenuAddAll.lblGroupName.Text = item.ModifireName;
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmMenuAdd_Load(object sender, EventArgs e)
        {
            this.LoadThisGroupItems();
            LoadAllItem();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in flpAllitems.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 102, 204))
                {
                    UCMenuAdd ucMenuGet = (UCMenuAdd)ctr;
                    ModifireModel itemLeft = (ModifireModel)(ctr.Tag);
                    ModifireModel itemRight = new ModifireModel();
                    itemRight.ModifireName = itemLeft.ModifireName;
                    itemRight.ModifireID = itemLeft.ModifireID;
                    listItem.Add(itemRight);
                    var index = -1;
                    for (int i = 0; i < listAllItem.Count; i++)
                    {
                        if (listAllItem[i].ModifireID == itemRight.ModifireID)
                        {
                            index = i;
                        }
                    }
                    if (index > -1)
                    {
                        listAllItem.RemoveAt(index);
                    }
                }
            }
            LoadThisGroupItems();
            LoadAllItem();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var result = MapModifireToProductService.SaveMapModifireToProduct(listItem, productID, 0);
            if (result == 1)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Save data product fail.", "Messenger");
            }
            
           
        }
        private void UCItemList_Click(object sender, EventArgs e)
        {
            UCItemListButton ucItemListButton = (UCItemListButton)sender;
            MessageBox.Show(ucItemListButton.Tag.ToString());
        }
        private void ucMenuAdd_Click(object sender, EventArgs e)
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

        private void btnRight_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in flpThisgroupitems.Controls)
            {
                if (ctr.BackColor == Color.FromArgb(0, 102, 204))
                {
                    UCMenuAdd ucMenuGet = (UCMenuAdd)ctr;
                    ModifireModel itemRight = (ModifireModel)(ctr.Tag);
                    ModifireModel itemLeft = new ModifireModel();
                    itemLeft.ModifireID = itemRight.ModifireID;
                    itemLeft.ModifireName = itemRight.ModifireName;
                    listAllItem.Add(itemLeft);
                    var index = -1;
                    for (int i = 0; i < listItem.Count; i++)
                    {
                        if (listItem[i].ModifireID == itemLeft.ModifireID)
                        {
                            index = i;
                        }
                    }
                    if (index > -1)
                    {
                        listItem.RemoveAt(index);
                    }
                }
            }
            LoadThisGroupItems();
            LoadAllItem();
        }

        private void btnAllLeft_Click(object sender, EventArgs e)
        {
            foreach (var data in listAllItem)
            {
                ModifireModel itemRight = new ModifireModel();
                itemRight.ModifireName = data.ModifireName;
                itemRight.ModifireID = data.ModifireID;
                listItem.Add(itemRight);
            }
            listAllItem = new List<ModifireModel>();
            LoadThisGroupItems();
            LoadAllItem();
        }

        private void btnAllRight_Click(object sender, EventArgs e)
        {
            foreach (var data in listItem)
            {
                ModifireModel itemLeft = new ModifireModel();
                itemLeft.ModifireID = data.ModifireID;
                itemLeft.ModifireName = data.ModifireName;
                listAllItem.Add(itemLeft);
            }
            listItem = new List<ModifireModel>();
            LoadThisGroupItems();
            LoadAllItem();
        }
    }
}

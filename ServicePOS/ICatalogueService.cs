
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicePOS.Model;

namespace ServicePOS
{
    public interface ICatalogueService:IDisposable
    {

        IEnumerable<CatalogueModel> GetCatalogueList();

        int SavaDataCatalogue(CatalogueModel cata);

        int RemoveCatalogue(int catalogueid, int userid);

        IEnumerable<CategoryModel> GetCategoryByCatalogueID(int CatalogueID);
        int SaveMapCategoryToCatalogue(List<CategoryModel> data, int catalogueid,int userid);
        IEnumerable<CategoryModel> GetAllListCategoryByCatalogue(int CatalogueID);

        IEnumerable<CategoryModel> GetListCategory();
        int SaveDataCategory(CategoryModel cate);
        int RemoveCategory(int categoryid, int userid);

        IEnumerable<ProductionModel> GetProductByCategoryID(int CategoryID);
        IEnumerable<ProductionModel> GetAllListProductByCategory(int CategoryID);

        int SaveDataMapProductToCategory(List<ProductionModel> data, int categoryid, int userid);

        IEnumerable<CategoryModel> searchProduct(string textSearch, int type);
    }
}

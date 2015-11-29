using System;
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

        IEnumerable<CategoryModel> GetCategoryByCatalogueID(int CatalogueID);


        IEnumerable<CategoryModel> GetListCategory();
        int SaveDataCategory(CategoryModel cate);

        IEnumerable<ProductionModel> GetProductByCategoryID(int CategoryID);
    }
}

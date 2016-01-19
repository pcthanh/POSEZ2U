using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicePOS.Model;

namespace ServicePOS
{
    public interface IProductService : IDisposable
    {
        IEnumerable<ProductionModel> GetProductsList();
        int Created(ProductionModel product);
        int Delete(ProductionModel product);
        IEnumerable<ProductionModel> GetProdutcByCategory(int id);
        ProductionModel GetPrinterType(int ID);
        ProductionModel GetPrinterTypeByCate(int ID);
        IEnumerable<ProductionModel> searchProduct(string textSearch, int type); 
    }
}

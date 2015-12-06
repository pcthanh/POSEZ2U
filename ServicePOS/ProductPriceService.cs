using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelPOS.ModelEntity;
using ServicePOS.Model;
using System.Data.Entity;
namespace ServicePOS
{
    public class ProductPriceService : IProductPriceService
    {
        private POSEZ2UEntities _context;

        public ProductPriceService()
        {
            _context = new POSEZ2UEntities();
        }

        public ProductPriceService(POSEZ2UEntities context)
        {
            _context = context;
        }


        public IEnumerable<ProductPriceModel> GetListProductPrice()
        {
            var data = _context.Database.SqlQuery<ProductPriceModel>("pos_th_GetListProductPrice");
            return data;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

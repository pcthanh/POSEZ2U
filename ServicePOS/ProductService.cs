using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelPOS.ModelEntity;
using ServicePOS.Model;

namespace ServicePOS
{
    public class ProductService : IProductService
    {
        private POSEZ2UEntities _context;

        public ProductService() {
            _context = new POSEZ2UEntities();
        }

        public ProductService(POSEZ2UEntities context)
        {
            _context = context;
        }

        public IEnumerable<ProductionModel> GetProductsList()
        {
            var data = _context.PRODUCTs.Where(x => x.Status == 1).Select(x => new ProductionModel
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName
            });
            return data;
        }

        #region Dispose
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    // code is here
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}

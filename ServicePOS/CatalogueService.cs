using System;
using System.Collections.Generic;
using System.Linq;
using ModelPOS.ModelEntity;
using ServicePOS.Model;

namespace ServicePOS
{
    public class CatalogueService : ICatalogueService
    {

         #region Variables and Constructors

        private POSEZ2UEntities _context;
        public CatalogueService()
        {
            _context = new POSEZ2UEntities();
        }

        public CatalogueService(POSEZ2UEntities context)
        {
            _context = context;
        }
        
        public void SetProxyCreationEnabled(bool proxyCreationEnabled)
        {
            _context.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
        }
        #endregion


        #region Function

        public IEnumerable<CatalogueModel> GetCatalogueList()
        {
            var data = _context.CATALOGUEs.Where(x => x.Status == 1).Select(x => new CatalogueModel
            {
                CatalogueID = x.CatalogueID,
                CatalogueName = x.CatalogueName
            });
            return data;
        }

        #endregion


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

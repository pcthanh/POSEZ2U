using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelPOS.ModelEntity;
using ServicePOS.Model;
using System.Data.Entity;
using System.Data.SqlClient;

namespace ServicePOS
{
    public class PriceListService : IPriceListService
    {
        #region Variables and Constructors
        private POSEZ2UEntities _context;

        public PriceListService()
        {
            _context = new POSEZ2UEntities();
        }

        public PriceListService(POSEZ2UEntities context)
        {
            _context = context;
        }

        public void SetProxyCreationEnabled(bool proxyCreationEnabled)
        {
            _context.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
        }
        #endregion

        public IEnumerable<PriceListModel> GetDataProductAndModifire()
        {
            var data = _context.Database.SqlQuery<PriceListModel>("pos_th_GetDataProductAndModifire").ToList();
            return data;
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

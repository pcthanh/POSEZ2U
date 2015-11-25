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
    }
}

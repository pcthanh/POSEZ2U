using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelPOS.ModelEntity;
using ServicePOS.Model;

namespace ServicePOS
{
    public class UserService : IUserService
    {
        #region Variables and Constructors

        private POSEZ2UEntities _context;
        public UserService()
        {
            _context = new POSEZ2UEntities();
        }

        public UserService(POSEZ2UEntities context)
        {
            _context = context;
        }

        public void SetProxyCreationEnabled(bool proxyCreationEnabled)
        {
            _context.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
        }
        #endregion

        #region Function

        #region Department

        public IEnumerable<DepartmentModel> GetListDepartment()
        {
            var data = _context.DEPARTMENTs.Where(x => x.Status == 1).Select(x => new DepartmentModel
            {
                DepartmentID = x.DepartmentID,
                DepartmentName = x.DepartmentName,
                Status = x.Status
            });

            return data;
        }

        #endregion


        #region Staff

        public IEnumerable<StaffModel> GetListStaff()
        {
            var data = _context.STAFFs.Where(x => x.Status == 1).Select(x => new StaffModel
            {
                StaffID = x.StaffID,
                Fname = x.Fname,
                Lname = x.Lname,
                UserName = x.UserName,
                Password = x.Password,
                DepartmentID = x.DepartmentID,
                Status = x.Status
            });

            return data;
        }

        #endregion

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

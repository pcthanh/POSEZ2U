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
    public class ModifireService : IModifireService
    {
        #region Variables and Constructors
        private POSEZ2UEntities _context;

        public  ModifireService()
        {
            _context = new POSEZ2UEntities();
        }

        public ModifireService(POSEZ2UEntities context)
        {
            _context = context;
        }

        public void SetProxyCreationEnabled(bool proxyCreationEnabled)
        {
            _context.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
        }
        #endregion

        #region Function Get List

        public IEnumerable<ModifireModel> GetModifireList() 
        {
            var data = _context.MODIFIREs
                .Join(_context.MODIFIRE_PRICE, modifire => modifire.ModifireID, modifire_price => modifire_price.ModifireID, (modifire, modifire_price) => new { modifire, modifire_price })
                .Where(x => x.modifire.Status == 1 && x.modifire_price.Status ==1).Select(x => new ModifireModel()
            {
                ModifireID = x.modifire.ModifireID,
                ModifireName = x.modifire.ModifireName,
                Color = x.modifire.Color,
                CurrentPrice = x.modifire_price.CurrentPrice
            });
            return data;
        }
        #endregion

        #region 
        public int Created(ModifireModel data)
        {
            try
            {

                if (data.ModifireID == 0)
                {
                    var checkdata = _context.MODIFIREs.Where(x => x.ModifireName == data.ModifireName).ToList();
                    if (checkdata.Count() > 0)
                    {
                        return -1;
                    }

                    var new_data = new MODIFIRE();
                    new_data.ModifireName = data.ModifireName;
                    new_data.Color = data.Color ?? "";
                    new_data.Status = 1;
                    new_data.CreateBy = data.CreateBy ?? 0;
                    new_data.CreateDate = DateTime.Now;
                    new_data.UpdateBy = data.UpdateBy ?? 0;
                    new_data.UpdateDate = DateTime.Now;
                    new_data.Note = data.Note ?? "";

                    _context.Entry(new_data).State = EntityState.Added;
                    _context.SaveChanges();
                    var modifire_price = new MODIFIRE_PRICE();
                    modifire_price.ModifireID = new_data.ModifireID;
                    modifire_price.CurrentPrice = data.CurrentPrice;
                    modifire_price.CreateBy = data.CreateBy ?? 0;
                    modifire_price.CreateDate = DateTime.Now;
                    modifire_price.UpdateBy = data.UpdateBy ?? 0;
                    modifire_price.UpdateDate = DateTime.Now;
                    modifire_price.Note = data.Note ?? "";
                    var result = CreatedModifirePrice(modifire_price);
                    return result;

                }
                else
                {
                    var checkdata = _context.MODIFIREs.Where(x => x.ModifireName == data.ModifireName && x.ModifireID != data.ModifireID).ToList();
                    if (checkdata.Count() > 0)
                    {
                        return -1;
                    }
                    var old_data = _context.MODIFIREs.Find(data.ModifireID);
                    if (old_data != null)
                    {
                        old_data.ModifireName = data.ModifireName;
                        old_data.Color = data.Color ?? "";
                        old_data.Status = 1;
                        old_data.UpdateBy = data.UpdateBy ?? 0;
                        old_data.UpdateDate = DateTime.Now;
                        old_data.Note = data.Note ?? "";

                        _context.Entry(old_data).State = EntityState.Modified;
                        _context.SaveChanges();
                        var modifire_price = new MODIFIRE_PRICE();
                        modifire_price.ModifireID = data.ModifireID;
                        modifire_price.CurrentPrice = data.CurrentPrice;
                        modifire_price.CreateBy = data.CreateBy ?? 0;
                        modifire_price.CreateDate = DateTime.Now;
                        modifire_price.UpdateBy = data.UpdateBy ?? 0;
                        modifire_price.UpdateDate = DateTime.Now;
                        modifire_price.Note = data.Note ?? "";
                        var result = CreatedModifirePrice(modifire_price);
                        return result;
                    }
                    return 0;

                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        #endregion

        #region Function Created Modifire_Price
        public int CreatedModifirePrice(MODIFIRE_PRICE modifire_price)
        {
            try
            {
                var data = _context.MODIFIRE_PRICE.Where(x => x.ModifireID == modifire_price.ModifireID).SingleOrDefault();
                if (data != null)
                {
                    data.WasPrice = data.CurrentPrice;
                    data.CurrentPrice = modifire_price.CurrentPrice;
                    data.Status = 1;
                    data.UpdateBy = modifire_price.UpdateBy;
                    data.UpdateDate = modifire_price.UpdateDate;
                    data.CreateBy = modifire_price.CreateBy;
                    data.CreateDate = modifire_price.CreateDate;
                    data.Note = modifire_price.Note;
                    _context.Entry(data).State = EntityState.Modified;
                    _context.SaveChanges();
                    return 1;
                }
                else
                {
                    var new_data = new MODIFIRE_PRICE();
                    new_data.ModifireID = modifire_price.ModifireID;
                    new_data.WasPrice = 0;
                    new_data.CurrentPrice = modifire_price.CurrentPrice;
                    new_data.Status = 1;
                    new_data.UpdateBy = modifire_price.UpdateBy;
                    new_data.UpdateDate = modifire_price.UpdateDate;
                    new_data.CreateBy = modifire_price.CreateBy;
                    new_data.CreateDate = modifire_price.CreateDate;
                    new_data.Note = modifire_price.Note;
                    _context.Entry(new_data).State = EntityState.Added;
                    _context.SaveChanges();
                    return 1;
                }
            }
            catch (Exception)
            {
                return 0;
            }
            
            
        }
        #endregion
        #region
        public IEnumerable<ModifireModel> GetListModifireToProduct(int productID)
        {
            var data = _context.Database.SqlQuery<ModifireModel>("pos_th_GetListModifireToProduct @productID", new SqlParameter("productID", productID));
            return data;
        }
        #endregion

        #region
        public IEnumerable<ModifireModel> GetModifireAllList(int productID)
        {
            var data = _context.Database.SqlQuery<ModifireModel>("pos_th_GetListModifire @productID", new SqlParameter("productID", productID));
            return data;
        }
        #endregion

        #region
        public int Delete(ModifireModel data)
        {
            var checkdata = _context.MODIFIREs.Find(data.ModifireID);
            if (checkdata != null)
            {
                checkdata.Status = 0;
                checkdata.UpdateBy = data.UpdateBy ?? 0;
                checkdata.UpdateDate = DateTime.Now;
                _context.Entry(checkdata).State = EntityState.Modified;
                _context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
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

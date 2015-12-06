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
            var data = _context.PRODUCTs.Join(_context.PRODUCT_PRICE, product => product.ProductID, product_price => product_price.ProductID, (product, product_price) => new { product, product_price })
                .Where(x => x.product.Status == 1 && x.product_price.Status == 1).Select(x => new ProductionModel
            {
                ProductID = x.product.ProductID,
                ProductNameDesc = x.product.ProductNameDesc,
                ProductNameSort = x.product.ProductNameSort,
                Color = x.product.Color,
                CurrentPrice = x.product_price.CurrentPrice
            });
            return data;
        }

        public int Created(ProductionModel data)
        {
            try
            {

                if (data.ProductID == 0)
                {
                    var checkdata = _context.PRODUCTs.Where(x => x.ProductNameDesc == data.ProductNameDesc).ToList();
                    if (checkdata.Count() > 0)
                    {
                        return -1;
                    }

                    var new_data = new PRODUCT();
                    new_data.ProductNameDesc = data.ProductNameDesc;
                    new_data.ProductNameSort = data.ProductNameSort;
                    new_data.Color = data.Color ?? "";
                    new_data.Status = 1;
                    new_data.CreateBy = data.CreateBy ?? 0;
                    new_data.CreateDate = DateTime.Now;
                    new_data.UpdateBy = data.UpdateBy ?? 0;
                    new_data.UpdateDate = DateTime.Now;
                    new_data.Note = data.Note ?? "";

                    _context.Entry(new_data).State = EntityState.Added;
                    _context.SaveChanges();
                    var product_price = new PRODUCT_PRICE();
                    product_price.ProductID = new_data.ProductID;
                    product_price.CurrentPrice = data.CurrentPrice;
                    product_price.CreateBy = data.CreateBy ?? 0;
                    product_price.CreateDate = DateTime.Now;
                    product_price.UpdateBy = data.UpdateBy ?? 0;
                    product_price.UpdateDate = DateTime.Now;
                    product_price.Note = data.Note ?? "";
                    var result = CreatedProductPrice(product_price);
                    return result;

                }
                else
                {
                    var checkdata = _context.PRODUCTs.Where(x => x.ProductNameDesc == data.ProductNameDesc && x.ProductID != data.ProductID).ToList();
                    if (checkdata.Count() > 0)
                    {
                        return -1;
                    }
                    var old_data = _context.PRODUCTs.Find(data.ProductID);
                    if (old_data != null)
                    {
                        old_data.ProductNameDesc = data.ProductNameDesc;
                        old_data.ProductNameSort = data.ProductNameSort;
                        old_data.Color = data.Color ?? "";
                        old_data.Status = 1;
                        old_data.UpdateBy = data.UpdateBy ?? 0;
                        old_data.UpdateDate = DateTime.Now;
                        old_data.Note = data.Note ?? "";

                        _context.Entry(old_data).State = EntityState.Modified;
                        _context.SaveChanges();
                        var product_price = new PRODUCT_PRICE();
                        product_price.ProductID = data.ProductID;
                        product_price.CurrentPrice = data.CurrentPrice;
                        product_price.CreateBy = data.CreateBy ?? 0;
                        product_price.CreateDate = DateTime.Now;
                        product_price.UpdateBy = data.UpdateBy ?? 0;
                        product_price.UpdateDate = DateTime.Now;
                        product_price.Note = data.Note ?? "";
                        var result = CreatedProductPrice(product_price);
                        return result;
                    }
                    return 0;

                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int CreatedProductPrice(PRODUCT_PRICE product_price)
        {
            try
            {
                var data = _context.PRODUCT_PRICE.Where(x => x.ProductID == product_price.ProductID).SingleOrDefault();
                if (data != null)
                {
                    data.WasPrice = data.CurrentPrice;
                    data.CurrentPrice = product_price.CurrentPrice;
                    data.Status = 1;
                    data.UpdateBy = product_price.UpdateBy;
                    data.UpdateDate = product_price.UpdateDate;
                    data.CreateBy = product_price.CreateBy;
                    data.CreateDate = product_price.CreateDate;
                    data.Note = product_price.Note;
                    data.Portions = "Regular";
                    _context.Entry(data).State = EntityState.Modified;
                    _context.SaveChanges();
                    return 1;
                }
                else
                {
                    var new_data = new PRODUCT_PRICE();
                    new_data.ProductID = product_price.ProductID;
                    new_data.WasPrice = 0;
                    new_data.CurrentPrice = product_price.CurrentPrice;
                    new_data.Status = 1;
                    new_data.UpdateBy = product_price.UpdateBy;
                    new_data.UpdateDate = product_price.UpdateDate;
                    new_data.CreateBy = product_price.CreateBy;
                    new_data.CreateDate = product_price.CreateDate;
                    new_data.Note = product_price.Note;
                    new_data.Portions = "Regular";
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

        public int Delete(ProductionModel data)
        {
            var checkdata = _context.PRODUCTs.Find(data.ProductID);
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
        #region
        public IEnumerable<ProductionModel> GetProdutcByCategory(int id)
        {
            var data = _context.Database.SqlQuery<ProductionModel>("getProductByCategory @categoryid",
              new SqlParameter("categoryid", id)
            ).ToList();
            return data;
        }
        #endregion
    }
}

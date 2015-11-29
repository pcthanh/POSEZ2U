using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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


        #region Catalogue
        public IEnumerable<CatalogueModel> GetCatalogueList()
        {
            var data = _context.CATALOGUEs.Where(x => x.Status == 1).Select(x => new CatalogueModel
            {
                CatalogueID = x.CatalogueID,
                CatalogueName = x.CatalogueName,
                Status = x.Status,
                Color = x.Color??""
            });
            return data;
        }


        public int SavaDataCatalogue(CatalogueModel cata)
        {
            try
            {
                
                if (cata.CatalogueID == 0)
                {
                    var checkdata = _context.CATALOGUEs.Where(x => x.CatalogueName == cata.CatalogueName).ToList();
                    if (checkdata.Count() > 0)
                    {
                        return -1;
                    }
                  
                    var data = new CATALOGUE();
                    data.CatalogueName = cata.CatalogueName;
                    data.Color = cata.Color??"";
                    data.Status = 1;
                    data.CreateBy = cata.CreateBy ?? 0;
                    data.CreateDate = DateTime.Now;
                    data.UpdateBy = cata.UpdateBy ?? 0;
                    data.UpdateDate = DateTime.Now;
                    data.Note = cata.Note ?? "";

                    _context.Entry(data).State = EntityState.Added;
                    _context.SaveChanges();

                    return 1;

                }
                else
                {
                    var checkdata = _context.CATALOGUEs.Where(x => x.CatalogueName == cata.CatalogueName && x.CatalogueID!=cata.CatalogueID).ToList();
                    if (checkdata.Count() > 0)
                    {
                        return -1;
                    }
                    var data = _context.CATALOGUEs.Find(cata.CatalogueID);
                    if (data != null)
                    {
                        data.CatalogueName = cata.CatalogueName;
                        data.Color = cata.Color??"";
                        data.Status = 1;
                        data.UpdateBy = cata.UpdateBy ?? 0;
                        data.UpdateDate = DateTime.Now;
                        data.Note = cata.Note ?? "";

                        _context.Entry(data).State = EntityState.Modified;
                        _context.SaveChanges();

                        return 1;
                    }
                    return 0;

                }
            }
            catch (Exception)
            {
                return 0;
            }
        }


        public IEnumerable<CategoryModel> GetCategoryByCatalogueID(int CatalogueID)
        {

            var data = _context.MAP_CATEGORY_TO_CATALOGUE.Join(_context.CATEGORies, cata => cata.CategoryID,
                cate => cate.CategoryID, (cata, cate) => new { cata, cate })
                .Where(x => x.cata.CatalogueID == CatalogueID && x.cata.Status==1)
                .Select(x=> new CategoryModel()
                {
                    CatalogueID = x.cata.CatalogueID,
                    CategoryID = x.cate.CategoryID,
                    CategoryName = x.cate.CategoryName,
                    Status = x.cate.Status
                });

            return data;
        }


        #endregion

        #region Category

        public IEnumerable<CategoryModel> GetListCategory()
        {
            var data = _context.CATEGORies.Where(x => x.Status == 1).Select(x => new CategoryModel
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName,
                CategoryNameSort = x.CategoryNameSort??"",
                Status = x.Status,
                Color = x.Color??"",
                ProductColor = x.ProductColor??""
            });
            return data;
        }

        public int SaveDataCategory(CategoryModel cate)
        {
            try
            {

                if (cate.CategoryID == 0)
                {
                    var checkdata = _context.CATEGORies.Where(x => x.CategoryName == cate.CategoryName).ToList();
                    if (checkdata.Count() > 0)
                    {
                        return -1;
                    }

                    var data = new CATEGORY();
                    data.CategoryName = cate.CategoryName;
                    data.CategoryNameSort = cate.CategoryNameSort??"";
                    data.Color = cate.Color ?? "";
                    data.ProductColor = cate.ProductColor ?? "";
                    data.Status = 1;
                    data.CreateBy = cate.CreateBy ?? 1;
                    data.CreateDate = DateTime.Now;
                    data.UpdateBy = cate.UpdateBy ?? 0;
                    data.UpdateDate = DateTime.Now;
                    data.Note = cate.Note ?? "";

                    _context.Entry(data).State = EntityState.Added;
                    _context.SaveChanges();

                    return 1;

                }
                else
                {
                    var checkdata = _context.CATEGORies.Where(x => x.CategoryName == cate.CategoryName && x.CategoryID != cate.CategoryID).ToList();
                    if (checkdata.Count() > 0)
                    {
                        return -1;
                    }
                    var data = _context.CATEGORies.Find(cate.CategoryID);
                    if (data != null)
                    {
                        data.CategoryName = cate.CategoryName;
                        data.CategoryNameSort = cate.CategoryNameSort??"";
                        data.Color = cate.Color ?? "";
                        data.ProductColor = cate.ProductColor ?? "";
                        data.Status = 1;
                        data.UpdateBy = cate.UpdateBy ?? 1;
                        data.UpdateDate = DateTime.Now;
                        data.Note = cate.Note ?? "";

                        _context.Entry(data).State = EntityState.Modified;
                        _context.SaveChanges();

                        return 1;
                    }
                    return 0;

                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public IEnumerable<ProductionModel> GetProductByCategoryID(int CategoryID)
        {

            var data = _context.MAP_PRODUCT_TO_CATEGORY.Join(_context.PRODUCTs, cate => cate.ProductID,
                pro => pro.ProductID, (cate, pro) => new { cate, pro })
                .Where(x => x.cate.CategoryID == CategoryID && x.cate.Status == 1)
                .Select(x => new ProductionModel()
                {
                    ProductID = x.cate.ProductID,
                    CategoryID = x.cate.CategoryID,
                    ProductName = x.pro.ProductName,
                    Status = x.pro.Status
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

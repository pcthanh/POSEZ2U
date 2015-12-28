using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelPOS.ModelEntity;
using ServicePOS.Model;

namespace ServicePOS
{
    public class ReportService : IReportService
    {
        #region Variables and Constructors

        private POSEZ2UEntities _context;
        public ReportService()
        {
            _context = new POSEZ2UEntities();
        }

        public ReportService(POSEZ2UEntities context)
        {
            _context = context;
        }

        public void SetProxyCreationEnabled(bool proxyCreationEnabled)
        {
            _context.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
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


        #region Daily Report


        public IEnumerable<DailyReportModel> GetDataDailyReport()
        {
            try
            {
                var data = _context.Database.SqlQuery<DailyReportModel>("pos_th_GetDailySaleReport").ToList();
                return data;
            }
            catch (Exception)
            {
                return null;
            }
           
        }


        public IEnumerable<DailyReportDetailModel> GetDataDetailDailyReport(int paymenttypeid)
        {
            try
            {
                var data = _context.Database.SqlQuery<DailyReportDetailModel>("pos_th_GetDetailDailyReport @paymenttypeid",
                 new SqlParameter("paymenttypeid", paymenttypeid)
                ).ToList();
                return data;
            }
            catch (Exception)
            {

                return null;
            }
            
        }



        #endregion

        #region Weekly Report


        public IEnumerable<DailyReportModel> GetDataWeeklyReport()
        {
            try
            {
                var data = _context.Database.SqlQuery<DailyReportModel>("pos_th_GetWeeklySaleReport").ToList();
                return data;
            }
            catch (Exception)
            {
                return null;
            }

        }


        public IEnumerable<DailyReportDetailModel> GetDataDetailWeeklyReport(int paymenttypeid)
        {
            try
            {
                var data = _context.Database.SqlQuery<DailyReportDetailModel>("pos_th_GetDetailWeeklyReport @paymenttypeid",
                 new SqlParameter("paymenttypeid", paymenttypeid)
                ).ToList();
                return data;
            }
            catch (Exception)
            {

                return null;
            }

        }



        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicePOS.Model;

namespace ServicePOS
{
    public interface IReportService:IDisposable
    {
        IEnumerable<DailyReportModel> GetDataDailyReport();
        IEnumerable<DailyReportDetailModel> GetDataDetailDailyReport(int paymenttypeid);


        IEnumerable<DailyReportModel> GetDataWeeklyReport();

        IEnumerable<DailyReportDetailModel> GetDataDetailWeeklyReport(int paymenttypeid);
    }
}

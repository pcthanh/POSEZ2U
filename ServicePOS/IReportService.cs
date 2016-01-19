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
        #region Old Code Report
        IEnumerable<DailyReportModel> GetDataDailyReport();
        IEnumerable<DailyReportDetailModel> GetDataDetailDailyReport(int paymenttypeid);


        IEnumerable<DailyReportModel> GetDataWeeklyReport();

        IEnumerable<DailyReportDetailModel> GetDataDetailWeeklyReport(int paymenttypeid);

        #endregion Old Code Report

        #region New Code Report

        IEnumerable<DailyReportModel> GetDataSummaryReport(string dateSelect, int type);

        IEnumerable<QTYGroupReportModel> GetDataQTYGroupReport(string dateSelect, int type);
        IEnumerable<QTYItemReportModel> GetDataQTYItemReport(string dateSelect, int type);

        IEnumerable<ShiftReportModel> GetDataShiftReport(string dateSelect);

        #endregion New Code Report
    }
}

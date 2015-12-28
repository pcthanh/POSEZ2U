using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicePOS.Model
{
    public class DailyReportModel
    {

        public double CashTotal { get; set; }
        public double CardTotal { get; set; }

        public double ChequeTotal { get; set; }
        public double AccountTotal { get; set; }

        public double GrifCardTotal { get; set; }
        public double SaleTotal { get; set; }
    }
}

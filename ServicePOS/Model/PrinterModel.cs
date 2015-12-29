using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicePOS.Model
{
   public class PrinterModel
    {
        public int ID { get; set; }
        public string PrintName { get; set; }
        public string PrinterName { get; set; }
        public string PrinterType { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}

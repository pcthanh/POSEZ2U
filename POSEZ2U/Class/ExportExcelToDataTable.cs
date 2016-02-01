using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace POSEZ2U.Class
{
    public class ExportExcelToDataTable
    {
        public string Tilte { get; set; }
        public string Value { get; set; }


        public static void WriteExcelToFrom(List<ExportExcelToDataTable> data)
        {



            //List<ExportExcelToDataTable> data
            SaveFileDialog brwsr = new SaveFileDialog();
            brwsr.FileName = DateTime.Now.ToString("dd-MM-yyyy") + ".xls";

            if (brwsr.ShowDialog() == DialogResult.OK && data.Count()>0)
            {
                //var folderName = Path.GetDirectoryName(brwsr.FileName);

                //var data = new List<ExportExcelToDataTable>();
                //var temp = new ExportExcelToDataTable();
                //temp.Tilte = "Text1";
                //temp.Value = "100.00";
                //data.Add(temp);
                //data.Add(temp);
                //data.Add(temp);
                //data.Add(temp);

                // Khởi động chtr Excell
                COMExcel.Application exApp = new COMExcel.Application();

                // Thêm file temp xls
                COMExcel.Workbook exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);

                // Lấy sheet 1.
                COMExcel.Worksheet exSheet = (COMExcel.Worksheet)exBook.Worksheets[1];

                //// Range là ô [1,1] (A1)
                //COMExcel.Range r = (COMExcel.Range)exSheet.Cells[1, 1];

                //// Ghi dữ liệu
                //r.Value2 = "Demo excel value";

                //// Giãn cột
                //r.Columns.AutoFit();

                var i = 1;

                foreach (var item in data)
                {
                    COMExcel.Range r1 = (COMExcel.Range)exSheet.Cells[i, 1];
                    r1.Value2 = item.Tilte;
                    r1.Columns.AutoFit();

                    COMExcel.Range r2 = (COMExcel.Range)exSheet.Cells[i, 2];
                    r2.Value2 = item.Value;
                    r2.Columns.AutoFit();

                    i++;
                }


                // Hiển thị chương trình excel
                exApp.Visible = false;

                //var fileName = folderName ;


                exBook.SaveAs(brwsr.FileName, COMExcel.XlFileFormat.xlWorkbookNormal, null, null, false, false, COMExcel.XlSaveAsAccessMode.xlExclusive, false, false, false, false, false);


                exBook.Close(false, false, false);

                exApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);

            }

        }
    }
}

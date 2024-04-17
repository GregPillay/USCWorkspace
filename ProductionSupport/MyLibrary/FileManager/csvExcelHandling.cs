using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSupport.MyLibrary.FileManager
{
    public class csvExcelHandling
    {
        string status = "Error";
        public string TextTocsvExcel(List<string> csvTestFile)
        {
           
            try
            {
                if (csvTestFile.Count>0)
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    try
                    {
                        using (var excelPackage = new ExcelPackage(new FileInfo("SCMJobHistory.xlsx")))
                        {
                            ExcelWorksheet ws = excelPackage.Workbook.Worksheets.Add("Exported");
                            for (int i = 0; i < csvTestFile.Count; i++)
                            {
                                ws.Cells[i + 1, 1].Value = csvTestFile[i];
                            }
                            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SCMJobHistory.xlsx");
                            FileInfo excelFile = new FileInfo(filePath);
                            excelPackage.SaveAs(excelFile);

                            MessageBox.Show("Data Exported Successfully!");
                            status = "Data Exported.";
                        };
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        status = "Error in Exporting Data!";
                    }
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); status = "Exception Occured in Exporting Data!";
            }
            return status;
        }
    }
}

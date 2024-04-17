using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigFoxManagement
{
    internal class FileExport
    {
        string AreaCode = "";
        
        internal void ExportFile2Excel(DataGridView dataGridView) 
        {
            //Modified
            string DeskTopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string FilePathTemplate = Path.Combine(DeskTopPath, "ReportExportTemplate.xlsx");
            string FilePathDestination = Path.Combine(DeskTopPath, "NewReport.xlsx");
            if (dataGridView.Rows.Count > 0)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                AreaCode = "";
                //FileInfo tempFile = new FileInfo(FilePathTemplate);
                FileInfo sourceFile = new FileInfo(FilePathTemplate);

                using (var sourceExcel = new ExcelPackage(sourceFile))
                {
                    AreaCode = Convert.ToString(dataGridView.Rows[0].Cells[1].Value);
                    DateTime date = DateTime.Now;
                    string Today = date.ToString("dd-MM-yyyy");

                    // Create the worksheet
                 
                    ExcelWorksheet worksheetSource = sourceExcel.Workbook.Worksheets.Copy(sourceExcel.Workbook.Worksheets[0].Name, "Greg2");
                    // Copy from Template and paste.
                    FileInfo destFileInfo = new FileInfo(FilePathDestination);
                    using (var destinationExcel = new ExcelPackage(destFileInfo))
                    {
                        //   destinationExcel.Workbook.Worksheets.Copy(sourceExcel.Workbook.Worksheets[1].Name,"Greg");
                       
                        ExcelWorksheet destinationWorksheet =   destinationExcel.Workbook.Worksheets.Add("NEW", worksheetSource);
                        destinationExcel.Save();


                        destinationWorksheet.Cells["A1"].LoadFromCollection(worksheetSource.Cells, true);

                        destinationWorksheet.Workbook.Worksheets[0].Cells[10, 10].Value = "Hello";
                        // Export DataGridView data to Excel
                        //for (int i = 0; i < dataGridView.Rows.Count; i++)
                        //{
                        //    for (int j = 0; j < dataGridView.Columns.Count; j++)
                        //    {
                        //        destinationWorksheet.Cells[i + 1 + firstRow, j + 1 + firstCol].Value = dataGridView.Rows[i].Cells[j].Value;
                        //    }
                        //}

                      //  destinationWorksheet.Cells[4, 10].Value = "187";
                       
                        // Save Excel file
                        //string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ReportExport.xlsx");
                        //FileInfo excelFile = new FileInfo(filePath);
                        //excelPackage.SaveAs(excelFile);
                        destinationExcel.Save();
                        MessageBox.Show("Data Exported Successfully!");
                    }
                  
                }
                 
            }
        }
        internal void ExportFileToExcel(DataGridView dataGridView)
        {

            //  Export Successful


            if (dataGridView.Rows.Count > 0)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (var excelPackage = new ExcelPackage(new FileInfo("MyWorkbook.xlsx")))
                {

                    DateTime date = DateTime.Now;
                    string Today = date.ToString("dd-MM-yyyy HH:mm");

                    // Create the worksheet
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add($"{Today}");

                    // Export DataGridView data to Excel
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 1, j + 1].Value = dataGridView.Rows[i].Cells[j].Value;
                        }
                    }

                    // Save Excel file
                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ReportExport.xlsx");
                    FileInfo excelFile = new FileInfo(filePath);
                    excelPackage.SaveAs(excelFile);

                    MessageBox.Show("Data Exported Successfully!");
                }


              //  MessageBox.Show("EXPORTED!");
            }
        }
    }
}

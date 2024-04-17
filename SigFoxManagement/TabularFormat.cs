using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigFoxManagement
{
    internal class TabularFormat
    {
       
        internal List<ReportModel> CreateReportDataView(List<SigFoxSkeleton> uUTList)
        {
            List<ReportModel> Reports = new List<ReportModel>();
            try
            {
                for (int i = 0; i < uUTList.Count; i++)
                {
                    ReportModel reporting = new ReportModel();
                    reporting.SerialNumber = uUTList[i].SerialNumber;
                    reporting.AreaCodeID = 187;
                    int UsgaeCount = 0;
                    try
                    {// usage = null
                        UsgaeCount = Convert.ToInt32(uUTList[i].Usage);
                    }
                    catch (Exception)
                    {// usage not null
                        UsgaeCount = Convert.ToInt32(uUTList[i].Usage.Count);
                    }
                      
                    if (UsgaeCount > 0)
                    {
                        for (int b = 0; b < uUTList[i].Usage.Count; b++)
                        {
                            if (uUTList[i].Usage[b].UsageTypeId == 206)
                            {
                                reporting.RemainingCredit = uUTList[i].Usage[b].StringValue.Trim();

                            }
                            if (uUTList[i].Usage[b].UsageTypeId == 265)
                            {
                                reporting.TotalToDate = uUTList[i].Usage[b].StringValue.Trim();

                            }
                            if (uUTList[i].Usage[b].UsageTypeId == 245)
                            {
                                reporting.LeakDetected = uUTList[i].Usage[b].StringValue.Trim();


                            }
                            if (uUTList[i].Usage[b].UsageTypeId == 371)
                            {
                                reporting.TimeStamp = uUTList[i].Usage[b].StringValue.Trim();

                            }
                            if (uUTList[i].Usage[b].UsageTypeId == 247)
                            {
                                reporting.MagneticTamperDetected = uUTList[i].Usage[b].StringValue.Trim();

                            }
                            if (uUTList[i].Usage[b].UsageTypeId == 249)
                            {
                                reporting.BatteryDetected = uUTList[i].Usage[b].StringValue.Trim();

                            }
                            if (uUTList[i].Usage[b].UsageTypeId == 239)
                            {
                                reporting.TamperDetected = uUTList[i].Usage[b].StringValue.Trim();

                            }
                            if (uUTList[i].Usage[b].UsageTypeId == 242)
                            {
                                reporting.OpticalTamperDetected = uUTList[i].Usage[b].StringValue.Trim();

                            }
                            if (uUTList[i].Usage[b].UsageTypeId == 244)
                            {
                                reporting.ValveFaultDetected = uUTList[i].Usage[b].StringValue.Trim();

                            }
                            if (uUTList[i].Usage[b].UsageTypeId == 317)
                            {
                                reporting.ValveClosed = uUTList[i].Usage[b].StringValue.Trim();

                            }
                        }

                    }
                    else
                    {
                        // no readings
                          reporting.RemainingCredit = "n/a";
                          reporting.TotalToDate = "n/a";
                          reporting.LeakDetected = "n/a";
                          reporting.TimeStamp = "n/a";
                          reporting.MagneticTamperDetected = "n/a";
                          reporting.BatteryDetected = "n/a";
                          reporting.TamperDetected = "n/a";
                          reporting.OpticalTamperDetected = "n/a";
                          reporting.ValveFaultDetected = "n/a";
                          reporting.ValveClosed = "n/a";
                         
                    }
                    ReportModel Updatereporting = new ReportModel();
                    Updatereporting = CheckNulls(reporting);
                    Reports.Add(Updatereporting);
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Reports;
        }

        private ReportModel CheckNulls(ReportModel reporting)
        {
             ReportModel newReport = new ReportModel();
            newReport = reporting;
            if (String.IsNullOrEmpty(newReport.RemainingCredit))
            {
                newReport.RemainingCredit = "0";
            }
            if (String.IsNullOrEmpty(newReport.TotalToDate))
            {
                newReport.TotalToDate = "0";
            }
            if (String.IsNullOrEmpty(newReport.TimeStamp))
            {
                newReport.TimeStamp = "null";
            }
            if (String.IsNullOrEmpty(newReport.LeakDetected))
            {
                newReport.LeakDetected = "false";
            }
            if (String.IsNullOrEmpty(newReport.MagneticTamperDetected))
            {
                newReport.MagneticTamperDetected = "false";
            }
            if (String.IsNullOrEmpty(newReport.BatteryDetected))
            {
                newReport.BatteryDetected = "false";
            }
            if (String.IsNullOrEmpty(newReport.TamperDetected))
            {
                newReport.TamperDetected = "false";
            }
            if (String.IsNullOrEmpty(newReport.OpticalTamperDetected))
            {
                newReport.OpticalTamperDetected = "false";
            }
            if (String.IsNullOrEmpty(newReport.ValveClosed))
            {
                newReport.ValveClosed = "false";
            }
            if (String.IsNullOrEmpty(newReport.ValveFaultDetected))
            {
                newReport.ValveFaultDetected = "false";
            }
            return newReport;
        }

     
    }
}

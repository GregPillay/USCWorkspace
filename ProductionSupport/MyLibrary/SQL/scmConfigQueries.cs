using ProductionSupport.MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionSupport.MyLibrary.SQL
{
    public class scmConfigQueries
    {
        string ConStringScmLive = "Server = tcp:usc-scm-prod.database.windows.net; Initial Catalog = MainDatabase; Persist Security Info = False; User ID = scm@utility-systems.co.za@usc-scm-prod; Password = flow21super77#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        SqlConnection Con;
        SqlDataReader read;
        scmJobs job;
        List<scmJobs> jobs;
        string query = "";
        public List<scmConfig> FetchScmAssociatedJobs(List<string> serials)
        {
            List<scmConfig> AllJobs = new List<scmConfig>();
            
            try
            {
                Con = new SqlConnection(ConStringScmLive);
                OpenConnection();
                for (int i = 0; i < serials.Count; i++)
                {
                    query = "";
                    query = $"SELECT JobDeviceMap.SerialNumber, [JobDeviceMap].JobId,Job.JobName, JobDeviceMap.CaptureDateTime FROM  [configuration].[JobDeviceMap] INNER JOIN [configuration].[Job] ON JobDeviceMap.JobId =Job.JobId where JobDeviceMap.SerialNumber  ='{serials[i]}' order by JobDeviceMap.CaptureDateTime desc";
                    try
                    {
                        SqlCommand cmd = new SqlCommand(query,Con);
                        read = cmd.ExecuteReader();
                        scmConfig myConfig = new scmConfig();
                        jobs = new List<scmJobs>();
                        while (read.Read())
                        {
                          
                            string SerialNumber = read["SerialNumber"].ToString().Trim();
                            myConfig.SerialNumber = SerialNumber;

                            job = new scmJobs();
                            job.CaptureDateTime = Convert.ToDateTime( read["CaptureDateTime"].ToString().Trim());
                            job.JobId = Convert.ToInt32(read["JobId"].ToString().Trim());
                            job.JobName = read["JobName"].ToString().Trim();

                            jobs.Add(job);
                        }
                        myConfig.Jobs = jobs;
                        AllJobs.Add(myConfig);
                        read.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Fetching Jobs");
            }
            CloseConnection();
            return AllJobs;
        }

        private void CloseConnection()
        {
            try
            {
                if (Con.State == System.Data.ConnectionState.Open)
                {
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }

        private void OpenConnection()
        {
            try
            {
                if (Con.State == System.Data.ConnectionState.Closed)
                {
                    Con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

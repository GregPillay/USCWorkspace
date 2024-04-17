using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigFoxManagement
{
    public class SQL
    {
        SqlConnection Con;
        string query = "";
        string amiDevWorker = "Server = tcp:uscamidev.database.windows.net,1433;Initial Catalog = Usc.Worker.Database.Ami; Persist Security Info=False;User ID = moffat@utility-systems.co.za@uscamidev; Password= m0F@t5#utili;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        string scmWorkerLive = "Server = tcp:usc-scm-prod.database.windows.net; Initial Catalog = WorkerDatabase; Persist Security Info = False; User ID = scm@utility-systems.co.za@usc-scm-prod; Password = flow21super77#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        internal List<SigFoxDevice> FetchDevices(List<string> sn)
        {
            query = "";
            List<SigFoxDevice> sigFoxDevices = new List<SigFoxDevice>();
            query = $"SELECT TOP (1000) DeviceId, SerialNumber, AreaCodeId, ProductTypeId, DeviceStatusId,EndUserId, ConfigurationJobId, ProductionSerialNumber, Description, LpwanIdentity FROM  device.Device WHERE (SerialNumber = '{sn[0]}')";
            for (int i = 1; i < sn.Count; i++)
            {
                query = query + $" or SerialNumber = '{sn[i]}'";
            }
          //  Con = new SqlConnection(scmWorkerLive);
            Con = new SqlConnection(amiDevWorker);
            OpenConnection();
           
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                SigFoxDevice device = new SigFoxDevice();
                device.DeviceId = reader["DeviceId"].ToString();
                device.SerialNumber = reader["SerialNumber"].ToString().Trim();
                device.AreaCodeId = GetInt32(reader["AreaCodeId"].ToString().Trim());
                device.ProductTypeId = GetInt32(reader["ProductTypeId"].ToString().Trim());
                device.DeviceStatusId = GetInt32(reader["DeviceStatusId"].ToString().Trim());
                device.ConfigJobId = GetInt32(reader["ConfigurationJobId"].ToString().Trim());
                device.ProductionSerialNumber = reader["ProductionSerialNumber"].ToString().Trim();
                device.Description = reader["Description"].ToString().Trim();
                device.LpWanId = reader["LpwanIdentity"].ToString().Trim();
                device.EndUserId = reader["EndUserId"].ToString().Trim();
                sigFoxDevices.Add(device);
            }
            CloseConnection();
            return sigFoxDevices;
        }

        private int GetInt32(string value)
        {
            int conv = 0;
            try
            {
                if (String.IsNullOrEmpty(value))
                {
                    conv = 0;
                }
                else
                {
                    conv = Convert.ToInt32(value);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Conversion Error!");
            }
          
            return conv;
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
                MessageBox.Show(ex.Message, "Sql Connection Error!");
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
                MessageBox.Show(ex.Message, "Sql Connection Error!");
            }
        }
        int iCount = 0;
        internal void UpdateDevices(List<SigFoxDevice> updateDevice)
        {
            try
            {
                iCount = 0;
              //  Con = new SqlConnection(scmWorkerLive);
                Con = new SqlConnection(amiDevWorker);
                OpenConnection();
                for (int i = 0; i < updateDevice.Count; i++)
                {
                    query = "";
                    query = $"update [device].[Device] set ProductionSerialNumber ='{updateDevice[i].ProductionSerialNumber}',LpwanIdentity = '{updateDevice[i].LpWanId}' ,AreaCodeId = {updateDevice[i].AreaCodeId} , ConfigurationJobId = {updateDevice[i].ConfigJobId} , EndUserId = '{updateDevice[i].Description}' where SerialNumber = '{updateDevice[i].SerialNumber}'\r\n";
                    iCount++;
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"Updating Entries Error at index {iCount}!");
            }
           
        }

        
        internal List<string> FetchDevicesByAreaCodeId(int areaCode)
        {
            List<string>no = new List<string>();
            query = "";

          //    query = $"SELECT * FROM  device.Device WHERE (AreaCodeId = {areaCode})";

           query = $"SELECT TOP (3) *   FROM [device].[Device] where AreaCodeId  = 187   and (SerialNumber = '41250005836' or SerialNumber ='41252705656' or SerialNumber = '41252704659')\r\n  order by DateCaptured desc";
           
            //  Con = new SqlConnection(scmWorkerLive);
            Con = new SqlConnection(amiDevWorker);
            OpenConnection();

            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                 string Num = reader["SerialNumber"].ToString().Trim();
                if (!String.IsNullOrEmpty(Num)&& Num.Length ==11 && Num.StartsWith("41"))
                {
                    no.Add(Num);
                }
               
            }
            CloseConnection();
            return no;
        }
        UsageTypeIds id;
         
        
        internal List<SigFoxSkeleton> FetchDeviceUsage(List<string> sn)
        {
            SqlCommand cmd;
            List<SigFoxSkeleton> DeviceList = new List<SigFoxSkeleton>();
            query = "";
            Con = new SqlConnection(amiDevWorker);
            OpenConnection();
            try
            {
                for (int i = 0; i < sn.Count; i++)
                {
                    SigFoxSkeleton device = new SigFoxSkeleton();
                    query = $"SELECT TOP (30) [DeviceId] ,[UsageTypeId]  ,[StringValue]   ,[NumericValue]  FROM [device].[Usage]  where DeviceId  = '{sn[i]}'  order by UsageTypeId desc";
                    cmd= new SqlCommand(query, Con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<UsageTypeIds> SettingTypes = new List<UsageTypeIds>();
                    device.SerialNumber = sn[i].Trim();
                    while (reader.Read()) 
                    {
                       
                        int UsageID = 0;
                        try
                        {
                            UsageID = Convert.ToInt32(reader["UsageTypeID"].ToString().Trim());
                           // MessageBox.Show(sn[i] + "   "+UsageID);
                             device.SerialNumber = reader["DeviceId"].ToString().Trim();
                              
                                if (UsageID == 265)
                                {
                                    id = new UsageTypeIds();
                                    id.UsageTypeId = 265;
                                    id.SettingType = "Total To Date";
                                    id.StringValue = reader["StringValue"].ToString().Trim();
                                    SettingTypes.Add(id);

                                }
                                if (UsageID == 206)
                                {
                                    id = new UsageTypeIds();
                                    id.UsageTypeId = 206;
                                    id.SettingType = "Remaining Credit";
                                    id.StringValue = reader["StringValue"].ToString().Trim();
                                    SettingTypes.Add(id);

                                }
                             
                                if (UsageID == 245)
                                {
                                    id = new UsageTypeIds();
                                    id.UsageTypeId = 245;
                                    id.SettingType = "Leak Detected";
                                    id.StringValue = reader["StringValue"].ToString().Trim();
                                    SettingTypes.Add(id);

                                }
                                if (UsageID == 247)
                                {
                                    id = new UsageTypeIds();
                                    id.UsageTypeId = 247;
                                    id.SettingType = "Magnetic Tamper Detected";
                                    id.StringValue = reader["StringValue"].ToString().Trim();
                                    SettingTypes.Add(id);

                                }
                                if (UsageID == 249)
                                {
                                    id = new UsageTypeIds();
                                    id.UsageTypeId = 249;
                                    id.SettingType = "Battery Tamper";
                                    id.StringValue = reader["StringValue"].ToString().Trim();
                                    SettingTypes.Add(id);

                                }
                                if (UsageID == 239)
                                {
                                    id = new UsageTypeIds();
                                    id.UsageTypeId = 239;
                                    id.SettingType = "Tamper Detected";
                                    id.StringValue = reader["StringValue"].ToString().Trim();
                                    SettingTypes.Add(id);

                                }
                                if (UsageID == 242)
                                {
                                    id = new UsageTypeIds();
                                    id.UsageTypeId = 242;
                                    id.SettingType = "Optical Tamper Detected";
                                    id.StringValue = reader["StringValue"].ToString().Trim();
                                    SettingTypes.Add(id);

                                }
                                if (UsageID == 244)
                                {
                                    id = new UsageTypeIds();
                                    id.UsageTypeId = 244;
                                    id.SettingType = "Valve Fault Detected";
                                    id.StringValue = reader["StringValue"].ToString().Trim();
                                    SettingTypes.Add(id);

                                }
                                if (UsageID == 317)
                                {
                                    id = new UsageTypeIds();
                                    id.UsageTypeId = 317;
                                    id.SettingType = "Valve Closed";
                                    id.StringValue = reader["StringValue"].ToString().Trim();
                                    SettingTypes.Add(id);

                                }
                                if (UsageID == 371)
                                {
                                    id = new UsageTypeIds();
                                    id.UsageTypeId = 371;
                                    id.SettingType = "Time Stamp";
                                    id.StringValue = reader["StringValue"].ToString().Trim();
                                    SettingTypes.Add(id);

                                }
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        
                       
                    }
                    if (SettingTypes.Count >0)
                    {
                        device.Usage = SettingTypes;
                    }
                   
                    DeviceList.Add(device);
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CloseConnection();
            return DeviceList;
        }
    }
}
/*  WITH LatestReadings AS (
    SELECT DeviceId, MAX(DateCaptured) AS MaxDatestamp 
    FROM [device].[UsageLog] where  UsageTypeId = 265 and DeviceId = '41250006107' 
	
    GROUP BY DeviceId
)
SELECT t.DeviceId, t.DateCaptured, t.StringValue
FROM [device].[UsageLog] t 
JOIN LatestReadings lr ON t.DeviceId = lr.DeviceId AND t.DateCaptured = lr.MaxDatestamp AND t.DateCaptured = lr.MaxDatestamp
order by t.DateCaptured desc, t.StringValue desc;
*/
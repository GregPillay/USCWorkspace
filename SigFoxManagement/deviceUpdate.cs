using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigFoxManagement
{
    public partial class deviceUpdate : UserControl
    {
        List<string> sn;
        List<SigFoxDevice> sigFox;
        SQL sql;
        public deviceUpdate()
        {
            InitializeComponent();
            defaultSettings();
        }

        private void butt_File_Click(object sender, EventArgs e)
        {
            cb_Sn.Items.Clear();
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "text file|*.txt*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                sn = new List<string>();
                string[] all = System.IO.File.ReadAllLines(fileDialog.FileName);
                foreach (string line in all)
                {
                    if (!String.IsNullOrEmpty(line))
                    {
                        sn.Add(line.Trim());
                        cb_Sn.Items.Add(line.Trim());
                    }

                }
            }
        }


        private void butt_Search_Click(object sender, EventArgs e)
        {
            sn = new List<string>();
            for (int i = 0; i < cb_Sn.Items.Count; i++)
            {
                sn.Add(cb_Sn.Items[i].ToString());
            }
            if (sn.Count > 0)
            {
                panel_Result.Visible = true;
                sigFox = new List<SigFoxDevice>();
                sql = new SQL();
                sigFox = sql.FetchDevices(sn);
                dg_Result.DataSource = sigFox;
                butt_update.Visible = true;
            }
        }
        private void tb_Sn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(tb_Sn.Text.Trim()) && tb_Sn.Text.Trim().Length == 11)
                {
                    cb_Sn.Items.Add(tb_Sn.Text.Trim());
                }
                else
                {
                    MessageBox.Show($"Entered Serial Number : {tb_Sn.Text.Trim()} was not in the correct format!");
                }
                tb_Sn.Text = "";
            }
        }
        private void tb_Sn_MouseClick(object sender, MouseEventArgs e)
        {
            tb_Sn.Text = "";
        }

        private void butt_reset_Click(object sender, EventArgs e)
        { 
            defaultSettings();
         
        }

        private void defaultSettings()
        {
            cb_Sn.Items.Clear();
            panel_Result.Visible = false;
            tb_AreaCode.Text = "AREA CODE";
            lbl_AreaCode.Text = "";
            tb_Desc.Text = "DESCRIPTION";
            lbl_Job.Text = "";
            tb_JobId.Text = "JOB ID";
            lbl_Desc.Text = "";
            tb_Sn.Text = "SERIAL NUMBER";
            butt_update.Visible = true;
        }

        private void deviceUpdate_Load(object sender, EventArgs e)
        {
            butt_update.Visible = false;
        }
        private void tb_Desc_MouseClick(object sender, MouseEventArgs e)
        {
            tb_Desc.Text = "";
        }

        private void tb_Desc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbl_Desc.Text = tb_Desc.Text.Trim();
            }
        }


        List<SigFoxDevice> updateDevice;
        private List<SigFoxDevice> UpdateEntries(List<SigFoxDevice> sigFox)
        {
            updateDevice = new List<SigFoxDevice>();
            for (int i = 0; i < sigFox.Count; i++)
            {
                string id = "";
                SigFoxDevice device = new SigFoxDevice();
                device.DeviceId = sigFox[i].DeviceId;
                device.SerialNumber = sigFox[i].SerialNumber;
                device.ProductionSerialNumber = sigFox[i].SerialNumber;
                if (!String.IsNullOrEmpty(lbl_AreaCode.Text))
                {
                    device.AreaCodeId = Convert.ToInt32(lbl_AreaCode.Text);
                }
                else
                {
                    device.AreaCodeId = sigFox[i].AreaCodeId;
                }
                device.DeviceStatusId = sigFox[i].DeviceStatusId;


                if (!String.IsNullOrEmpty(lbl_Job.Text))
                {
                    int Jobs = Convert.ToInt32(sigFox[i].ConfigJobId);
                    if (Jobs == 0)
                    {
                        Jobs = Convert.ToInt32(lbl_Job.Text.Trim());
                    }
                    else if (Jobs > 0)
                    {
                        Jobs = Convert.ToInt32(sigFox[i].ConfigJobId);
                    }
                    device.ConfigJobId = Jobs;

                }
                else
                {
                    device.ConfigJobId = sigFox[i].ConfigJobId;
                }
                string lpWan = sigFox[i].LpWanId.Trim();
                if (String.IsNullOrEmpty(lpWan))
                {
                    MessageBox.Show($"No LPWAN ID assigned to {sigFox[i].SerialNumber}");

                }
                else
                {
                    if (lpWan.Length == 8 && lpWan.StartsWith("0"))
                    {
                        // remove 0
                        id = lpWan.Substring(1, 7);
                    }
                    else if (lpWan.Length == 7)
                    {
                        id = lpWan;
                    }
                    else { id = ""; }
                    if (id.Length == 7)
                    {
                        device.LpWanId = id.ToUpper();
                    }
                }


                if (!String.IsNullOrEmpty(lbl_Desc.Text.Trim()))
                {


                    device.Description = lbl_Desc.Text.Trim();
                }
                else
                {
                    device.Description = "";
                }



                device.ProductTypeId = sigFox[i].ProductTypeId;


                updateDevice.Add(device);
            }
            return updateDevice;
        }

        private void butt_update_Click(object sender, EventArgs e)
        {
            updateDevice = UpdateEntries(sigFox);
            if (updateDevice.Count > 0)
            {
                sql.UpdateDevices(updateDevice);
                sigFox = new List<SigFoxDevice>();
                sigFox = sql.FetchDevices(sn);
                dg_Result.DataSource = sigFox;
                butt_update.Visible = false;
            }
        }

        private void tb_AreaCode_MouseClick(object sender, MouseEventArgs e)
        {
            tb_AreaCode.Text = "";

        }
        private void tb_AreaCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbl_AreaCode.Text = tb_AreaCode.Text.Trim();
            }
        }

        private void tb_JobId_MouseClick(object sender, MouseEventArgs e)
        {
            tb_JobId.Text = "";
        }

        private void tb_JobId_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbl_Job.Text = tb_JobId.Text.Trim();
            }
        }
    }
}

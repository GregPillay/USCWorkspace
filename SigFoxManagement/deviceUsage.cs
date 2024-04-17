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
    public partial class deviceUsage : UserControl
    {
        public deviceUsage()
        {
            InitializeComponent();
            defaultSettings();
            butt_Import.Enabled = false;
        }
        SQL sql;
        private void defaultSettings()
        {
            panel_Result.Visible = false;
            butt_Filter.Visible = false;
            cb_Sns.Visible = false;
            lbl_Comment.Text = "";
            tb_AreaCode.Text = "AREA CODE";
            lbl_AreaCode.Text = "";
        }

        private void butt_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text|*.txt*";
            cb_Sns.Visible = true;
            lbl_AreaCode.Text = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] sn = File.ReadAllLines(openFileDialog.FileName);
                cb_Sns.Items.Clear();
                for (int i = 0; i < sn.Length; i++)
                {
                    if (!String.IsNullOrEmpty(sn[i]) && sn[i].StartsWith("41"))
                    {
                        cb_Sns.Items.Add(sn[i]);
                    }

                }
                butt_Filter.Visible = true;
            }

            lbl_Comment.Text = $"{cb_Sns.Items.Count} Serial Numbers found";
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
                tb_AreaCode.Text = "Area Code";
                cb_Sns.Visible = false;
                cb_Sns.Items.Clear();
                butt_Filter.Visible = true;
            }
        }

        int AreaCode = 1110;
        List<SigFoxSkeleton> UUTList;
        List<string> Sn;
        private void butt_Filter_Click(object sender, EventArgs e)
        {

            if (cb_Sns.Items.Count > 0 && String.IsNullOrEmpty(lbl_AreaCode.Text))
            {
                // load sn filter
                //to do
            }
            else if (cb_Sns.Items.Count == 0 && !String.IsNullOrEmpty(lbl_AreaCode.Text))
            {
                // load area code filter
                try
                {
                    AreaCode = Convert.ToInt32(lbl_AreaCode.Text.Trim());
                    if (AreaCode != 1110)
                    {
                        // (1) Fetch Data

                        Sn = new List<string>();
                        sql = new SQL();
                        Sn = sql.FetchDevicesByAreaCodeId(AreaCode);  // fetch SN with Areacode
                        if (Sn.Count > 0)
                        {
                            cb_Sns.Items.Clear();
                            for (int i = 0; i < Sn.Count; i++)
                            {
                                cb_Sns.Items.Add(Sn[i]);
                            }
                            cb_Sns.Visible = true;
                            UUTList = new List<SigFoxSkeleton>();// works
                            UUTList = sql.FetchDeviceUsage(Sn);
                            if (UUTList.Count > 0)
                            {
                                TabulateEntries(UUTList);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Area Code Entered!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Invalid Area Code Entered!");
                }
            }
        }
        List<ReportModel> model;
        private void TabulateEntries(List<SigFoxSkeleton> uUTList)
        {
            TabularFormat formatTable = new TabularFormat();
            model = new List<ReportModel>();
            model = formatTable.CreateReportDataView(uUTList); // works
            if (model.Count > 0)
            {
                dg_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dg_Grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                dg_Grid.DataSource = model;
                panel_Grid.Visible = true;
                panel_Result.Visible = true;
            }
        }

        private void butt_export_Click(object sender, EventArgs e)
        {
            FileExport exportToExcel = new FileExport();
            //exportToExcel.ExportFileToExcel( dg_Grid);
            exportToExcel.ExportFile2Excel(dg_Grid);
        }
    }
}

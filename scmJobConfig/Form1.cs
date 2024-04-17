using ProductionSupport.MyLibrary.FileManager;
using ProductionSupport.MyLibrary.Models;
using ProductionSupport.MyLibrary.SQL;
using System.Data.SqlClient;

namespace scmJobConfig
{
    public partial class FormScm : Form
    {
        public FormScm()
        {
            InitializeComponent();
            lbl_Comment.Text = "";
        }
        List<scmConfig> getJobs;

        List<string> csvTestFile;
        List<string> Serials;

        string Status = "ERROR";

        csvExcelHandling textTocsv;
       
        private void butt_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "text|*.txt";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] sn = System.IO.File.ReadAllLines(fileDialog.FileName);
                Serials = new List<string>();
                foreach (string s in sn)
                {
                    if (!String.IsNullOrEmpty(s) && s.Length == 11 && s.StartsWith("41"))
                    {
                        // valid sn
                        Serials.Add(s);


                    }
                }
                if (Serials.Count > 0)
                {
                    LoadscmJobs(Serials);
                }
            }
            else
            {
                MessageBox.Show("Error Occurred. Process Aborted!");
            }
        }
     
        private void LoadscmJobs(List<string> serials)
        {
            getJobs = new List<scmConfig>();
            scmConfigQueries sql = new scmConfigQueries();
            getJobs = sql.FetchScmAssociatedJobs(serials);
            csvTestFile = new List<string>();
            csvTestFile = CreatecsvFormat(getJobs);

            textTocsv = new csvExcelHandling();
            Status = textTocsv.TextTocsvExcel(csvTestFile);
            lbl_Comment.Text = Status;
        }

        private List<string> CreatecsvFormat(List<scmConfig> getJobs)
        {
            List<string> results = new List<string>();
            foreach (var scmConfig in getJobs)
            {
                string csv = "";
                csv = scmConfig.SerialNumber + ";";
                for (int i = 0; i < scmConfig.Jobs.Count; i++)
                {
                    string job = "";
                    job = $"{scmConfig.Jobs[i].JobId}-{scmConfig.Jobs[i].JobName}-{scmConfig.Jobs[i].CaptureDateTime};";
                    csv += job;
                }
                results.Add(csv);
            }
            return results;


        }


    }
}
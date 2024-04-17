namespace SigFoxManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        bool deviceUsageVisible = false;
        bool deviceDeviceVisible = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            DefaultSettings();
        }

        private void DefaultSettings()
        {
            deviceUsageVisible = false;
            deviceDeviceVisible = false;
            lbl_DeviceQuery.ForeColor = Color.Black;
            lbl_deviceUsage.ForeColor = Color.Black;
            deviceUpdate1.Visible = false;
            deviceUsage1.Visible = false;
        }

        private void ManageUserInterfaces(bool deviceUsageVisible, bool deviceDeviceVisible)
        {
            if (deviceUsageVisible == false && deviceDeviceVisible == true)  // Device Details Visible
            {
                lbl_DeviceQuery.ForeColor = Color.Navy;
                deviceUpdate1.Visible = true;
            }
            else if (deviceUsageVisible == true && deviceDeviceVisible == false)  // Usage Details Visible
            {
                lbl_deviceUsage.ForeColor = Color.Navy;
                deviceUsage1.Visible = true;
            }
            else
            {
                DefaultSettings();
                MessageBox.Show("Forms Error!");
            }
        }

        private void lbl_DeviceQuery_Click(object sender, EventArgs e)
        {
            DefaultSettings();
            deviceDeviceVisible = true;
            ManageUserInterfaces(deviceUsageVisible, deviceDeviceVisible);

        }

        private void lbl_deviceUsage_Click(object sender, EventArgs e)
        {
            DefaultSettings();
            deviceUsageVisible = true;
            ManageUserInterfaces(deviceUsageVisible, deviceDeviceVisible);

        }
    }
}

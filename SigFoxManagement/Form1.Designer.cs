namespace SigFoxManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_form = new Panel();
            panel_interface = new Panel();
            deviceUpdate1 = new deviceUpdate();
            panel_Menu = new Panel();
            lbl_deviceUsage = new Label();
            lbl_DeviceQuery = new Label();
            deviceUsage1 = new deviceUsage();
            panel_form.SuspendLayout();
            panel_interface.SuspendLayout();
            panel_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // panel_form
            // 
            panel_form.Controls.Add(panel_interface);
            panel_form.Controls.Add(panel_Menu);
            panel_form.Dock = DockStyle.Fill;
            panel_form.Location = new Point(0, 0);
            panel_form.Name = "panel_form";
            panel_form.Size = new Size(536, 375);
            panel_form.TabIndex = 0;
            // 
            // panel_interface
            // 
            panel_interface.Controls.Add(deviceUsage1);
            panel_interface.Controls.Add(deviceUpdate1);
            panel_interface.Dock = DockStyle.Fill;
            panel_interface.Location = new Point(0, 33);
            panel_interface.Name = "panel_interface";
            panel_interface.Size = new Size(536, 342);
            panel_interface.TabIndex = 1;
            // 
            // deviceUpdate1
            // 
            deviceUpdate1.Dock = DockStyle.Fill;
            deviceUpdate1.Location = new Point(0, 0);
            deviceUpdate1.Name = "deviceUpdate1";
            deviceUpdate1.Size = new Size(536, 342);
            deviceUpdate1.TabIndex = 0;
            // 
            // panel_Menu
            // 
            panel_Menu.BackColor = SystemColors.GradientInactiveCaption;
            panel_Menu.Controls.Add(lbl_deviceUsage);
            panel_Menu.Controls.Add(lbl_DeviceQuery);
            panel_Menu.Dock = DockStyle.Top;
            panel_Menu.Location = new Point(0, 0);
            panel_Menu.Name = "panel_Menu";
            panel_Menu.Size = new Size(536, 33);
            panel_Menu.TabIndex = 0;
            // 
            // lbl_deviceUsage
            // 
            lbl_deviceUsage.AutoSize = true;
            lbl_deviceUsage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_deviceUsage.Location = new Point(204, 9);
            lbl_deviceUsage.Name = "lbl_deviceUsage";
            lbl_deviceUsage.Size = new Size(116, 21);
            lbl_deviceUsage.TabIndex = 2;
            lbl_deviceUsage.Text = "DEVICE USAGE";
            lbl_deviceUsage.Click += lbl_deviceUsage_Click;
            // 
            // lbl_DeviceQuery
            // 
            lbl_DeviceQuery.AutoSize = true;
            lbl_DeviceQuery.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_DeviceQuery.Location = new Point(41, 9);
            lbl_DeviceQuery.Name = "lbl_DeviceQuery";
            lbl_DeviceQuery.Size = new Size(117, 21);
            lbl_DeviceQuery.TabIndex = 1;
            lbl_DeviceQuery.Text = "DEVICE QUERY";
            lbl_DeviceQuery.Click += lbl_DeviceQuery_Click;
            // 
            // deviceUsage1
            // 
            deviceUsage1.BackColor = SystemColors.GradientActiveCaption;
            deviceUsage1.Dock = DockStyle.Fill;
            deviceUsage1.Location = new Point(0, 0);
            deviceUsage1.MaximumSize = new Size(536, 342);
            deviceUsage1.MinimumSize = new Size(536, 342);
            deviceUsage1.Name = "deviceUsage1";
            deviceUsage1.Size = new Size(536, 342);
            deviceUsage1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 375);
            Controls.Add(panel_form);
            Name = "Form1";
            Text = "SIGFOX MANAGEMENT";
            Load += Form1_Load;
            panel_form.ResumeLayout(false);
            panel_interface.ResumeLayout(false);
            panel_Menu.ResumeLayout(false);
            panel_Menu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_form;
        private Panel panel_interface;
        private Panel panel_Menu;
        private deviceUpdate deviceUpdate1;
        private Label lbl_DeviceQuery;
        private Label lbl_deviceUsage;
        private deviceUsage deviceUsage1;
    }
}
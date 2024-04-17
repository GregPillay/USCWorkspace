namespace SigFoxManagement
{
    partial class deviceUpdate
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            butt_update = new Button();
            panel_Result = new Panel();
            butt_reset = new Button();
            lbl_Job = new Label();
            tb_JobId = new TextBox();
            lbl_Desc = new Label();
            tb_Desc = new TextBox();
            lbl_AreaCode = new Label();
            tb_AreaCode = new TextBox();
            dg_Result = new DataGridView();
            butt_Search = new Button();
            cb_Sn = new ComboBox();
            butt_File = new Button();
            tb_Sn = new TextBox();
            panel_Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_Result).BeginInit();
            SuspendLayout();
            // 
            // butt_update
            // 
            butt_update.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            butt_update.Location = new Point(406, 3);
            butt_update.Name = "butt_update";
            butt_update.Size = new Size(127, 54);
            butt_update.TabIndex = 11;
            butt_update.Text = "UPDATE AND REFRESH";
            butt_update.UseVisualStyleBackColor = true;
            butt_update.Click += butt_update_Click;
            // 
            // panel_Result
            // 
            panel_Result.Controls.Add(butt_reset);
            panel_Result.Controls.Add(lbl_Job);
            panel_Result.Controls.Add(tb_JobId);
            panel_Result.Controls.Add(lbl_Desc);
            panel_Result.Controls.Add(tb_Desc);
            panel_Result.Controls.Add(lbl_AreaCode);
            panel_Result.Controls.Add(tb_AreaCode);
            panel_Result.Controls.Add(dg_Result);
            panel_Result.Location = new Point(3, 65);
            panel_Result.Name = "panel_Result";
            panel_Result.Size = new Size(530, 277);
            panel_Result.TabIndex = 10;
            // 
            // butt_reset
            // 
            butt_reset.FlatStyle = FlatStyle.Flat;
            butt_reset.ForeColor = Color.Red;
            butt_reset.Location = new Point(450, 251);
            butt_reset.Name = "butt_reset";
            butt_reset.Size = new Size(66, 23);
            butt_reset.TabIndex = 7;
            butt_reset.Text = "Reset";
            butt_reset.UseVisualStyleBackColor = true;
            butt_reset.Click += butt_reset_Click;
            // 
            // lbl_Job
            // 
            lbl_Job.AutoSize = true;
            lbl_Job.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_Job.Location = new Point(241, 238);
            lbl_Job.Name = "lbl_Job";
            lbl_Job.Size = new Size(15, 17);
            lbl_Job.TabIndex = 6;
            lbl_Job.Text = "x";
            // 
            // tb_JobId
            // 
            tb_JobId.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tb_JobId.Location = new Point(241, 201);
            tb_JobId.Name = "tb_JobId";
            tb_JobId.Size = new Size(89, 25);
            tb_JobId.TabIndex = 5;
            tb_JobId.Text = "JOB ID";
            tb_JobId.TextAlign = HorizontalAlignment.Center;
            tb_JobId.MouseClick += tb_JobId_MouseClick;
            tb_JobId.KeyDown += tb_JobId_KeyDown_1;
            // 
            // lbl_Desc
            // 
            lbl_Desc.AutoSize = true;
            lbl_Desc.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_Desc.Location = new Point(12, 238);
            lbl_Desc.Name = "lbl_Desc";
            lbl_Desc.Size = new Size(15, 17);
            lbl_Desc.TabIndex = 4;
            lbl_Desc.Text = "x";
            // 
            // tb_Desc
            // 
            tb_Desc.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tb_Desc.Location = new Point(12, 201);
            tb_Desc.Name = "tb_Desc";
            tb_Desc.Size = new Size(175, 25);
            tb_Desc.TabIndex = 3;
            tb_Desc.Text = "DESCRIPTION";
            tb_Desc.TextAlign = HorizontalAlignment.Center;
            tb_Desc.MouseClick += tb_Desc_MouseClick;
            tb_Desc.KeyDown += tb_Desc_KeyDown;
            // 
            // lbl_AreaCode
            // 
            lbl_AreaCode.AutoSize = true;
            lbl_AreaCode.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_AreaCode.Location = new Point(386, 238);
            lbl_AreaCode.Name = "lbl_AreaCode";
            lbl_AreaCode.Size = new Size(15, 17);
            lbl_AreaCode.TabIndex = 2;
            lbl_AreaCode.Text = "x";
            // 
            // tb_AreaCode
            // 
            tb_AreaCode.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tb_AreaCode.Location = new Point(386, 201);
            tb_AreaCode.Name = "tb_AreaCode";
            tb_AreaCode.Size = new Size(89, 25);
            tb_AreaCode.TabIndex = 1;
            tb_AreaCode.Text = "AREA CODE";
            tb_AreaCode.TextAlign = HorizontalAlignment.Center;
            tb_AreaCode.MouseClick += tb_AreaCode_MouseClick;
            tb_AreaCode.KeyDown += tb_AreaCode_KeyDown;
            // 
            // dg_Result
            // 
            dg_Result.AllowUserToAddRows = false;
            dg_Result.AllowUserToDeleteRows = false;
            dg_Result.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_Result.Location = new Point(0, 0);
            dg_Result.Name = "dg_Result";
            dg_Result.ReadOnly = true;
            dg_Result.RowTemplate.Height = 25;
            dg_Result.Size = new Size(527, 195);
            dg_Result.TabIndex = 0;
            // 
            // butt_Search
            // 
            butt_Search.Location = new Point(261, 34);
            butt_Search.Name = "butt_Search";
            butt_Search.Size = new Size(130, 25);
            butt_Search.TabIndex = 9;
            butt_Search.Text = "Search";
            butt_Search.UseVisualStyleBackColor = true;
            butt_Search.Click += butt_Search_Click;
            // 
            // cb_Sn
            // 
            cb_Sn.FormattingEnabled = true;
            cb_Sn.Location = new Point(24, 34);
            cb_Sn.Name = "cb_Sn";
            cb_Sn.Size = new Size(166, 23);
            cb_Sn.TabIndex = 8;
            // 
            // butt_File
            // 
            butt_File.BackColor = SystemColors.Control;
            butt_File.Location = new Point(24, 3);
            butt_File.Name = "butt_File";
            butt_File.Size = new Size(166, 25);
            butt_File.TabIndex = 7;
            butt_File.Text = "Load Serial Numbers";
            butt_File.UseVisualStyleBackColor = false;
            butt_File.Click += butt_File_Click;
            // 
            // tb_Sn
            // 
            tb_Sn.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            tb_Sn.Location = new Point(261, 3);
            tb_Sn.Name = "tb_Sn";
            tb_Sn.Size = new Size(130, 25);
            tb_Sn.TabIndex = 6;
            tb_Sn.Text = "Serial Number";
            tb_Sn.TextAlign = HorizontalAlignment.Center;
            tb_Sn.MouseClick += tb_Sn_MouseClick;
            tb_Sn.KeyDown += tb_Sn_KeyDown;
            // 
            // deviceUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(butt_update);
            Controls.Add(panel_Result);
            Controls.Add(butt_Search);
            Controls.Add(cb_Sn);
            Controls.Add(butt_File);
            Controls.Add(tb_Sn);
            Name = "deviceUpdate";
            Size = new Size(536, 342);
            Load += deviceUpdate_Load;
            panel_Result.ResumeLayout(false);
            panel_Result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dg_Result).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butt_update;
        private Panel panel_Result;
        private Button butt_reset;
        private Label lbl_Job;
        private TextBox tb_JobId;
        private Label lbl_Desc;
        private TextBox tb_Desc;
        private Label lbl_AreaCode;
        private TextBox tb_AreaCode;
        private DataGridView dg_Result;
        private Button butt_Search;
        private ComboBox cb_Sn;
        private Button butt_File;
        private TextBox tb_Sn;
    }
}

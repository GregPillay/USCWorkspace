namespace SigFoxManagement
{
    partial class deviceUsage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            butt_Filter = new Button();
            lbl_AreaCode = new Label();
            lbl_Comment = new Label();
            butt_Import = new Button();
            cb_Sns = new ComboBox();
            tb_AreaCode = new TextBox();
            label1 = new Label();
            panel_Result = new Panel();
            butt_export = new Button();
            panel_Grid = new Panel();
            dg_Grid = new DataGridView();
            panel1.SuspendLayout();
            panel_Result.SuspendLayout();
            panel_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_Grid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(butt_Filter);
            panel1.Controls.Add(lbl_AreaCode);
            panel1.Controls.Add(lbl_Comment);
            panel1.Controls.Add(butt_Import);
            panel1.Controls.Add(cb_Sns);
            panel1.Controls.Add(tb_AreaCode);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 342);
            panel1.TabIndex = 0;
            // 
            // butt_Filter
            // 
            butt_Filter.FlatStyle = FlatStyle.Flat;
            butt_Filter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butt_Filter.ForeColor = Color.DodgerBlue;
            butt_Filter.Location = new Point(10, 209);
            butt_Filter.Name = "butt_Filter";
            butt_Filter.Size = new Size(119, 35);
            butt_Filter.TabIndex = 3;
            butt_Filter.Text = "FILTER";
            butt_Filter.UseVisualStyleBackColor = true;
            butt_Filter.Click += butt_Filter_Click;
            // 
            // lbl_AreaCode
            // 
            lbl_AreaCode.AutoSize = true;
            lbl_AreaCode.ForeColor = Color.Purple;
            lbl_AreaCode.Location = new Point(52, 171);
            lbl_AreaCode.Name = "lbl_AreaCode";
            lbl_AreaCode.Size = new Size(25, 15);
            lbl_AreaCode.TabIndex = 6;
            lbl_AreaCode.Text = "187";
            // 
            // lbl_Comment
            // 
            lbl_Comment.AutoSize = true;
            lbl_Comment.ForeColor = Color.Olive;
            lbl_Comment.Location = new Point(10, 295);
            lbl_Comment.Name = "lbl_Comment";
            lbl_Comment.Size = new Size(128, 15);
            lbl_Comment.TabIndex = 2;
            lbl_Comment.Text = "7 serial numbers found";
            // 
            // butt_Import
            // 
            butt_Import.FlatStyle = FlatStyle.Flat;
            butt_Import.Location = new Point(12, 37);
            butt_Import.Name = "butt_Import";
            butt_Import.Size = new Size(117, 43);
            butt_Import.TabIndex = 0;
            butt_Import.Text = "LOAD SERIAL NUMBERS";
            butt_Import.UseVisualStyleBackColor = true;
            butt_Import.Click += butt_Import_Click;
            // 
            // cb_Sns
            // 
            cb_Sns.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Sns.FormattingEnabled = true;
            cb_Sns.Location = new Point(3, 3);
            cb_Sns.Name = "cb_Sns";
            cb_Sns.Size = new Size(135, 28);
            cb_Sns.TabIndex = 1;
            // 
            // tb_AreaCode
            // 
            tb_AreaCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            tb_AreaCode.Location = new Point(12, 133);
            tb_AreaCode.Name = "tb_AreaCode";
            tb_AreaCode.Size = new Size(117, 25);
            tb_AreaCode.TabIndex = 5;
            tb_AreaCode.Text = "AREA CODE";
            tb_AreaCode.TextAlign = HorizontalAlignment.Center;
            tb_AreaCode.MouseClick += tb_AreaCode_MouseClick;
            tb_AreaCode.KeyDown += tb_AreaCode_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(33, 100);
            label1.Name = "label1";
            label1.Size = new Size(70, 17);
            label1.TabIndex = 4;
            label1.Text = "<< OR >>";
            // 
            // panel_Result
            // 
            panel_Result.BackColor = SystemColors.GradientInactiveCaption;
            panel_Result.BorderStyle = BorderStyle.FixedSingle;
            panel_Result.Controls.Add(butt_export);
            panel_Result.Controls.Add(panel_Grid);
            panel_Result.Dock = DockStyle.Fill;
            panel_Result.Location = new Point(141, 0);
            panel_Result.Name = "panel_Result";
            panel_Result.Size = new Size(395, 342);
            panel_Result.TabIndex = 1;
            // 
            // butt_export
            // 
            butt_export.FlatStyle = FlatStyle.Flat;
            butt_export.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            butt_export.ForeColor = Color.DarkBlue;
            butt_export.Location = new Point(97, 308);
            butt_export.Name = "butt_export";
            butt_export.Size = new Size(205, 33);
            butt_export.TabIndex = 2;
            butt_export.Text = "EXPORT DATA TO EXCEL";
            butt_export.UseVisualStyleBackColor = true;
            butt_export.Click += butt_export_Click;
            // 
            // panel_Grid
            // 
            panel_Grid.Controls.Add(dg_Grid);
            panel_Grid.Dock = DockStyle.Top;
            panel_Grid.Location = new Point(0, 0);
            panel_Grid.Name = "panel_Grid";
            panel_Grid.Size = new Size(393, 309);
            panel_Grid.TabIndex = 1;
            // 
            // dg_Grid
            // 
            dg_Grid.AllowUserToAddRows = false;
            dg_Grid.AllowUserToDeleteRows = false;
            dg_Grid.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dg_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dg_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dg_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            dg_Grid.Dock = DockStyle.Fill;
            dg_Grid.Location = new Point(0, 0);
            dg_Grid.Name = "dg_Grid";
            dg_Grid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dg_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dg_Grid.RowTemplate.Height = 25;
            dg_Grid.Size = new Size(393, 309);
            dg_Grid.TabIndex = 0;
            // 
            // deviceUsage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(panel_Result);
            Controls.Add(panel1);
            MaximumSize = new Size(536, 342);
            MinimumSize = new Size(536, 342);
            Name = "deviceUsage";
            Size = new Size(536, 342);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_Result.ResumeLayout(false);
            panel_Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_Grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button butt_Import;
        private Panel panel_Result;
        private Label lbl_Comment;
        private ComboBox cb_Sns;
        private Button butt_Filter;
        private Label lbl_AreaCode;
        private TextBox tb_AreaCode;
        private Label label1;
        private Button butt_export;
        private Panel panel_Grid;
        private DataGridView dg_Grid;
    }
}

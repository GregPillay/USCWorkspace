namespace scmJobConfig
{
    partial class FormScm
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
            panel_Home = new Panel();
            lbl_Comment = new Label();
            butt_Import = new Button();
            panel_Home.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Home
            // 
            panel_Home.Controls.Add(lbl_Comment);
            panel_Home.Controls.Add(butt_Import);
            panel_Home.Dock = DockStyle.Top;
            panel_Home.Location = new Point(0, 0);
            panel_Home.Name = "panel_Home";
            panel_Home.Size = new Size(350, 79);
            panel_Home.TabIndex = 0;
            panel_Home.UseWaitCursor = true;
            // 
            // lbl_Comment
            // 
            lbl_Comment.AutoSize = true;
            lbl_Comment.ForeColor = Color.FromArgb(0, 0, 192);
            lbl_Comment.Location = new Point(12, 57);
            lbl_Comment.Name = "lbl_Comment";
            lbl_Comment.Size = new Size(67, 15);
            lbl_Comment.TabIndex = 1;
            lbl_Comment.Text = "COMMENT";
            lbl_Comment.UseWaitCursor = true;
            // 
            // butt_Import
            // 
            butt_Import.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            butt_Import.Location = new Point(49, 12);
            butt_Import.Name = "butt_Import";
            butt_Import.Size = new Size(234, 38);
            butt_Import.TabIndex = 0;
            butt_Import.Text = "IMPORT SERIAL NUMBERS";
            butt_Import.UseVisualStyleBackColor = true;
            butt_Import.UseWaitCursor = true;
            butt_Import.Click += butt_Import_Click;
            // 
            // FormScm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 82);
            Controls.Add(panel_Home);
            Name = "FormScm";
            Text = "SCM CONFIG QUERY";
            UseWaitCursor = true;
            panel_Home.ResumeLayout(false);
            panel_Home.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Home;
        private Label lbl_Comment;
        private Button butt_Import;
    }
}
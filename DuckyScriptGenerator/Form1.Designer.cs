namespace DuckyScriptGenerator
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
            cbDownloadFile = new CheckBox();
            cbExecuteFile = new CheckBox();
            FileBox = new GroupBox();
            txtDeleteFile = new TextBox();
            cbDeleteFile = new CheckBox();
            txtDownloadFilePath = new TextBox();
            txtDownloadFileURL = new TextBox();
            txtExecuteFile = new TextBox();
            TitleBox = new GroupBox();
            ProfileBox = new GroupBox();
            btnImportProfile = new Button();
            btnExportProfile = new Button();
            btnDeleteProfile = new Button();
            btnRenameProfile = new Button();
            cbProfiles = new ComboBox();
            btnLoadProfile = new Button();
            btnSaveProfile = new Button();
            TitleText = new TextBox();
            OutputBox = new GroupBox();
            btnGenerateDS = new Button();
            btnSaveDS = new Button();
            txtOutput = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            FileBox.SuspendLayout();
            TitleBox.SuspendLayout();
            ProfileBox.SuspendLayout();
            OutputBox.SuspendLayout();
            SuspendLayout();
            // 
            // cbDownloadFile
            // 
            cbDownloadFile.AutoSize = true;
            cbDownloadFile.Location = new Point(6, 47);
            cbDownloadFile.Name = "cbDownloadFile";
            cbDownloadFile.Size = new Size(101, 19);
            cbDownloadFile.TabIndex = 0;
            cbDownloadFile.Text = "Download File";
            cbDownloadFile.UseVisualStyleBackColor = true;
            cbDownloadFile.CheckedChanged += cbDownloadFile_CheckedChanged;
            // 
            // cbExecuteFile
            // 
            cbExecuteFile.AutoSize = true;
            cbExecuteFile.Location = new Point(6, 22);
            cbExecuteFile.Name = "cbExecuteFile";
            cbExecuteFile.Size = new Size(88, 19);
            cbExecuteFile.TabIndex = 1;
            cbExecuteFile.Text = "Execute File";
            cbExecuteFile.UseVisualStyleBackColor = true;
            cbExecuteFile.CheckedChanged += cbExecuteFile_CheckedChanged;
            // 
            // FileBox
            // 
            FileBox.BackColor = SystemColors.Control;
            FileBox.Controls.Add(txtDeleteFile);
            FileBox.Controls.Add(cbDeleteFile);
            FileBox.Controls.Add(txtDownloadFilePath);
            FileBox.Controls.Add(txtDownloadFileURL);
            FileBox.Controls.Add(txtExecuteFile);
            FileBox.Controls.Add(cbExecuteFile);
            FileBox.Controls.Add(cbDownloadFile);
            FileBox.Location = new Point(12, 118);
            FileBox.Name = "FileBox";
            FileBox.Size = new Size(470, 132);
            FileBox.TabIndex = 2;
            FileBox.TabStop = false;
            FileBox.Text = "FILE STUFF";
            // 
            // txtDeleteFile
            // 
            txtDeleteFile.Enabled = false;
            txtDeleteFile.Location = new Point(92, 103);
            txtDeleteFile.Name = "txtDeleteFile";
            txtDeleteFile.Size = new Size(351, 23);
            txtDeleteFile.TabIndex = 5;
            txtDeleteFile.Text = "Path To File";
            // 
            // cbDeleteFile
            // 
            cbDeleteFile.AutoSize = true;
            cbDeleteFile.Location = new Point(6, 105);
            cbDeleteFile.Name = "cbDeleteFile";
            cbDeleteFile.Size = new Size(80, 19);
            cbDeleteFile.TabIndex = 5;
            cbDeleteFile.Text = "Delete File";
            cbDeleteFile.UseVisualStyleBackColor = true;
            cbDeleteFile.CheckedChanged += cbDeleteFile_CheckedChanged;
            // 
            // txtDownloadFilePath
            // 
            txtDownloadFilePath.Enabled = false;
            txtDownloadFilePath.Location = new Point(113, 74);
            txtDownloadFilePath.Name = "txtDownloadFilePath";
            txtDownloadFilePath.Size = new Size(330, 23);
            txtDownloadFilePath.TabIndex = 4;
            txtDownloadFilePath.Text = "Path To Place File";
            // 
            // txtDownloadFileURL
            // 
            txtDownloadFileURL.Enabled = false;
            txtDownloadFileURL.Location = new Point(113, 51);
            txtDownloadFileURL.Name = "txtDownloadFileURL";
            txtDownloadFileURL.Size = new Size(330, 23);
            txtDownloadFileURL.TabIndex = 3;
            txtDownloadFileURL.Text = "URL To Download";
            // 
            // txtExecuteFile
            // 
            txtExecuteFile.Enabled = false;
            txtExecuteFile.Location = new Point(100, 22);
            txtExecuteFile.Name = "txtExecuteFile";
            txtExecuteFile.Size = new Size(343, 23);
            txtExecuteFile.TabIndex = 2;
            txtExecuteFile.Text = "Path To Executable";
            // 
            // TitleBox
            // 
            TitleBox.Controls.Add(ProfileBox);
            TitleBox.Controls.Add(TitleText);
            TitleBox.Dock = DockStyle.Top;
            TitleBox.Location = new Point(0, 0);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(821, 100);
            TitleBox.TabIndex = 3;
            TitleBox.TabStop = false;
            // 
            // ProfileBox
            // 
            ProfileBox.Controls.Add(btnImportProfile);
            ProfileBox.Controls.Add(btnExportProfile);
            ProfileBox.Controls.Add(btnDeleteProfile);
            ProfileBox.Controls.Add(btnRenameProfile);
            ProfileBox.Controls.Add(cbProfiles);
            ProfileBox.Controls.Add(btnLoadProfile);
            ProfileBox.Controls.Add(btnSaveProfile);
            ProfileBox.Dock = DockStyle.Right;
            ProfileBox.Location = new Point(565, 19);
            ProfileBox.Name = "ProfileBox";
            ProfileBox.Size = new Size(253, 78);
            ProfileBox.TabIndex = 8;
            ProfileBox.TabStop = false;
            ProfileBox.Text = "PROFILES";
            // 
            // btnImportProfile
            // 
            btnImportProfile.Location = new Point(191, 7);
            btnImportProfile.Name = "btnImportProfile";
            btnImportProfile.Size = new Size(62, 23);
            btnImportProfile.TabIndex = 12;
            btnImportProfile.Text = "IMPORT";
            btnImportProfile.UseVisualStyleBackColor = true;
            btnImportProfile.Click += btnImportProfile_Click;
            // 
            // btnExportProfile
            // 
            btnExportProfile.Location = new Point(191, 31);
            btnExportProfile.Name = "btnExportProfile";
            btnExportProfile.Size = new Size(62, 23);
            btnExportProfile.TabIndex = 11;
            btnExportProfile.Text = "EXPORT";
            btnExportProfile.UseVisualStyleBackColor = true;
            btnExportProfile.Click += btnExportProfile_Click;
            // 
            // btnDeleteProfile
            // 
            btnDeleteProfile.Location = new Point(192, 60);
            btnDeleteProfile.Name = "btnDeleteProfile";
            btnDeleteProfile.Size = new Size(61, 23);
            btnDeleteProfile.TabIndex = 10;
            btnDeleteProfile.Text = "DELETE";
            btnDeleteProfile.UseVisualStyleBackColor = true;
            btnDeleteProfile.Click += btnDeleteProfile_Click;
            // 
            // btnRenameProfile
            // 
            btnRenameProfile.Location = new Point(122, 60);
            btnRenameProfile.Name = "btnRenameProfile";
            btnRenameProfile.Size = new Size(63, 23);
            btnRenameProfile.TabIndex = 9;
            btnRenameProfile.Text = "RENAME";
            btnRenameProfile.UseVisualStyleBackColor = true;
            btnRenameProfile.Click += btnRenameProfile_Click;
            // 
            // cbProfiles
            // 
            cbProfiles.FormattingEnabled = true;
            cbProfiles.Location = new Point(12, 22);
            cbProfiles.Name = "cbProfiles";
            cbProfiles.Size = new Size(173, 23);
            cbProfiles.TabIndex = 8;
            // 
            // btnLoadProfile
            // 
            btnLoadProfile.Location = new Point(64, 60);
            btnLoadProfile.Name = "btnLoadProfile";
            btnLoadProfile.Size = new Size(52, 23);
            btnLoadProfile.TabIndex = 6;
            btnLoadProfile.Text = "LOAD";
            btnLoadProfile.UseVisualStyleBackColor = true;
            btnLoadProfile.Click += btnLoadProfile_Click;
            // 
            // btnSaveProfile
            // 
            btnSaveProfile.Location = new Point(6, 60);
            btnSaveProfile.Name = "btnSaveProfile";
            btnSaveProfile.Size = new Size(52, 23);
            btnSaveProfile.TabIndex = 7;
            btnSaveProfile.Text = "SAVE";
            btnSaveProfile.UseVisualStyleBackColor = true;
            btnSaveProfile.Click += btnSaveProfile_Click;
            // 
            // TitleText
            // 
            TitleText.BackColor = SystemColors.Menu;
            TitleText.BorderStyle = BorderStyle.None;
            TitleText.Dock = DockStyle.Fill;
            TitleText.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point);
            TitleText.Location = new Point(3, 19);
            TitleText.Name = "TitleText";
            TitleText.Size = new Size(815, 58);
            TitleText.TabIndex = 0;
            TitleText.Text = "DuckyScript Generator";
            // 
            // OutputBox
            // 
            OutputBox.Controls.Add(btnGenerateDS);
            OutputBox.Controls.Add(btnSaveDS);
            OutputBox.Controls.Add(txtOutput);
            OutputBox.Dock = DockStyle.Right;
            OutputBox.Location = new Point(488, 100);
            OutputBox.Name = "OutputBox";
            OutputBox.Size = new Size(333, 575);
            OutputBox.TabIndex = 4;
            OutputBox.TabStop = false;
            OutputBox.Text = "OUTPUT";
            // 
            // btnGenerateDS
            // 
            btnGenerateDS.Location = new Point(174, 0);
            btnGenerateDS.Name = "btnGenerateDS";
            btnGenerateDS.Size = new Size(75, 22);
            btnGenerateDS.TabIndex = 4;
            btnGenerateDS.Text = "GENERATE";
            btnGenerateDS.UseVisualStyleBackColor = true;
            btnGenerateDS.Click += btnGenerateDS_Click;
            // 
            // btnSaveDS
            // 
            btnSaveDS.Location = new Point(255, 0);
            btnSaveDS.Name = "btnSaveDS";
            btnSaveDS.Size = new Size(75, 22);
            btnSaveDS.TabIndex = 5;
            btnSaveDS.Text = "SAVE";
            btnSaveDS.UseVisualStyleBackColor = true;
            btnSaveDS.Click += btnSaveDC_Click;
            // 
            // txtOutput
            // 
            txtOutput.Dock = DockStyle.Fill;
            txtOutput.Location = new Point(3, 19);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(327, 553);
            txtOutput.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 256);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 148);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "STAGE 3";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(12, 410);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 148);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "STAGE 4 (Exfil)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 675);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(OutputBox);
            Controls.Add(TitleBox);
            Controls.Add(FileBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            FileBox.ResumeLayout(false);
            FileBox.PerformLayout();
            TitleBox.ResumeLayout(false);
            TitleBox.PerformLayout();
            ProfileBox.ResumeLayout(false);
            OutputBox.ResumeLayout(false);
            OutputBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox cbDownloadFile;
        private CheckBox cbExecuteFile;
        private GroupBox FileBox;
        private GroupBox TitleBox;
        private TextBox TitleText;
        private GroupBox OutputBox;
        private TextBox txtDownloadFileURL;
        private TextBox txtExecuteFile;
        private Button btnSaveDS;
        private TextBox txtOutput;
        private Button btnGenerateDS;
        private TextBox txtDownloadFilePath;
        private TextBox txtDeleteFile;
        private CheckBox cbDeleteFile;
        private GroupBox groupBox1;
        private GroupBox ProfileBox;
        private ComboBox cbProfiles;
        private Button btnLoadProfile;
        private Button btnSaveProfile;
        private Button btnRenameProfile;
        private Button btnExportProfile;
        private Button btnDeleteProfile;
        private Button btnImportProfile;
        private GroupBox groupBox2;
    }
}
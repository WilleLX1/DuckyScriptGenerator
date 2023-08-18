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
            txtFILEDeleteFile = new TextBox();
            cbDeleteFile = new CheckBox();
            txtFILEDownloadFilePath = new TextBox();
            txtFILEDownloadFileURL = new TextBox();
            txtFILEExecuteFile = new TextBox();
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
            txtGATHERoutputFile = new TextBox();
            cbWiFiPasswords = new CheckBox();
            groupBox2 = new GroupBox();
            txtEXFILPostReqFileToSend = new TextBox();
            cbPostRequest = new CheckBox();
            txtEXFILWebhookFileToSend = new TextBox();
            txtEXFILWebhookTOKEN = new TextBox();
            cbDiscordWebhook = new CheckBox();
            FileBox.SuspendLayout();
            TitleBox.SuspendLayout();
            ProfileBox.SuspendLayout();
            OutputBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cbDownloadFile
            // 
            cbDownloadFile.AutoSize = true;
            cbDownloadFile.Location = new Point(7, 63);
            cbDownloadFile.Margin = new Padding(3, 4, 3, 4);
            cbDownloadFile.Name = "cbDownloadFile";
            cbDownloadFile.Size = new Size(127, 24);
            cbDownloadFile.TabIndex = 0;
            cbDownloadFile.Text = "Download File";
            cbDownloadFile.UseVisualStyleBackColor = true;
            cbDownloadFile.CheckedChanged += cbDownloadFile_CheckedChanged;
            // 
            // cbExecuteFile
            // 
            cbExecuteFile.AutoSize = true;
            cbExecuteFile.Location = new Point(7, 29);
            cbExecuteFile.Margin = new Padding(3, 4, 3, 4);
            cbExecuteFile.Name = "cbExecuteFile";
            cbExecuteFile.Size = new Size(109, 24);
            cbExecuteFile.TabIndex = 1;
            cbExecuteFile.Text = "Execute File";
            cbExecuteFile.UseVisualStyleBackColor = true;
            cbExecuteFile.CheckedChanged += cbExecuteFile_CheckedChanged;
            // 
            // FileBox
            // 
            FileBox.BackColor = SystemColors.Control;
            FileBox.Controls.Add(txtFILEDeleteFile);
            FileBox.Controls.Add(cbDeleteFile);
            FileBox.Controls.Add(txtFILEDownloadFilePath);
            FileBox.Controls.Add(txtFILEDownloadFileURL);
            FileBox.Controls.Add(txtFILEExecuteFile);
            FileBox.Controls.Add(cbExecuteFile);
            FileBox.Controls.Add(cbDownloadFile);
            FileBox.Location = new Point(14, 157);
            FileBox.Margin = new Padding(3, 4, 3, 4);
            FileBox.Name = "FileBox";
            FileBox.Padding = new Padding(3, 4, 3, 4);
            FileBox.Size = new Size(537, 176);
            FileBox.TabIndex = 2;
            FileBox.TabStop = false;
            FileBox.Text = "FILE STUFF (STAGE 1/2)";
            // 
            // txtFILEDeleteFile
            // 
            txtFILEDeleteFile.Enabled = false;
            txtFILEDeleteFile.Location = new Point(105, 137);
            txtFILEDeleteFile.Margin = new Padding(3, 4, 3, 4);
            txtFILEDeleteFile.Name = "txtFILEDeleteFile";
            txtFILEDeleteFile.Size = new Size(425, 27);
            txtFILEDeleteFile.TabIndex = 5;
            txtFILEDeleteFile.Text = "PATH To File";
            txtFILEDeleteFile.TextChanged += txtFILEDeleteFile_TextChanged;
            // 
            // cbDeleteFile
            // 
            cbDeleteFile.AutoSize = true;
            cbDeleteFile.Location = new Point(7, 140);
            cbDeleteFile.Margin = new Padding(3, 4, 3, 4);
            cbDeleteFile.Name = "cbDeleteFile";
            cbDeleteFile.Size = new Size(102, 24);
            cbDeleteFile.TabIndex = 5;
            cbDeleteFile.Text = "Delete File";
            cbDeleteFile.UseVisualStyleBackColor = true;
            cbDeleteFile.CheckedChanged += cbDeleteFile_CheckedChanged;
            // 
            // txtFILEDownloadFilePath
            // 
            txtFILEDownloadFilePath.Enabled = false;
            txtFILEDownloadFilePath.Location = new Point(129, 99);
            txtFILEDownloadFilePath.Margin = new Padding(3, 4, 3, 4);
            txtFILEDownloadFilePath.Name = "txtFILEDownloadFilePath";
            txtFILEDownloadFilePath.Size = new Size(401, 27);
            txtFILEDownloadFilePath.TabIndex = 4;
            txtFILEDownloadFilePath.Text = "Path To Place File";
            txtFILEDownloadFilePath.TextChanged += txtFILEDownloadFilePath_TextChanged;
            // 
            // txtFILEDownloadFileURL
            // 
            txtFILEDownloadFileURL.Enabled = false;
            txtFILEDownloadFileURL.Location = new Point(129, 68);
            txtFILEDownloadFileURL.Margin = new Padding(3, 4, 3, 4);
            txtFILEDownloadFileURL.Name = "txtFILEDownloadFileURL";
            txtFILEDownloadFileURL.Size = new Size(401, 27);
            txtFILEDownloadFileURL.TabIndex = 3;
            txtFILEDownloadFileURL.Text = "URL To Download";
            txtFILEDownloadFileURL.TextChanged += txtFILEDownloadFileURL_TextChanged;
            // 
            // txtFILEExecuteFile
            // 
            txtFILEExecuteFile.Enabled = false;
            txtFILEExecuteFile.Location = new Point(114, 27);
            txtFILEExecuteFile.Margin = new Padding(3, 4, 3, 4);
            txtFILEExecuteFile.Name = "txtFILEExecuteFile";
            txtFILEExecuteFile.Size = new Size(415, 27);
            txtFILEExecuteFile.TabIndex = 2;
            txtFILEExecuteFile.Text = "PATH To Executable";
            txtFILEExecuteFile.TextChanged += txtFILEExecuteFile_TextChanged;
            // 
            // TitleBox
            // 
            TitleBox.Controls.Add(ProfileBox);
            TitleBox.Controls.Add(TitleText);
            TitleBox.Dock = DockStyle.Top;
            TitleBox.Location = new Point(0, 0);
            TitleBox.Margin = new Padding(3, 4, 3, 4);
            TitleBox.Name = "TitleBox";
            TitleBox.Padding = new Padding(3, 4, 3, 4);
            TitleBox.Size = new Size(938, 133);
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
            ProfileBox.Location = new Point(646, 24);
            ProfileBox.Margin = new Padding(3, 4, 3, 4);
            ProfileBox.Name = "ProfileBox";
            ProfileBox.Padding = new Padding(3, 4, 3, 4);
            ProfileBox.Size = new Size(289, 105);
            ProfileBox.TabIndex = 8;
            ProfileBox.TabStop = false;
            ProfileBox.Text = "PROFILES";
            // 
            // btnImportProfile
            // 
            btnImportProfile.Location = new Point(218, 9);
            btnImportProfile.Margin = new Padding(3, 4, 3, 4);
            btnImportProfile.Name = "btnImportProfile";
            btnImportProfile.Size = new Size(71, 31);
            btnImportProfile.TabIndex = 12;
            btnImportProfile.Text = "IMPORT";
            btnImportProfile.UseVisualStyleBackColor = true;
            btnImportProfile.Click += btnImportProfile_Click;
            // 
            // btnExportProfile
            // 
            btnExportProfile.Location = new Point(218, 41);
            btnExportProfile.Margin = new Padding(3, 4, 3, 4);
            btnExportProfile.Name = "btnExportProfile";
            btnExportProfile.Size = new Size(71, 31);
            btnExportProfile.TabIndex = 11;
            btnExportProfile.Text = "EXPORT";
            btnExportProfile.UseVisualStyleBackColor = true;
            btnExportProfile.Click += btnExportProfile_Click;
            // 
            // btnDeleteProfile
            // 
            btnDeleteProfile.Location = new Point(219, 80);
            btnDeleteProfile.Margin = new Padding(3, 4, 3, 4);
            btnDeleteProfile.Name = "btnDeleteProfile";
            btnDeleteProfile.Size = new Size(70, 31);
            btnDeleteProfile.TabIndex = 10;
            btnDeleteProfile.Text = "DELETE";
            btnDeleteProfile.UseVisualStyleBackColor = true;
            btnDeleteProfile.Click += btnDeleteProfile_Click;
            // 
            // btnRenameProfile
            // 
            btnRenameProfile.Location = new Point(139, 80);
            btnRenameProfile.Margin = new Padding(3, 4, 3, 4);
            btnRenameProfile.Name = "btnRenameProfile";
            btnRenameProfile.Size = new Size(72, 31);
            btnRenameProfile.TabIndex = 9;
            btnRenameProfile.Text = "RENAME";
            btnRenameProfile.UseVisualStyleBackColor = true;
            btnRenameProfile.Click += btnRenameProfile_Click;
            // 
            // cbProfiles
            // 
            cbProfiles.FormattingEnabled = true;
            cbProfiles.Location = new Point(14, 29);
            cbProfiles.Margin = new Padding(3, 4, 3, 4);
            cbProfiles.Name = "cbProfiles";
            cbProfiles.Size = new Size(197, 28);
            cbProfiles.TabIndex = 8;
            // 
            // btnLoadProfile
            // 
            btnLoadProfile.Location = new Point(73, 80);
            btnLoadProfile.Margin = new Padding(3, 4, 3, 4);
            btnLoadProfile.Name = "btnLoadProfile";
            btnLoadProfile.Size = new Size(59, 31);
            btnLoadProfile.TabIndex = 6;
            btnLoadProfile.Text = "LOAD";
            btnLoadProfile.UseVisualStyleBackColor = true;
            btnLoadProfile.Click += btnLoadProfile_Click;
            // 
            // btnSaveProfile
            // 
            btnSaveProfile.Location = new Point(7, 80);
            btnSaveProfile.Margin = new Padding(3, 4, 3, 4);
            btnSaveProfile.Name = "btnSaveProfile";
            btnSaveProfile.Size = new Size(59, 31);
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
            TitleText.Location = new Point(3, 24);
            TitleText.Margin = new Padding(3, 4, 3, 4);
            TitleText.Name = "TitleText";
            TitleText.Size = new Size(932, 72);
            TitleText.TabIndex = 0;
            TitleText.Text = "DuckyScript Generator";
            // 
            // OutputBox
            // 
            OutputBox.Controls.Add(btnGenerateDS);
            OutputBox.Controls.Add(btnSaveDS);
            OutputBox.Controls.Add(txtOutput);
            OutputBox.Dock = DockStyle.Right;
            OutputBox.Location = new Point(557, 133);
            OutputBox.Margin = new Padding(3, 4, 3, 4);
            OutputBox.Name = "OutputBox";
            OutputBox.Padding = new Padding(3, 4, 3, 4);
            OutputBox.Size = new Size(381, 767);
            OutputBox.TabIndex = 4;
            OutputBox.TabStop = false;
            OutputBox.Text = "OUTPUT";
            // 
            // btnGenerateDS
            // 
            btnGenerateDS.Location = new Point(199, 0);
            btnGenerateDS.Margin = new Padding(3, 4, 3, 4);
            btnGenerateDS.Name = "btnGenerateDS";
            btnGenerateDS.Size = new Size(86, 29);
            btnGenerateDS.TabIndex = 4;
            btnGenerateDS.Text = "GENERATE";
            btnGenerateDS.UseVisualStyleBackColor = true;
            btnGenerateDS.Click += btnGenerateDS_Click;
            // 
            // btnSaveDS
            // 
            btnSaveDS.Location = new Point(291, 0);
            btnSaveDS.Margin = new Padding(3, 4, 3, 4);
            btnSaveDS.Name = "btnSaveDS";
            btnSaveDS.Size = new Size(86, 29);
            btnSaveDS.TabIndex = 5;
            btnSaveDS.Text = "SAVE";
            btnSaveDS.UseVisualStyleBackColor = true;
            btnSaveDS.Click += btnSaveDC_Click;
            // 
            // txtOutput
            // 
            txtOutput.Dock = DockStyle.Fill;
            txtOutput.Location = new Point(3, 24);
            txtOutput.Margin = new Padding(3, 4, 3, 4);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(375, 739);
            txtOutput.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGATHERoutputFile);
            groupBox1.Controls.Add(cbWiFiPasswords);
            groupBox1.Location = new Point(14, 341);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(537, 197);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "GATHER (STAGE 3)";
            // 
            // txtGATHERoutputFile
            // 
            txtGATHERoutputFile.Enabled = false;
            txtGATHERoutputFile.Location = new Point(144, 28);
            txtGATHERoutputFile.Name = "txtGATHERoutputFile";
            txtGATHERoutputFile.Size = new Size(385, 27);
            txtGATHERoutputFile.TabIndex = 6;
            txtGATHERoutputFile.Text = "PATH To Place Output";
            txtGATHERoutputFile.TextChanged += txtGATHERoutputFile_TextChanged;
            // 
            // cbWiFiPasswords
            // 
            cbWiFiPasswords.AutoSize = true;
            cbWiFiPasswords.Location = new Point(7, 28);
            cbWiFiPasswords.Margin = new Padding(3, 4, 3, 4);
            cbWiFiPasswords.Name = "cbWiFiPasswords";
            cbWiFiPasswords.Size = new Size(131, 24);
            cbWiFiPasswords.TabIndex = 5;
            cbWiFiPasswords.Text = "WiFi Passwords";
            cbWiFiPasswords.UseVisualStyleBackColor = true;
            cbWiFiPasswords.CheckedChanged += cbWiFiPasswords_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEXFILPostReqFileToSend);
            groupBox2.Controls.Add(cbPostRequest);
            groupBox2.Controls.Add(txtEXFILWebhookFileToSend);
            groupBox2.Controls.Add(txtEXFILWebhookTOKEN);
            groupBox2.Controls.Add(cbDiscordWebhook);
            groupBox2.Location = new Point(14, 547);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(537, 197);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "EXFIL (STAGE 4)";
            // 
            // txtEXFILPostReqFileToSend
            // 
            txtEXFILPostReqFileToSend.Enabled = false;
            txtEXFILPostReqFileToSend.Location = new Point(121, 92);
            txtEXFILPostReqFileToSend.Margin = new Padding(3, 4, 3, 4);
            txtEXFILPostReqFileToSend.Name = "txtEXFILPostReqFileToSend";
            txtEXFILPostReqFileToSend.Size = new Size(409, 27);
            txtEXFILPostReqFileToSend.TabIndex = 4;
            txtEXFILPostReqFileToSend.Text = "PATH to File to Send (.CSV)";
            txtEXFILPostReqFileToSend.TextChanged += txtEXFILPostReqFileToSend_TextChanged;
            // 
            // cbPostRequest
            // 
            cbPostRequest.AutoSize = true;
            cbPostRequest.Location = new Point(7, 92);
            cbPostRequest.Margin = new Padding(3, 4, 3, 4);
            cbPostRequest.Name = "cbPostRequest";
            cbPostRequest.Size = new Size(115, 24);
            cbPostRequest.TabIndex = 3;
            cbPostRequest.Text = "Post Request";
            cbPostRequest.UseVisualStyleBackColor = true;
            cbPostRequest.CheckedChanged += cbPostRequest_CheckedChanged;
            // 
            // txtEXFILWebhookFileToSend
            // 
            txtEXFILWebhookFileToSend.Enabled = false;
            txtEXFILWebhookFileToSend.Location = new Point(151, 53);
            txtEXFILWebhookFileToSend.Margin = new Padding(3, 4, 3, 4);
            txtEXFILWebhookFileToSend.Name = "txtEXFILWebhookFileToSend";
            txtEXFILWebhookFileToSend.Size = new Size(379, 27);
            txtEXFILWebhookFileToSend.TabIndex = 2;
            txtEXFILWebhookFileToSend.Text = "PATH to File to Send";
            txtEXFILWebhookFileToSend.TextChanged += txtEXFILWebhookFileToSend_TextChanged;
            // 
            // txtEXFILWebhookTOKEN
            // 
            txtEXFILWebhookTOKEN.Enabled = false;
            txtEXFILWebhookTOKEN.Location = new Point(151, 27);
            txtEXFILWebhookTOKEN.Margin = new Padding(3, 4, 3, 4);
            txtEXFILWebhookTOKEN.Name = "txtEXFILWebhookTOKEN";
            txtEXFILWebhookTOKEN.Size = new Size(379, 27);
            txtEXFILWebhookTOKEN.TabIndex = 1;
            txtEXFILWebhookTOKEN.Text = "WEBHOOK TOKEN";
            txtEXFILWebhookTOKEN.TextChanged += txtEXFILWebhookTOKEN_TextChanged;
            // 
            // cbDiscordWebhook
            // 
            cbDiscordWebhook.AutoSize = true;
            cbDiscordWebhook.Location = new Point(7, 29);
            cbDiscordWebhook.Margin = new Padding(3, 4, 3, 4);
            cbDiscordWebhook.Name = "cbDiscordWebhook";
            cbDiscordWebhook.Size = new Size(149, 24);
            cbDiscordWebhook.TabIndex = 0;
            cbDiscordWebhook.Text = "Discord Webhook";
            cbDiscordWebhook.UseVisualStyleBackColor = true;
            cbDiscordWebhook.CheckedChanged += cbDiscordWebhook_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 900);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(OutputBox);
            Controls.Add(TitleBox);
            Controls.Add(FileBox);
            Margin = new Padding(3, 4, 3, 4);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox cbDownloadFile;
        private CheckBox cbExecuteFile;
        private GroupBox FileBox;
        private GroupBox TitleBox;
        private TextBox TitleText;
        private GroupBox OutputBox;
        private TextBox txtFILEDownloadFileURL;
        private TextBox txtFILEExecuteFile;
        private Button btnSaveDS;
        private TextBox txtOutput;
        private Button btnGenerateDS;
        private TextBox txtFILEDownloadFilePath;
        private TextBox txtFILEDeleteFile;
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
        private CheckBox cbDiscordWebhook;
        private TextBox txtEXFILWebhookTOKEN;
        private TextBox txtEXFILWebhookFileToSend;
        private CheckBox cbPostRequest;
        private TextBox txtEXFILPostReqFileToSend;
        private TextBox txtGATHERoutputFile;
        private CheckBox cbWiFiPasswords;
    }
}
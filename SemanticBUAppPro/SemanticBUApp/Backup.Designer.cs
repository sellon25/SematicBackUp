namespace SemanticBUApp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_targetPath = new System.Windows.Forms.TextBox();
            this.btn_browseFolders = new System.Windows.Forms.Button();
            this.btn_fetchFiles = new System.Windows.Forms.Button();
            this.tb_customBUname = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_vids = new System.Windows.Forms.CheckBox();
            this.cb_docs = new System.Windows.Forms.CheckBox();
            this.cb_pics = new System.Windows.Forms.CheckBox();
            this.cb_audios = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbBuNamesOnly = new System.Windows.Forms.Label();
            this.lbBackupSize = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbImages = new System.Windows.Forms.Label();
            this.lbDocuments = new System.Windows.Forms.Label();
            this.lbVideos = new System.Windows.Forms.Label();
            this.lbAudios = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btn_StartBackup = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_lan = new System.Windows.Forms.CheckBox();
            this.cbCloud = new System.Windows.Forms.CheckBox();
            this.cbLocal = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.urls = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.backupFile = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelLoading = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectoryPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fetchDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fetchDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(373, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Custom backup file name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Save Backup to";
            // 
            // tb_targetPath
            // 
            this.tb_targetPath.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_targetPath.Location = new System.Drawing.Point(374, 452);
            this.tb_targetPath.Multiline = true;
            this.tb_targetPath.Name = "tb_targetPath";
            this.tb_targetPath.Size = new System.Drawing.Size(171, 23);
            this.tb_targetPath.TabIndex = 4;
            // 
            // btn_browseFolders
            // 
            this.btn_browseFolders.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browseFolders.Location = new System.Drawing.Point(560, 452);
            this.btn_browseFolders.Name = "btn_browseFolders";
            this.btn_browseFolders.Size = new System.Drawing.Size(112, 23);
            this.btn_browseFolders.TabIndex = 5;
            this.btn_browseFolders.Text = "Browse Folders";
            this.btn_browseFolders.UseVisualStyleBackColor = true;
            this.btn_browseFolders.Click += new System.EventHandler(this.btn_browseFolders_Click);
            // 
            // btn_fetchFiles
            // 
            this.btn_fetchFiles.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fetchFiles.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_fetchFiles.Location = new System.Drawing.Point(22, 299);
            this.btn_fetchFiles.Name = "btn_fetchFiles";
            this.btn_fetchFiles.Size = new System.Drawing.Size(139, 41);
            this.btn_fetchFiles.TabIndex = 6;
            this.btn_fetchFiles.Text = "Scan PC";
            this.btn_fetchFiles.UseVisualStyleBackColor = true;
            this.btn_fetchFiles.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_customBUname
            // 
            this.tb_customBUname.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_customBUname.Location = new System.Drawing.Point(374, 405);
            this.tb_customBUname.Multiline = true;
            this.tb_customBUname.Name = "tb_customBUname";
            this.tb_customBUname.Size = new System.Drawing.Size(171, 23);
            this.tb_customBUname.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_vids);
            this.groupBox1.Controls.Add(this.cb_docs);
            this.groupBox1.Controls.Add(this.cb_pics);
            this.groupBox1.Controls.Add(this.cb_audios);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 147);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formats";
            // 
            // cb_vids
            // 
            this.cb_vids.AutoSize = true;
            this.cb_vids.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_vids.Location = new System.Drawing.Point(18, 113);
            this.cb_vids.Name = "cb_vids";
            this.cb_vids.Size = new System.Drawing.Size(71, 21);
            this.cb_vids.TabIndex = 3;
            this.cb_vids.Text = "Videos";
            this.cb_vids.UseVisualStyleBackColor = true;
            this.cb_vids.CheckedChanged += new System.EventHandler(this.cb_vids_CheckedChanged);
            // 
            // cb_docs
            // 
            this.cb_docs.AutoSize = true;
            this.cb_docs.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_docs.Location = new System.Drawing.Point(18, 88);
            this.cb_docs.Name = "cb_docs";
            this.cb_docs.Size = new System.Drawing.Size(103, 21);
            this.cb_docs.TabIndex = 2;
            this.cb_docs.Text = "Documents";
            this.cb_docs.UseVisualStyleBackColor = true;
            this.cb_docs.CheckedChanged += new System.EventHandler(this.cb_docs_CheckedChanged);
            // 
            // cb_pics
            // 
            this.cb_pics.AutoSize = true;
            this.cb_pics.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pics.Location = new System.Drawing.Point(18, 63);
            this.cb_pics.Name = "cb_pics";
            this.cb_pics.Size = new System.Drawing.Size(81, 21);
            this.cb_pics.TabIndex = 1;
            this.cb_pics.Text = "Pictures";
            this.cb_pics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_pics.UseVisualStyleBackColor = true;
            this.cb_pics.CheckedChanged += new System.EventHandler(this.cb_pics_CheckedChanged);
            // 
            // cb_audios
            // 
            this.cb_audios.AutoSize = true;
            this.cb_audios.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_audios.Location = new System.Drawing.Point(18, 38);
            this.cb_audios.Name = "cb_audios";
            this.cb_audios.Size = new System.Drawing.Size(71, 21);
            this.cb_audios.TabIndex = 0;
            this.cb_audios.Text = "Audios";
            this.cb_audios.UseVisualStyleBackColor = true;
            this.cb_audios.CheckedChanged += new System.EventHandler(this.cb_audios_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(34, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 34);
            this.label6.TabIndex = 13;
            this.label6.Text = "Semantic Backup";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbBuNamesOnly);
            this.groupBox2.Controls.Add(this.lbBackupSize);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 116);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analyzing Complete";
            // 
            // lbBuNamesOnly
            // 
            this.lbBuNamesOnly.AutoSize = true;
            this.lbBuNamesOnly.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuNamesOnly.Location = new System.Drawing.Point(213, 73);
            this.lbBuNamesOnly.Name = "lbBuNamesOnly";
            this.lbBuNamesOnly.Size = new System.Drawing.Size(32, 18);
            this.lbBuNamesOnly.TabIndex = 3;
            this.lbBuNamesOnly.Text = "0MB";
            this.lbBuNamesOnly.Click += new System.EventHandler(this.lbBuNamesOnly_Click);
            // 
            // lbBackupSize
            // 
            this.lbBackupSize.AutoSize = true;
            this.lbBackupSize.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBackupSize.Location = new System.Drawing.Point(213, 41);
            this.lbBackupSize.Name = "lbBackupSize";
            this.lbBackupSize.Size = new System.Drawing.Size(32, 18);
            this.lbBackupSize.TabIndex = 2;
            this.lbBackupSize.Text = "0MB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Data name backup only:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Files allegible for backup:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbImages);
            this.groupBox3.Controls.Add(this.lbDocuments);
            this.groupBox3.Controls.Add(this.lbVideos);
            this.groupBox3.Controls.Add(this.lbAudios);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1051, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 147);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            // 
            // lbImages
            // 
            this.lbImages.AutoSize = true;
            this.lbImages.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImages.Location = new System.Drawing.Point(100, 112);
            this.lbImages.Name = "lbImages";
            this.lbImages.Size = new System.Drawing.Size(32, 18);
            this.lbImages.TabIndex = 7;
            this.lbImages.Text = "0MB";
            // 
            // lbDocuments
            // 
            this.lbDocuments.AutoSize = true;
            this.lbDocuments.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocuments.Location = new System.Drawing.Point(100, 88);
            this.lbDocuments.Name = "lbDocuments";
            this.lbDocuments.Size = new System.Drawing.Size(32, 18);
            this.lbDocuments.TabIndex = 6;
            this.lbDocuments.Text = "0MB";
            // 
            // lbVideos
            // 
            this.lbVideos.AutoSize = true;
            this.lbVideos.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVideos.Location = new System.Drawing.Point(100, 63);
            this.lbVideos.Name = "lbVideos";
            this.lbVideos.Size = new System.Drawing.Size(32, 18);
            this.lbVideos.TabIndex = 5;
            this.lbVideos.Text = "0MB";
            // 
            // lbAudios
            // 
            this.lbAudios.AutoSize = true;
            this.lbAudios.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAudios.Location = new System.Drawing.Point(100, 38);
            this.lbAudios.Name = "lbAudios";
            this.lbAudios.Size = new System.Drawing.Size(32, 18);
            this.lbAudios.TabIndex = 4;
            this.lbAudios.Text = "0MB";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 18);
            this.label15.TabIndex = 3;
            this.label15.Text = "Images:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 18);
            this.label14.TabIndex = 2;
            this.label14.Text = "Documents:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "Videos:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Music:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(940, 63);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(35, 15);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "User";
            // 
            // btn_StartBackup
            // 
            this.btn_StartBackup.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartBackup.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_StartBackup.Location = new System.Drawing.Point(1067, 446);
            this.btn_StartBackup.Name = "btn_StartBackup";
            this.btn_StartBackup.Size = new System.Drawing.Size(139, 41);
            this.btn_StartBackup.TabIndex = 18;
            this.btn_StartBackup.Text = " Start Backup";
            this.btn_StartBackup.UseVisualStyleBackColor = true;
            this.btn_StartBackup.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_lan);
            this.groupBox4.Controls.Add(this.cbCloud);
            this.groupBox4.Controls.Add(this.cbLocal);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1054, 347);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 93);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Store";
            // 
            // cb_lan
            // 
            this.cb_lan.AutoSize = true;
            this.cb_lan.Location = new System.Drawing.Point(32, 68);
            this.cb_lan.Name = "cb_lan";
            this.cb_lan.Size = new System.Drawing.Size(47, 19);
            this.cb_lan.TabIndex = 2;
            this.cb_lan.Text = "LAN";
            this.cb_lan.UseVisualStyleBackColor = true;
            this.cb_lan.CheckedChanged += new System.EventHandler(this.cb_lan_CheckedChanged);
            // 
            // cbCloud
            // 
            this.cbCloud.AutoSize = true;
            this.cbCloud.Location = new System.Drawing.Point(32, 47);
            this.cbCloud.Name = "cbCloud";
            this.cbCloud.Size = new System.Drawing.Size(110, 19);
            this.cbCloud.TabIndex = 1;
            this.cbCloud.Text = "Google Drive";
            this.cbCloud.UseVisualStyleBackColor = true;
            this.cbCloud.CheckedChanged += new System.EventHandler(this.cbCloud_CheckedChanged);
            // 
            // cbLocal
            // 
            this.cbLocal.AutoSize = true;
            this.cbLocal.Location = new System.Drawing.Point(32, 22);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(61, 19);
            this.cbLocal.TabIndex = 0;
            this.cbLocal.Text = "Local";
            this.cbLocal.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(1067, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "Archive Backups";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(1166, 24);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 16);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // urls
            // 
            this.urls.DataPropertyName = "urls";
            this.urls.HeaderText = "Urls";
            this.urls.Name = "urls";
            this.urls.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnView
            // 
            this.btnView.DataPropertyName = "btnView";
            this.btnView.HeaderText = "Youtube Results";
            this.btnView.Name = "btnView";
            this.btnView.ReadOnly = true;
            this.btnView.Text = "View";
            this.btnView.UseColumnTextForButtonValue = true;
            // 
            // backupFile
            // 
            this.backupFile.DataPropertyName = "backupFile";
            this.backupFile.HeaderText = "Back up";
            this.backupFile.Name = "backupFile";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.Type,
            this.dataGridViewTextBoxColumn3,
            this.DirectoryPath,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.lastUpdatedDataGridViewTextBoxColumn,
            this.backupFile,
            this.urls,
            this.btnView});
            this.dataGridView2.DataSource = this.fetchDataBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(167, 113);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(878, 252);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbldate.Location = new System.Drawing.Point(811, 431);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(42, 16);
            this.lbldate.TabIndex = 24;
            this.lbldate.Text = "Date: ";
            this.lbldate.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTimer.Location = new System.Drawing.Point(879, 431);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(44, 16);
            this.lblTimer.TabIndex = 25;
            this.lblTimer.Text = "Time: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelLoading.Location = new System.Drawing.Point(539, 236);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(93, 24);
            this.labelLoading.TabIndex = 26;
            this.labelLoading.Text = "Loading...";
            this.labelLoading.Visible = false;
            // 
            // fileName
            // 
            this.fileName.DataPropertyName = "Name";
            this.fileName.HeaderText = "Name";
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Size";
            this.dataGridViewTextBoxColumn3.HeaderText = "Size";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // DirectoryPath
            // 
            this.DirectoryPath.DataPropertyName = "DirectoryPath";
            this.DirectoryPath.HeaderText = "DirectoryPath";
            this.DirectoryPath.Name = "DirectoryPath";
            this.DirectoryPath.ReadOnly = true;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastUpdatedDataGridViewTextBoxColumn
            // 
            this.lastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.HeaderText = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.Name = "lastUpdatedDataGridViewTextBoxColumn";
            this.lastUpdatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fetchDataBindingSource
            // 
            this.fetchDataBindingSource.DataSource = typeof(SemanticBUApp.FetchData);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 532);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_StartBackup);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_fetchFiles);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_customBUname);
            this.Controls.Add(this.btn_browseFolders);
            this.Controls.Add(this.tb_targetPath);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fetchDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource fileDetailsBindingSource;
        private System.Windows.Forms.BindingSource fileDetailsBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fileDetailsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastWriteTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btb_getFiles;
        private System.Windows.Forms.TextBox tb_CustomFileName;
        private System.Windows.Forms.TextBox tb_TargetDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_BrowseDisk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_targetPath;
        private System.Windows.Forms.Button btn_browseFolders;
        private System.Windows.Forms.Button btn_fetchFiles;
        private System.Windows.Forms.TextBox tb_customBUname;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_vids;
        private System.Windows.Forms.CheckBox cb_docs;
        private System.Windows.Forms.CheckBox cb_pics;
        private System.Windows.Forms.CheckBox cb_audios;
        private System.Windows.Forms.BindingSource fetchDataBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lbBuNamesOnly;
        private System.Windows.Forms.Label lbBackupSize;
        private System.Windows.Forms.Label lbImages;
        private System.Windows.Forms.Label lbDocuments;
        private System.Windows.Forms.Label lbVideos;
        private System.Windows.Forms.Label lbAudios;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_StartBackup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbCloud;
        private System.Windows.Forms.CheckBox cbLocal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewComboBoxColumn urls;
        private System.Windows.Forms.DataGridViewButtonColumn btnView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn backupFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectoryPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.CheckBox cb_lan;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelLoading;
    }
}


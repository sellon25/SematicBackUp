namespace SemanticBUApp
{
    partial class Archives
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvArchive = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.semanticBackupDataSet = new SemanticBUApp.SemanticBackupDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.dgvFetchData = new System.Windows.Forms.DataGridView();
            this.urls = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.historyTableAdapter = new SemanticBUApp.SemanticBackupDataSetTableAdapters.HistoryTableAdapter();
            this.btnViewH = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directoryPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backupFileDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fetchDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backupFileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semanticBackupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFetchData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fetchDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupFileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup History";
            // 
            // dgvArchive
            // 
            this.dgvArchive.AutoGenerateColumns = false;
            this.dgvArchive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArchive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn,
            this.Date});
            this.dgvArchive.DataSource = this.historyBindingSource;
            this.dgvArchive.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvArchive.Location = new System.Drawing.Point(29, 62);
            this.dgvArchive.Name = "dgvArchive";
            this.dgvArchive.ReadOnly = true;
            this.dgvArchive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArchive.Size = new System.Drawing.Size(589, 160);
            this.dgvArchive.TabIndex = 1;
            this.dgvArchive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArchive_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "History";
            this.historyBindingSource.DataSource = this.semanticBackupDataSet;
            // 
            // semanticBackupDataSet
            // 
            this.semanticBackupDataSet.DataSetName = "SemanticBackupDataSet";
            this.semanticBackupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(819, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(716, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(29, 13);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "User";
            // 
            // dgvFetchData
            // 
            this.dgvFetchData.AutoGenerateColumns = false;
            this.dgvFetchData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFetchData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn1,
            this.directoryPathDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.lastUpdatedDataGridViewTextBoxColumn,
            this.backupFileDataGridViewCheckBoxColumn,
            this.urls});
            this.dgvFetchData.DataSource = this.fetchDataBindingSource;
            this.dgvFetchData.Location = new System.Drawing.Point(30, 228);
            this.dgvFetchData.Name = "dgvFetchData";
            this.dgvFetchData.Size = new System.Drawing.Size(906, 204);
            this.dgvFetchData.TabIndex = 4;
            this.dgvFetchData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFetchData_CellContentClick);
            // 
            // urls
            // 
            this.urls.DataPropertyName = "urls";
            this.urls.HeaderText = "urls";
            this.urls.Name = "urls";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(642, 165);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 30);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear all Archive";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(642, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 30);
            this.button4.TabIndex = 7;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // btnViewH
            // 
            this.btnViewH.Location = new System.Drawing.Point(642, 93);
            this.btnViewH.Name = "btnViewH";
            this.btnViewH.Size = new System.Drawing.Size(103, 30);
            this.btnViewH.TabIndex = 8;
            this.btnViewH.Text = "View";
            this.btnViewH.UseVisualStyleBackColor = true;
            this.btnViewH.Click += new System.EventHandler(this.btnViewH_Click);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn1
            // 
            this.sizeDataGridViewTextBoxColumn1.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn1.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn1.Name = "sizeDataGridViewTextBoxColumn1";
            // 
            // directoryPathDataGridViewTextBoxColumn
            // 
            this.directoryPathDataGridViewTextBoxColumn.DataPropertyName = "DirectoryPath";
            this.directoryPathDataGridViewTextBoxColumn.HeaderText = "DirectoryPath";
            this.directoryPathDataGridViewTextBoxColumn.Name = "directoryPathDataGridViewTextBoxColumn";
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            // 
            // lastUpdatedDataGridViewTextBoxColumn
            // 
            this.lastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.HeaderText = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.Name = "lastUpdatedDataGridViewTextBoxColumn";
            // 
            // backupFileDataGridViewCheckBoxColumn
            // 
            this.backupFileDataGridViewCheckBoxColumn.DataPropertyName = "backupFile";
            this.backupFileDataGridViewCheckBoxColumn.HeaderText = "backupFile";
            this.backupFileDataGridViewCheckBoxColumn.Name = "backupFileDataGridViewCheckBoxColumn";
            // 
            // fetchDataBindingSource
            // 
            this.fetchDataBindingSource.DataSource = typeof(SemanticBUApp.FetchData);
            // 
            // backupFileBindingSource
            // 
            this.backupFileBindingSource.DataSource = typeof(SemanticBUApp.LocalBackupFile);
            this.backupFileBindingSource.CurrentChanged += new System.EventHandler(this.backupFileBindingSource_CurrentChanged);
            // 
            // Archives
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 493);
            this.Controls.Add(this.btnViewH);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvFetchData);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvArchive);
            this.Controls.Add(this.label1);
            this.Name = "Archives";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archives";
            this.Load += new System.EventHandler(this.Archives_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semanticBackupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFetchData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fetchDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backupFileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvArchive;
        private System.Windows.Forms.BindingSource backupFileBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DataGridView dgvFetchData;
        private System.Windows.Forms.BindingSource fetchDataBindingSource;     
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn directoryPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn backupFileDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn urls;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button4;
        private SemanticBackupDataSet semanticBackupDataSet;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private SemanticBackupDataSetTableAdapters.HistoryTableAdapter historyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button btnViewH;
    }
}
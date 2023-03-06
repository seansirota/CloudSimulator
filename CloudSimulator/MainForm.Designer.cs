using System.Windows.Forms;

namespace CloudSimulator
{
    partial class MainForm
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
            label1 = new Label();
            BTNCreateResource = new Button();
            BTNDeleteResource = new Button();
            BTNEditResource = new Button();
            BTNSelectAll = new Button();
            GRDResource = new DataGridView();
            SelectResource = new DataGridViewCheckBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            InstanceName = new DataGridViewTextBoxColumn();
            CPUCores = new DataGridViewTextBoxColumn();
            Memory = new DataGridViewTextBoxColumn();
            TempStorageType = new DataGridViewTextBoxColumn();
            TempStorageSize = new DataGridViewTextBoxColumn();
            GPUCores = new DataGridViewTextBoxColumn();
            ClockSpeed = new DataGridViewTextBoxColumn();
            NetworkSpeed = new DataGridViewTextBoxColumn();
            IOSpeed = new DataGridViewTextBoxColumn();
            StorageType = new DataGridViewTextBoxColumn();
            StorageSize = new DataGridViewTextBoxColumn();
            OperatingSystem = new DataGridViewTextBoxColumn();
            Transactions = new DataGridViewTextBoxColumn();
            BackupStorageType = new DataGridViewTextBoxColumn();
            BackupStorageSize = new DataGridViewTextBoxColumn();
            HoursUsed = new DataGridViewTextBoxColumn();
            HourCost = new DataGridViewTextBoxColumn();
            MonthCost = new DataGridViewTextBoxColumn();
            CBXView = new ComboBox();
            BTNExport = new Button();
            BTNImport = new Button();
            BTNCostAnalysis = new Button();
            FDGExport = new SaveFileDialog();
            FDGImport = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)GRDResource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(591, 29);
            label1.Name = "label1";
            label1.Size = new Size(524, 76);
            label1.TabIndex = 0;
            label1.Text = "Cloud Simulator";
            // 
            // BTNCreateResource
            // 
            BTNCreateResource.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BTNCreateResource.Location = new Point(232, 130);
            BTNCreateResource.Name = "BTNCreateResource";
            BTNCreateResource.Size = new Size(199, 40);
            BTNCreateResource.TabIndex = 1;
            BTNCreateResource.Text = "Create Resource";
            BTNCreateResource.UseVisualStyleBackColor = true;
            BTNCreateResource.Click += CreateButton_Click;
            // 
            // BTNDeleteResource
            // 
            BTNDeleteResource.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BTNDeleteResource.Location = new Point(437, 130);
            BTNDeleteResource.Name = "BTNDeleteResource";
            BTNDeleteResource.Size = new Size(199, 40);
            BTNDeleteResource.TabIndex = 2;
            BTNDeleteResource.Text = "Delete Resource(s)";
            BTNDeleteResource.UseVisualStyleBackColor = true;
            BTNDeleteResource.Click += BTNDeleteResource_Click;
            // 
            // BTNEditResource
            // 
            BTNEditResource.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BTNEditResource.Location = new Point(642, 130);
            BTNEditResource.Name = "BTNEditResource";
            BTNEditResource.Size = new Size(199, 40);
            BTNEditResource.TabIndex = 3;
            BTNEditResource.Text = "Edit Resource";
            BTNEditResource.UseVisualStyleBackColor = true;
            BTNEditResource.Click += EditButton_Click;
            // 
            // BTNSelectAll
            // 
            BTNSelectAll.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BTNSelectAll.Location = new Point(27, 130);
            BTNSelectAll.Name = "BTNSelectAll";
            BTNSelectAll.Size = new Size(199, 40);
            BTNSelectAll.TabIndex = 4;
            BTNSelectAll.Text = "Select All Rows";
            BTNSelectAll.UseVisualStyleBackColor = true;
            BTNSelectAll.Click += BTNSelectAll_Click;
            // 
            // GRDResource
            // 
            GRDResource.AllowUserToAddRows = false;
            GRDResource.AllowUserToDeleteRows = false;
            GRDResource.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GRDResource.Columns.AddRange(new DataGridViewColumn[] { SelectResource, ID, Type, InstanceName, CPUCores, Memory, TempStorageType, TempStorageSize, GPUCores, ClockSpeed, NetworkSpeed, IOSpeed, StorageType, StorageSize, OperatingSystem, Transactions, BackupStorageType, BackupStorageSize, HoursUsed, HourCost, MonthCost });
            GRDResource.Location = new Point(27, 179);
            GRDResource.Name = "GRDResource";
            GRDResource.RowTemplate.Height = 25;
            GRDResource.Size = new Size(1652, 841);
            GRDResource.TabIndex = 5;
            GRDResource.CurrentCellDirtyStateChanged += GRDResource_CurrentCellDirtyStateChanged;
            // 
            // SelectResource
            // 
            SelectResource.HeaderText = "Select Resources";
            SelectResource.Name = "SelectResource";
            SelectResource.Width = 80;
            // 
            // ID
            // 
            ID.HeaderText = "Resource ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 75;
            // 
            // Type
            // 
            Type.HeaderText = "Resource Type";
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // InstanceName
            // 
            InstanceName.HeaderText = "Instance Name";
            InstanceName.Name = "InstanceName";
            InstanceName.ReadOnly = true;
            InstanceName.Width = 75;
            // 
            // CPUCores
            // 
            CPUCores.HeaderText = "CPU Cores";
            CPUCores.Name = "CPUCores";
            CPUCores.ReadOnly = true;
            CPUCores.Width = 75;
            // 
            // Memory
            // 
            Memory.HeaderText = "RAM (GB)";
            Memory.Name = "Memory";
            Memory.ReadOnly = true;
            Memory.Width = 75;
            // 
            // TempStorageType
            // 
            TempStorageType.HeaderText = "Temporary Storage Type";
            TempStorageType.Name = "TempStorageType";
            TempStorageType.ReadOnly = true;
            TempStorageType.Width = 75;
            // 
            // TempStorageSize
            // 
            TempStorageSize.HeaderText = "Temporary Storage (GB)";
            TempStorageSize.Name = "TempStorageSize";
            TempStorageSize.ReadOnly = true;
            TempStorageSize.Width = 75;
            // 
            // GPUCores
            // 
            GPUCores.HeaderText = "GPU Cores";
            GPUCores.Name = "GPUCores";
            GPUCores.ReadOnly = true;
            GPUCores.Width = 75;
            // 
            // ClockSpeed
            // 
            ClockSpeed.HeaderText = "Clock Speed (GHz)";
            ClockSpeed.Name = "ClockSpeed";
            ClockSpeed.ReadOnly = true;
            ClockSpeed.Width = 75;
            // 
            // NetworkSpeed
            // 
            NetworkSpeed.HeaderText = "Network Speed (GBpS)";
            NetworkSpeed.Name = "NetworkSpeed";
            NetworkSpeed.ReadOnly = true;
            NetworkSpeed.Width = 75;
            // 
            // IOSpeed
            // 
            IOSpeed.HeaderText = "I/O Speed (GBpS)";
            IOSpeed.Name = "IOSpeed";
            IOSpeed.ReadOnly = true;
            IOSpeed.Width = 75;
            // 
            // StorageType
            // 
            StorageType.HeaderText = "External Storage Type";
            StorageType.Name = "StorageType";
            StorageType.ReadOnly = true;
            StorageType.Width = 75;
            // 
            // StorageSize
            // 
            StorageSize.HeaderText = "External Storage (GB)";
            StorageSize.Name = "StorageSize";
            StorageSize.ReadOnly = true;
            StorageSize.Width = 75;
            // 
            // OperatingSystem
            // 
            OperatingSystem.HeaderText = "Operating System";
            OperatingSystem.Name = "OperatingSystem";
            OperatingSystem.ReadOnly = true;
            OperatingSystem.Width = 75;
            // 
            // Transactions
            // 
            Transactions.HeaderText = "Read / Write Operations";
            Transactions.Name = "Transactions";
            Transactions.ReadOnly = true;
            Transactions.Width = 75;
            // 
            // BackupStorageType
            // 
            BackupStorageType.HeaderText = "Backup Storage Type";
            BackupStorageType.Name = "BackupStorageType";
            BackupStorageType.ReadOnly = true;
            BackupStorageType.Width = 75;
            // 
            // BackupStorageSize
            // 
            BackupStorageSize.HeaderText = "Backup Storage (GB)";
            BackupStorageSize.Name = "BackupStorageSize";
            BackupStorageSize.ReadOnly = true;
            BackupStorageSize.Width = 75;
            // 
            // HoursUsed
            // 
            HoursUsed.HeaderText = "Hours Used";
            HoursUsed.Name = "HoursUsed";
            HoursUsed.ReadOnly = true;
            HoursUsed.Width = 75;
            // 
            // HourCost
            // 
            HourCost.HeaderText = "Cost per Hour ($)";
            HourCost.Name = "HourCost";
            HourCost.ReadOnly = true;
            HourCost.Width = 75;
            // 
            // MonthCost
            // 
            MonthCost.HeaderText = "Cost per Month ($)";
            MonthCost.Name = "MonthCost";
            MonthCost.ReadOnly = true;
            MonthCost.Width = 75;
            // 
            // CBXView
            // 
            CBXView.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXView.Font = new Font("Helvetica", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CBXView.FormattingEnabled = true;
            CBXView.Location = new Point(847, 134);
            CBXView.Name = "CBXView";
            CBXView.Size = new Size(184, 33);
            CBXView.TabIndex = 6;
            CBXView.SelectedIndexChanged += ViewComboBox_SelectedIndexChanged;
            // 
            // BTNExport
            // 
            BTNExport.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BTNExport.Location = new Point(1480, 130);
            BTNExport.Name = "BTNExport";
            BTNExport.Size = new Size(199, 40);
            BTNExport.TabIndex = 7;
            BTNExport.Text = "Export";
            BTNExport.UseVisualStyleBackColor = true;
            BTNExport.Click += BTNExport_Click;
            // 
            // BTNImport
            // 
            BTNImport.Enabled = false;
            BTNImport.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BTNImport.Location = new Point(1275, 130);
            BTNImport.Name = "BTNImport";
            BTNImport.Size = new Size(199, 40);
            BTNImport.TabIndex = 8;
            BTNImport.Text = "Import";
            BTNImport.UseVisualStyleBackColor = true;
            BTNImport.Click += BTNImport_Click;
            // 
            // BTNCostAnalysis
            // 
            BTNCostAnalysis.Enabled = false;
            BTNCostAnalysis.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BTNCostAnalysis.Location = new Point(1070, 130);
            BTNCostAnalysis.Name = "BTNCostAnalysis";
            BTNCostAnalysis.Size = new Size(199, 40);
            BTNCostAnalysis.TabIndex = 9;
            BTNCostAnalysis.Text = "Cost Analysis";
            BTNCostAnalysis.UseVisualStyleBackColor = true;
            // 
            // FDGExport
            // 
            FDGExport.DefaultExt = "csv";
            FDGExport.Filter = "csv files (*.csv)|*.csv";
            FDGExport.InitialDirectory = "C:\\";
            FDGExport.Title = "Export data to a CSV file.";
            // 
            // FDGImport
            // 
            FDGImport.DefaultExt = "csv";
            FDGImport.FileName = "openFileDialog1";
            FDGImport.Filter = "csv files (*.csv)|*.csv";
            FDGImport.InitialDirectory = "C:\\";
            FDGImport.Title = "Open CSV file to import.";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1706, 1032);
            Controls.Add(BTNCostAnalysis);
            Controls.Add(BTNImport);
            Controls.Add(BTNExport);
            Controls.Add(CBXView);
            Controls.Add(GRDResource);
            Controls.Add(BTNSelectAll);
            Controls.Add(BTNEditResource);
            Controls.Add(BTNDeleteResource);
            Controls.Add(BTNCreateResource);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)GRDResource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BTNCreateResource;
        private Button BTNDeleteResource;
        private Button BTNEditResource;
        private Button BTNSelectAll;
        public DataGridView GRDResource;
        private Button BTNExport;
        private Button BTNImport;
        private Button BTNCostAnalysis;
        private DataGridViewCheckBoxColumn SelectResource;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn InstanceName;
        private DataGridViewTextBoxColumn CPUCores;
        private DataGridViewTextBoxColumn Memory;
        private DataGridViewTextBoxColumn TempStorageType;
        private DataGridViewTextBoxColumn TempStorageSize;
        private DataGridViewTextBoxColumn GPUCores;
        private DataGridViewTextBoxColumn ClockSpeed;
        private DataGridViewTextBoxColumn NetworkSpeed;
        private DataGridViewTextBoxColumn IOSpeed;
        private DataGridViewTextBoxColumn StorageType;
        private DataGridViewTextBoxColumn StorageSize;
        private DataGridViewTextBoxColumn OperatingSystem;
        private DataGridViewTextBoxColumn Transactions;
        private DataGridViewTextBoxColumn BackupStorageType;
        private DataGridViewTextBoxColumn BackupStorageSize;
        private DataGridViewTextBoxColumn HoursUsed;
        private DataGridViewTextBoxColumn HourCost;
        private DataGridViewTextBoxColumn MonthCost;
        public ComboBox CBXView;
        private SaveFileDialog FDGExport;
        private OpenFileDialog FDGImport;
    }
}
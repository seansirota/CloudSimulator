namespace CloudSimulator
{
    partial class ResourceCreator
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
            LBLResourceEditorForm = new Label();
            label2 = new Label();
            CBXChooseResource = new ComboBox();
            label3 = new Label();
            CBXChooseInstance = new ComboBox();
            CBXChooseInstanceSize = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            KBXClockSpeed = new CheckBox();
            KBXNetworkSpeed = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            NMCHoursSelect = new NumericUpDown();
            CBXChooseTempStorageType = new ComboBox();
            GRPResource = new GroupBox();
            NMCResourceAmount = new NumericUpDown();
            label17 = new Label();
            GRPInstance = new GroupBox();
            label9 = new Label();
            label10 = new Label();
            CBXChooseExternalStorageSize = new ComboBox();
            CBXChooseExternalStorageType = new ComboBox();
            GRPExternalStorage = new GroupBox();
            GRPBackupStorage = new GroupBox();
            label12 = new Label();
            CBXChooseBackupStorageType = new ComboBox();
            label13 = new Label();
            CBXChooseBackupStorageSize = new ComboBox();
            GRPOperatingSystem = new GroupBox();
            label11 = new Label();
            CBXChooseOperatingSystemType = new ComboBox();
            GRPTransactions = new GroupBox();
            label15 = new Label();
            CBXChooseTransactionsAmount = new ComboBox();
            LBLUnitHourlyPrice = new Label();
            BTNCreate = new Button();
            BTNPreview = new Button();
            LBLInstanceHourlyPrice = new Label();
            LBLExternalStorageHourlyPrice = new Label();
            LBLBackupStorageHourlyPrice = new Label();
            LBLOperatingSystemMonthlyPrice = new Label();
            LBLTransactionsHourlyPrice = new Label();
            LBLInstanceMonthlyPrice = new Label();
            LBLExternalStorageMonthlyPrice = new Label();
            LBLBackupStorageMonthlyPrice = new Label();
            LBLTransactionsMonthlyPrice = new Label();
            label14 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            LBLUnitMonthlyPrice = new Label();
            label16 = new Label();
            label26 = new Label();
            LBLTotalHourlyPrice = new Label();
            LBLTotalMonthlyPrice = new Label();
            label27 = new Label();
            label28 = new Label();
            ((System.ComponentModel.ISupportInitialize)NMCHoursSelect).BeginInit();
            GRPResource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NMCResourceAmount).BeginInit();
            GRPInstance.SuspendLayout();
            GRPExternalStorage.SuspendLayout();
            GRPBackupStorage.SuspendLayout();
            GRPOperatingSystem.SuspendLayout();
            GRPTransactions.SuspendLayout();
            SuspendLayout();
            // 
            // LBLResourceEditorForm
            // 
            LBLResourceEditorForm.AutoSize = true;
            LBLResourceEditorForm.Font = new Font("Helvetica", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LBLResourceEditorForm.Location = new Point(285, 22);
            LBLResourceEditorForm.Name = "LBLResourceEditorForm";
            LBLResourceEditorForm.Size = new Size(273, 46);
            LBLResourceEditorForm.TabIndex = 0;
            LBLResourceEditorForm.Text = "Create Resource";
            LBLResourceEditorForm.TextAlign = ContentAlignment.MiddleCenter;
            LBLResourceEditorForm.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 22);
            label2.Name = "label2";
            label2.Size = new Size(182, 19);
            label2.TabIndex = 1;
            label2.Text = "Choose a resource type:";
            // 
            // CBXChooseResource
            // 
            CBXChooseResource.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXChooseResource.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CBXChooseResource.FormattingEnabled = true;
            CBXChooseResource.Location = new Point(202, 22);
            CBXChooseResource.Name = "CBXChooseResource";
            CBXChooseResource.Size = new Size(187, 23);
            CBXChooseResource.TabIndex = 2;
            CBXChooseResource.SelectedIndexChanged += ChooseResourceBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 22);
            label3.Name = "label3";
            label3.Size = new Size(189, 19);
            label3.TabIndex = 3;
            label3.Text = "Choose an instance type:";
            // 
            // CBXChooseInstance
            // 
            CBXChooseInstance.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXChooseInstance.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CBXChooseInstance.FormattingEnabled = true;
            CBXChooseInstance.Location = new Point(202, 22);
            CBXChooseInstance.Name = "CBXChooseInstance";
            CBXChooseInstance.Size = new Size(187, 23);
            CBXChooseInstance.TabIndex = 4;
            CBXChooseInstance.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // CBXChooseInstanceSize
            // 
            CBXChooseInstanceSize.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXChooseInstanceSize.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CBXChooseInstanceSize.FormattingEnabled = true;
            CBXChooseInstanceSize.Location = new Point(202, 55);
            CBXChooseInstanceSize.Name = "CBXChooseInstanceSize";
            CBXChooseInstanceSize.Size = new Size(187, 23);
            CBXChooseInstanceSize.TabIndex = 6;
            CBXChooseInstanceSize.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(8, 55);
            label4.Name = "label4";
            label4.Size = new Size(188, 19);
            label4.TabIndex = 5;
            label4.Text = "Choose an instance size:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(28, 88);
            label5.Name = "label5";
            label5.Size = new Size(168, 19);
            label5.TabIndex = 7;
            label5.Text = "Increase clock speed?";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // KBXClockSpeed
            // 
            KBXClockSpeed.AutoSize = true;
            KBXClockSpeed.Location = new Point(202, 92);
            KBXClockSpeed.Name = "KBXClockSpeed";
            KBXClockSpeed.Size = new Size(15, 14);
            KBXClockSpeed.TabIndex = 8;
            KBXClockSpeed.UseVisualStyleBackColor = true;
            // 
            // KBXNetworkSpeed
            // 
            KBXNetworkSpeed.AutoSize = true;
            KBXNetworkSpeed.Location = new Point(202, 125);
            KBXNetworkSpeed.Name = "KBXNetworkSpeed";
            KBXNetworkSpeed.Size = new Size(15, 14);
            KBXNetworkSpeed.TabIndex = 10;
            KBXNetworkSpeed.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(9, 121);
            label6.Name = "label6";
            label6.Size = new Size(187, 19);
            label6.TabIndex = 9;
            label6.Text = "Increase network speed?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(17, 154);
            label7.Name = "label7";
            label7.Size = new Size(179, 19);
            label7.TabIndex = 11;
            label7.Text = "Temporary storage type:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(13, 88);
            label8.Name = "label8";
            label8.Size = new Size(183, 19);
            label8.TabIndex = 13;
            label8.Text = "Hourly usage per month:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // NMCHoursSelect
            // 
            NMCHoursSelect.Location = new Point(202, 88);
            NMCHoursSelect.Maximum = new decimal(new int[] { 730, 0, 0, 0 });
            NMCHoursSelect.Name = "NMCHoursSelect";
            NMCHoursSelect.Size = new Size(120, 23);
            NMCHoursSelect.TabIndex = 14;
            NMCHoursSelect.Value = new decimal(new int[] { 730, 0, 0, 0 });
            NMCHoursSelect.ValueChanged += ComboBox_SelectedIndexChanged;
            // 
            // CBXChooseTempStorageType
            // 
            CBXChooseTempStorageType.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXChooseTempStorageType.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CBXChooseTempStorageType.FormattingEnabled = true;
            CBXChooseTempStorageType.Location = new Point(202, 154);
            CBXChooseTempStorageType.Name = "CBXChooseTempStorageType";
            CBXChooseTempStorageType.Size = new Size(187, 23);
            CBXChooseTempStorageType.TabIndex = 15;
            CBXChooseTempStorageType.UseWaitCursor = true;
            CBXChooseTempStorageType.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // GRPResource
            // 
            GRPResource.Controls.Add(NMCResourceAmount);
            GRPResource.Controls.Add(label17);
            GRPResource.Controls.Add(NMCHoursSelect);
            GRPResource.Controls.Add(label2);
            GRPResource.Controls.Add(CBXChooseResource);
            GRPResource.Controls.Add(label8);
            GRPResource.Location = new Point(19, 71);
            GRPResource.Name = "GRPResource";
            GRPResource.Size = new Size(395, 121);
            GRPResource.TabIndex = 16;
            GRPResource.TabStop = false;
            GRPResource.Text = "Resource";
            // 
            // NMCResourceAmount
            // 
            NMCResourceAmount.Location = new Point(202, 55);
            NMCResourceAmount.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            NMCResourceAmount.Name = "NMCResourceAmount";
            NMCResourceAmount.Size = new Size(120, 23);
            NMCResourceAmount.TabIndex = 16;
            NMCResourceAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NMCResourceAmount.ValueChanged += ComboBox_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(70, 55);
            label17.Name = "label17";
            label17.Size = new Size(126, 19);
            label17.TabIndex = 3;
            label17.Text = "Choose amount:";
            // 
            // GRPInstance
            // 
            GRPInstance.Controls.Add(label3);
            GRPInstance.Controls.Add(label7);
            GRPInstance.Controls.Add(CBXChooseTempStorageType);
            GRPInstance.Controls.Add(label4);
            GRPInstance.Controls.Add(KBXNetworkSpeed);
            GRPInstance.Controls.Add(label6);
            GRPInstance.Controls.Add(KBXClockSpeed);
            GRPInstance.Controls.Add(label5);
            GRPInstance.Controls.Add(CBXChooseInstanceSize);
            GRPInstance.Controls.Add(CBXChooseInstance);
            GRPInstance.Enabled = false;
            GRPInstance.Location = new Point(19, 198);
            GRPInstance.Name = "GRPInstance";
            GRPInstance.Size = new Size(395, 188);
            GRPInstance.TabIndex = 17;
            GRPInstance.TabStop = false;
            GRPInstance.Text = "Instance";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(34, 22);
            label9.Name = "label9";
            label9.Size = new Size(163, 19);
            label9.TabIndex = 16;
            label9.Text = "External storage type:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(35, 55);
            label10.Name = "label10";
            label10.Size = new Size(162, 19);
            label10.TabIndex = 18;
            label10.Text = "External storage size:";
            // 
            // CBXChooseExternalStorageSize
            // 
            CBXChooseExternalStorageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXChooseExternalStorageSize.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CBXChooseExternalStorageSize.FormattingEnabled = true;
            CBXChooseExternalStorageSize.Location = new Point(202, 55);
            CBXChooseExternalStorageSize.Name = "CBXChooseExternalStorageSize";
            CBXChooseExternalStorageSize.Size = new Size(187, 23);
            CBXChooseExternalStorageSize.TabIndex = 19;
            CBXChooseExternalStorageSize.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // CBXChooseExternalStorageType
            // 
            CBXChooseExternalStorageType.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXChooseExternalStorageType.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CBXChooseExternalStorageType.FormattingEnabled = true;
            CBXChooseExternalStorageType.Location = new Point(202, 22);
            CBXChooseExternalStorageType.Name = "CBXChooseExternalStorageType";
            CBXChooseExternalStorageType.Size = new Size(187, 23);
            CBXChooseExternalStorageType.TabIndex = 17;
            CBXChooseExternalStorageType.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // GRPExternalStorage
            // 
            GRPExternalStorage.Controls.Add(label9);
            GRPExternalStorage.Controls.Add(CBXChooseExternalStorageType);
            GRPExternalStorage.Controls.Add(label10);
            GRPExternalStorage.Controls.Add(CBXChooseExternalStorageSize);
            GRPExternalStorage.Enabled = false;
            GRPExternalStorage.Location = new Point(19, 430);
            GRPExternalStorage.Name = "GRPExternalStorage";
            GRPExternalStorage.Size = new Size(395, 89);
            GRPExternalStorage.TabIndex = 18;
            GRPExternalStorage.TabStop = false;
            GRPExternalStorage.Text = "External Storage";
            // 
            // GRPBackupStorage
            // 
            GRPBackupStorage.Controls.Add(label12);
            GRPBackupStorage.Controls.Add(CBXChooseBackupStorageType);
            GRPBackupStorage.Controls.Add(label13);
            GRPBackupStorage.Controls.Add(CBXChooseBackupStorageSize);
            GRPBackupStorage.Enabled = false;
            GRPBackupStorage.Location = new Point(431, 71);
            GRPBackupStorage.Name = "GRPBackupStorage";
            GRPBackupStorage.Size = new Size(395, 89);
            GRPBackupStorage.TabIndex = 20;
            GRPBackupStorage.TabStop = false;
            GRPBackupStorage.Text = "Backup Storage";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(39, 22);
            label12.Name = "label12";
            label12.Size = new Size(158, 19);
            label12.TabIndex = 16;
            label12.Text = "Backup storage type:";
            // 
            // CBXChooseBackupStorageType
            // 
            CBXChooseBackupStorageType.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXChooseBackupStorageType.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CBXChooseBackupStorageType.FormattingEnabled = true;
            CBXChooseBackupStorageType.Location = new Point(202, 22);
            CBXChooseBackupStorageType.Name = "CBXChooseBackupStorageType";
            CBXChooseBackupStorageType.Size = new Size(187, 23);
            CBXChooseBackupStorageType.TabIndex = 17;
            CBXChooseBackupStorageType.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(40, 55);
            label13.Name = "label13";
            label13.Size = new Size(157, 19);
            label13.TabIndex = 18;
            label13.Text = "Backup storage size:";
            // 
            // CBXChooseBackupStorageSize
            // 
            CBXChooseBackupStorageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXChooseBackupStorageSize.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CBXChooseBackupStorageSize.FormattingEnabled = true;
            CBXChooseBackupStorageSize.Location = new Point(202, 55);
            CBXChooseBackupStorageSize.Name = "CBXChooseBackupStorageSize";
            CBXChooseBackupStorageSize.Size = new Size(187, 23);
            CBXChooseBackupStorageSize.TabIndex = 19;
            CBXChooseBackupStorageSize.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // GRPOperatingSystem
            // 
            GRPOperatingSystem.Controls.Add(label11);
            GRPOperatingSystem.Controls.Add(CBXChooseOperatingSystemType);
            GRPOperatingSystem.Enabled = false;
            GRPOperatingSystem.Location = new Point(431, 204);
            GRPOperatingSystem.Name = "GRPOperatingSystem";
            GRPOperatingSystem.Size = new Size(395, 56);
            GRPOperatingSystem.TabIndex = 21;
            GRPOperatingSystem.TabStop = false;
            GRPOperatingSystem.Text = "Operating System";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(59, 22);
            label11.Name = "label11";
            label11.Size = new Size(137, 19);
            label11.TabIndex = 16;
            label11.Text = "Operating system:";
            // 
            // CBXChooseOperatingSystemType
            // 
            CBXChooseOperatingSystemType.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXChooseOperatingSystemType.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CBXChooseOperatingSystemType.FormattingEnabled = true;
            CBXChooseOperatingSystemType.Location = new Point(202, 22);
            CBXChooseOperatingSystemType.Name = "CBXChooseOperatingSystemType";
            CBXChooseOperatingSystemType.Size = new Size(187, 23);
            CBXChooseOperatingSystemType.TabIndex = 17;
            CBXChooseOperatingSystemType.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // GRPTransactions
            // 
            GRPTransactions.Controls.Add(label15);
            GRPTransactions.Controls.Add(CBXChooseTransactionsAmount);
            GRPTransactions.Enabled = false;
            GRPTransactions.Location = new Point(431, 304);
            GRPTransactions.Name = "GRPTransactions";
            GRPTransactions.Size = new Size(395, 56);
            GRPTransactions.TabIndex = 23;
            GRPTransactions.TabStop = false;
            GRPTransactions.Text = "Transactions";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(21, 22);
            label15.Name = "label15";
            label15.Size = new Size(175, 19);
            label15.TabIndex = 16;
            label15.Text = "Read/Write Operations:";
            // 
            // CBXChooseTransactionsAmount
            // 
            CBXChooseTransactionsAmount.DropDownStyle = ComboBoxStyle.DropDownList;
            CBXChooseTransactionsAmount.Font = new Font("Helvetica", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CBXChooseTransactionsAmount.FormattingEnabled = true;
            CBXChooseTransactionsAmount.Location = new Point(202, 22);
            CBXChooseTransactionsAmount.Name = "CBXChooseTransactionsAmount";
            CBXChooseTransactionsAmount.Size = new Size(187, 23);
            CBXChooseTransactionsAmount.TabIndex = 17;
            CBXChooseTransactionsAmount.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // LBLUnitHourlyPrice
            // 
            LBLUnitHourlyPrice.AutoSize = true;
            LBLUnitHourlyPrice.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LBLUnitHourlyPrice.Location = new Point(633, 418);
            LBLUnitHourlyPrice.Name = "LBLUnitHourlyPrice";
            LBLUnitHourlyPrice.Size = new Size(32, 22);
            LBLUnitHourlyPrice.TabIndex = 25;
            LBLUnitHourlyPrice.Text = "$0";
            // 
            // BTNCreate
            // 
            BTNCreate.Enabled = false;
            BTNCreate.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BTNCreate.Location = new Point(531, 512);
            BTNCreate.Name = "BTNCreate";
            BTNCreate.Size = new Size(94, 41);
            BTNCreate.TabIndex = 26;
            BTNCreate.Text = "Create";
            BTNCreate.UseVisualStyleBackColor = true;
            BTNCreate.Click += CreateButton_Click;
            // 
            // BTNPreview
            // 
            BTNPreview.Enabled = false;
            BTNPreview.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BTNPreview.Location = new Point(431, 512);
            BTNPreview.Name = "BTNPreview";
            BTNPreview.Size = new Size(94, 41);
            BTNPreview.TabIndex = 27;
            BTNPreview.Text = "Preview";
            BTNPreview.UseVisualStyleBackColor = true;
            BTNPreview.Click += PreviewButton_Click;
            // 
            // LBLInstanceHourlyPrice
            // 
            LBLInstanceHourlyPrice.AutoSize = true;
            LBLInstanceHourlyPrice.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBLInstanceHourlyPrice.Location = new Point(221, 389);
            LBLInstanceHourlyPrice.Name = "LBLInstanceHourlyPrice";
            LBLInstanceHourlyPrice.Size = new Size(27, 19);
            LBLInstanceHourlyPrice.TabIndex = 29;
            LBLInstanceHourlyPrice.Text = "$0";
            // 
            // LBLExternalStorageHourlyPrice
            // 
            LBLExternalStorageHourlyPrice.AutoSize = true;
            LBLExternalStorageHourlyPrice.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBLExternalStorageHourlyPrice.Location = new Point(221, 522);
            LBLExternalStorageHourlyPrice.Name = "LBLExternalStorageHourlyPrice";
            LBLExternalStorageHourlyPrice.Size = new Size(27, 19);
            LBLExternalStorageHourlyPrice.TabIndex = 30;
            LBLExternalStorageHourlyPrice.Text = "$0";
            // 
            // LBLBackupStorageHourlyPrice
            // 
            LBLBackupStorageHourlyPrice.AutoSize = true;
            LBLBackupStorageHourlyPrice.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBLBackupStorageHourlyPrice.Location = new Point(633, 163);
            LBLBackupStorageHourlyPrice.Name = "LBLBackupStorageHourlyPrice";
            LBLBackupStorageHourlyPrice.Size = new Size(27, 19);
            LBLBackupStorageHourlyPrice.TabIndex = 31;
            LBLBackupStorageHourlyPrice.Text = "$0";
            // 
            // LBLOperatingSystemMonthlyPrice
            // 
            LBLOperatingSystemMonthlyPrice.AutoSize = true;
            LBLOperatingSystemMonthlyPrice.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBLOperatingSystemMonthlyPrice.Location = new Point(633, 263);
            LBLOperatingSystemMonthlyPrice.Name = "LBLOperatingSystemMonthlyPrice";
            LBLOperatingSystemMonthlyPrice.Size = new Size(27, 19);
            LBLOperatingSystemMonthlyPrice.TabIndex = 32;
            LBLOperatingSystemMonthlyPrice.Text = "$0";
            // 
            // LBLTransactionsHourlyPrice
            // 
            LBLTransactionsHourlyPrice.AutoSize = true;
            LBLTransactionsHourlyPrice.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBLTransactionsHourlyPrice.Location = new Point(633, 363);
            LBLTransactionsHourlyPrice.Name = "LBLTransactionsHourlyPrice";
            LBLTransactionsHourlyPrice.Size = new Size(27, 19);
            LBLTransactionsHourlyPrice.TabIndex = 33;
            LBLTransactionsHourlyPrice.Text = "$0";
            // 
            // LBLInstanceMonthlyPrice
            // 
            LBLInstanceMonthlyPrice.AutoSize = true;
            LBLInstanceMonthlyPrice.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBLInstanceMonthlyPrice.Location = new Point(221, 408);
            LBLInstanceMonthlyPrice.Name = "LBLInstanceMonthlyPrice";
            LBLInstanceMonthlyPrice.Size = new Size(27, 19);
            LBLInstanceMonthlyPrice.TabIndex = 34;
            LBLInstanceMonthlyPrice.Text = "$0";
            // 
            // LBLExternalStorageMonthlyPrice
            // 
            LBLExternalStorageMonthlyPrice.AutoSize = true;
            LBLExternalStorageMonthlyPrice.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBLExternalStorageMonthlyPrice.Location = new Point(221, 541);
            LBLExternalStorageMonthlyPrice.Name = "LBLExternalStorageMonthlyPrice";
            LBLExternalStorageMonthlyPrice.Size = new Size(27, 19);
            LBLExternalStorageMonthlyPrice.TabIndex = 35;
            LBLExternalStorageMonthlyPrice.Text = "$0";
            // 
            // LBLBackupStorageMonthlyPrice
            // 
            LBLBackupStorageMonthlyPrice.AutoSize = true;
            LBLBackupStorageMonthlyPrice.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBLBackupStorageMonthlyPrice.Location = new Point(633, 182);
            LBLBackupStorageMonthlyPrice.Name = "LBLBackupStorageMonthlyPrice";
            LBLBackupStorageMonthlyPrice.Size = new Size(27, 19);
            LBLBackupStorageMonthlyPrice.TabIndex = 36;
            LBLBackupStorageMonthlyPrice.Text = "$0";
            // 
            // LBLTransactionsMonthlyPrice
            // 
            LBLTransactionsMonthlyPrice.AutoSize = true;
            LBLTransactionsMonthlyPrice.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LBLTransactionsMonthlyPrice.Location = new Point(633, 382);
            LBLTransactionsMonthlyPrice.Name = "LBLTransactionsMonthlyPrice";
            LBLTransactionsMonthlyPrice.Size = new Size(27, 19);
            LBLTransactionsMonthlyPrice.TabIndex = 37;
            LBLTransactionsMonthlyPrice.Text = "$0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(106, 389);
            label14.Name = "label14";
            label14.Size = new Size(109, 19);
            label14.TabIndex = 38;
            label14.Text = "Cost per hour:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(94, 408);
            label18.Name = "label18";
            label18.Size = new Size(121, 19);
            label18.TabIndex = 39;
            label18.Text = "Cost per month:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(95, 541);
            label19.Name = "label19";
            label19.Size = new Size(121, 19);
            label19.TabIndex = 41;
            label19.Text = "Cost per month:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(107, 522);
            label20.Name = "label20";
            label20.Size = new Size(109, 19);
            label20.TabIndex = 40;
            label20.Text = "Cost per hour:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(507, 183);
            label21.Name = "label21";
            label21.Size = new Size(121, 19);
            label21.TabIndex = 43;
            label21.Text = "Cost per month:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(519, 164);
            label22.Name = "label22";
            label22.Size = new Size(109, 19);
            label22.TabIndex = 42;
            label22.Text = "Cost per hour:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(507, 382);
            label23.Name = "label23";
            label23.Size = new Size(121, 19);
            label23.TabIndex = 45;
            label23.Text = "Cost per month:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(519, 363);
            label24.Name = "label24";
            label24.Size = new Size(109, 19);
            label24.TabIndex = 44;
            label24.Text = "Cost per hour:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Helvetica", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(507, 263);
            label25.Name = "label25";
            label25.Size = new Size(121, 19);
            label25.TabIndex = 46;
            label25.Text = "Cost per month:";
            // 
            // LBLUnitMonthlyPrice
            // 
            LBLUnitMonthlyPrice.AutoSize = true;
            LBLUnitMonthlyPrice.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LBLUnitMonthlyPrice.Location = new Point(633, 440);
            LBLUnitMonthlyPrice.Name = "LBLUnitMonthlyPrice";
            LBLUnitMonthlyPrice.Size = new Size(32, 22);
            LBLUnitMonthlyPrice.TabIndex = 47;
            LBLUnitMonthlyPrice.Text = "$0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(473, 418);
            label16.Name = "label16";
            label16.Size = new Size(155, 22);
            label16.TabIndex = 48;
            label16.Text = "Unit Hourly Cost:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(461, 440);
            label26.Name = "label26";
            label26.Size = new Size(167, 22);
            label26.TabIndex = 49;
            label26.Text = "Unit Monthly Cost:";
            // 
            // LBLTotalHourlyPrice
            // 
            LBLTotalHourlyPrice.AutoSize = true;
            LBLTotalHourlyPrice.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LBLTotalHourlyPrice.Location = new Point(633, 462);
            LBLTotalHourlyPrice.Name = "LBLTotalHourlyPrice";
            LBLTotalHourlyPrice.Size = new Size(32, 22);
            LBLTotalHourlyPrice.TabIndex = 50;
            LBLTotalHourlyPrice.Text = "$0";
            // 
            // LBLTotalMonthlyPrice
            // 
            LBLTotalMonthlyPrice.AutoSize = true;
            LBLTotalMonthlyPrice.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LBLTotalMonthlyPrice.Location = new Point(633, 484);
            LBLTotalMonthlyPrice.Name = "LBLTotalMonthlyPrice";
            LBLTotalMonthlyPrice.Size = new Size(32, 22);
            LBLTotalMonthlyPrice.TabIndex = 51;
            LBLTotalMonthlyPrice.Text = "$0";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(453, 484);
            label27.Name = "label27";
            label27.Size = new Size(174, 22);
            label27.TabIndex = 52;
            label27.Text = "Total Monthly Cost:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Helvetica", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(466, 462);
            label28.Name = "label28";
            label28.Size = new Size(162, 22);
            label28.TabIndex = 53;
            label28.Text = "Total Hourly Cost:";
            // 
            // ResourceCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 573);
            ControlBox = false;
            Controls.Add(label28);
            Controls.Add(label27);
            Controls.Add(LBLTotalMonthlyPrice);
            Controls.Add(LBLTotalHourlyPrice);
            Controls.Add(label26);
            Controls.Add(label16);
            Controls.Add(LBLUnitMonthlyPrice);
            Controls.Add(label25);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label18);
            Controls.Add(label14);
            Controls.Add(LBLTransactionsMonthlyPrice);
            Controls.Add(LBLBackupStorageMonthlyPrice);
            Controls.Add(LBLExternalStorageMonthlyPrice);
            Controls.Add(LBLInstanceMonthlyPrice);
            Controls.Add(LBLTransactionsHourlyPrice);
            Controls.Add(LBLOperatingSystemMonthlyPrice);
            Controls.Add(LBLBackupStorageHourlyPrice);
            Controls.Add(LBLExternalStorageHourlyPrice);
            Controls.Add(LBLInstanceHourlyPrice);
            Controls.Add(BTNPreview);
            Controls.Add(BTNCreate);
            Controls.Add(LBLUnitHourlyPrice);
            Controls.Add(GRPTransactions);
            Controls.Add(GRPOperatingSystem);
            Controls.Add(GRPBackupStorage);
            Controls.Add(GRPExternalStorage);
            Controls.Add(GRPInstance);
            Controls.Add(GRPResource);
            Controls.Add(LBLResourceEditorForm);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ResourceCreator";
            Text = "ResourceCreator";
            ((System.ComponentModel.ISupportInitialize)NMCHoursSelect).EndInit();
            GRPResource.ResumeLayout(false);
            GRPResource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NMCResourceAmount).EndInit();
            GRPInstance.ResumeLayout(false);
            GRPInstance.PerformLayout();
            GRPExternalStorage.ResumeLayout(false);
            GRPExternalStorage.PerformLayout();
            GRPBackupStorage.ResumeLayout(false);
            GRPBackupStorage.PerformLayout();
            GRPOperatingSystem.ResumeLayout(false);
            GRPOperatingSystem.PerformLayout();
            GRPTransactions.ResumeLayout(false);
            GRPTransactions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLResourceEditorForm;
        private Label label2;
        private ComboBox CBXChooseResource;
        private Label label3;
        private ComboBox CBXChooseInstance;
        private ComboBox CBXChooseInstanceSize;
        private Label label4;
        private Label label5;
        private CheckBox KBXClockSpeed;
        private CheckBox KBXNetworkSpeed;
        private Label label6;
        private CheckBox checkBox2;
        private Label label7;
        private Label label8;
        private NumericUpDown NMCHoursSelect;
        private ComboBox CBXChooseTempStorageType;
        private GroupBox GRPResource;
        private GroupBox GRPInstance;
        private Label label9;
        private Label label10;
        private ComboBox CBXChooseExternalStorageSize;
        private ComboBox CBXChooseExternalStorageType;
        private GroupBox GRPExternalStorage;
        private GroupBox GRPBackupStorage;
        private Label label12;
        private ComboBox CBXChooseBackupStorageType;
        private Label label13;
        private ComboBox CBXChooseBackupStorageSize;
        private GroupBox GRPOperatingSystem;
        private Label label11;
        private ComboBox CBXChooseOperatingSystemType;
        private GroupBox GRPTransactions;
        private Label label15;
        private ComboBox CBXChooseTransactionsAmount;
        private Label LBLUnitHourlyPrice;
        private Button BTNCreate;
        private NumericUpDown NMCResourceAmount;
        private Label label17;
        private Button BTNPreview;
        private Label LBLInstanceHourlyPrice;
        private Label LBLExternalStorageHourlyPrice;
        private Label LBLBackupStorageHourlyPrice;
        private Label LBLOperatingSystemMonthlyPrice;
        private Label LBLTransactionsHourlyPrice;
        private Label LBLInstanceMonthlyPrice;
        private Label LBLExternalStorageMonthlyPrice;
        private Label LBLBackupStorageMonthlyPrice;
        private Label LBLTransactionsMonthlyPrice;
        private Label label14;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label LBLUnitMonthlyPrice;
        private Label label16;
        private Label label26;
        private Label LBLTotalHourlyPrice;
        private Label LBLTotalMonthlyPrice;
        private Label label27;
        private Label label28;
    }
}
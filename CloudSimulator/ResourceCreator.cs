using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudSimulator
{
    //Class for resource form which contains all methods and properties which the resource form uses.
    public partial class ResourceCreator : Form
    {
        //Private fields that contain data such as the list that holds data for temporary, created object. Also contains lists which establish which resources require which fields to be entered.
        private IResource tempResource;
        private const string format = "C4";
        private readonly List<object> specsList = new List<object>();
        private readonly List<EnumField> ListVMField = new List<EnumField>() { EnumField.None, EnumField.None, EnumField.None, EnumField.Name, EnumField.CPUCores, EnumField.Memory, EnumField.TempStorageType, EnumField.TempStorageSize, EnumField.GPUCores, EnumField.ClockSpeed, EnumField.NetworkSpeed, EnumField.IOSpeed, EnumField.StorageType, EnumField.StorageSize, EnumField.OperatingSystem, EnumField.Transactions, EnumField.None, EnumField.None, EnumField.HoursUsed, EnumField.HourlyCost, EnumField.MonthlyCost };
        private readonly List<EnumField> ListDBField = new List<EnumField>() { EnumField.None, EnumField.None, EnumField.None, EnumField.Name, EnumField.CPUCores, EnumField.Memory, EnumField.TempStorageType, EnumField.TempStorageSize, EnumField.GPUCores, EnumField.ClockSpeed, EnumField.NetworkSpeed, EnumField.IOSpeed, EnumField.StorageType, EnumField.StorageSize, EnumField.None, EnumField.None, EnumField.BackupStorageType, EnumField.BackupStorageSize, EnumField.HoursUsed, EnumField.HourlyCost, EnumField.MonthlyCost };
        private readonly List<EnumField> ListKNField = new List<EnumField>() { EnumField.None, EnumField.None, EnumField.None, EnumField.Name, EnumField.CPUCores, EnumField.Memory, EnumField.TempStorageType, EnumField.TempStorageSize, EnumField.GPUCores, EnumField.ClockSpeed, EnumField.NetworkSpeed, EnumField.IOSpeed, EnumField.StorageType, EnumField.StorageSize, EnumField.OperatingSystem, EnumField.None, EnumField.None, EnumField.None, EnumField.HoursUsed, EnumField.HourlyCost, EnumField.MonthlyCost };
        private readonly List<EnumField> ListESField = new List<EnumField>() { EnumField.None, EnumField.None, EnumField.None, EnumField.None, EnumField.None, EnumField.None, EnumField.None, EnumField.None, EnumField.None, EnumField.None, EnumField.None, EnumField.None, EnumField.StorageType, EnumField.StorageSize, EnumField.None, EnumField.Transactions, EnumField.None, EnumField.None, EnumField.HoursUsed, EnumField.HourlyCost, EnumField.MonthlyCost };

        public List<object> SpecsList { get { return specsList; } }

        //Constructor for resource form which either sets everything to default in create mode or fills everything out based on the selected resource in edit mode.
        public ResourceCreator(EnumBuildMode buildMode, List<object> selectedRow)
        {
            InitializeComponent();

            ComboBox[] ComboBoxes =
            {
                CBXChooseInstance,
                CBXChooseInstanceSize,
                CBXChooseTempStorageType,
                CBXChooseExternalStorageType,
                CBXChooseExternalStorageSize,
                CBXChooseBackupStorageType,
                CBXChooseBackupStorageSize,
                CBXChooseOperatingSystemType,
                CBXChooseTransactionsAmount
            };

            foreach (string s in EnumStringStorage.StringResourceType)
                CBXChooseResource.Items.Add(s);

            foreach (string s in EnumStringStorage.StringCategory)
                CBXChooseInstance.Items.Add(s);

            for (int i = 1; i < ComboBoxes.Length; i++)
            {
                EnumComboBoxes e = (EnumComboBoxes)i;
                SetAllCommonComboBoxes.UpdateComboBox(ComboBoxes[i], e);
            }

            if (buildMode == 0)
            {
                LBLResourceEditorForm.Text = "Create Resource";
                BTNCreate.Text = "Create";
                BTNPreview.Enabled = false;
                BTNCreate.Enabled = false;
                NMCResourceAmount.Enabled = true;
            }
            else
            {
                LBLResourceEditorForm.Text = "Edit Resource";
                BTNCreate.Text = "Save";
                NMCResourceAmount.Enabled = false;
                PopulateControls(selectedRow);
                CheckButtons();
            }
        }

        //Enters the parameters of the resource which you are editing and fills the resource editor with the parameters.
        private void PopulateControls(List<object> selectedRow)
        {
            if (selectedRow[(int)EnumField.Name] != null)
                NameDisintegrater(selectedRow[(int)EnumField.Name].ToString());

            for (int i = 0; i < selectedRow.Count - 2; i++)
            {
                object cell = selectedRow[i];

                switch (i)
                {
                    case (int)EnumField.ResourceType:
                        CBXChooseResource.SelectedIndex = Array.IndexOf(EnumStringStorage.StringResourceType, EnumStringStorage.StringResourceType.FirstOrDefault(x => x.Equals(cell.ToString())));
                        break;
                    case (int)EnumField.StorageType:
                        CBXChooseExternalStorageType.SelectedIndex = cell == null ? -1 : cell.ToString() == EnumStorageType.SSD.ToString() ? (int)EnumStorageType.SSD : (int)EnumStorageType.HDD;
                        break;
                    case (int)EnumField.StorageSize:
                        CBXChooseExternalStorageSize.SelectedIndex = cell == null ? -1 : (int)(EnumSize)Enum.Parse(typeof(EnumSize), ((EnumStorageSize)(int)cell).ToString());
                        break;
                    case (int)EnumField.OperatingSystem:
                        CBXChooseOperatingSystemType.SelectedIndex = cell == null ? -1 : cell.ToString() == EnumOperatingSystem.Windows.ToString() ? (int)EnumOperatingSystem.Windows : (int)EnumOperatingSystem.Linux;
                        break;
                    case (int)EnumField.Transactions:
                        CBXChooseTransactionsAmount.SelectedIndex = cell == null ? -1 : (int)(EnumSize)Enum.Parse(typeof(EnumSize), ((EnumTransactions)(int)cell).ToString());
                        break;
                    case (int)EnumField.BackupStorageType:
                        CBXChooseBackupStorageType.SelectedIndex = cell == null ? -1 : cell.ToString() == EnumStorageType.SSD.ToString() ? (int)EnumStorageType.SSD : (int)EnumStorageType.HDD;
                        break;
                    case (int)EnumField.BackupStorageSize:
                        CBXChooseBackupStorageSize.SelectedIndex = cell == null ? -1 : (int)(EnumSize)Enum.Parse(typeof(EnumSize), ((EnumStorageSize)(int)cell).ToString());
                        break;
                    case (int)EnumField.HoursUsed:
                        NMCHoursSelect.Value = cell == null ? 730 : (int)cell;
                        break;
                    default:
                        break;
                }
            }
        }

        //Breaks up the name string into parts and analyzes them to put in the correct instance parameters in edit mode.
        private void NameDisintegrater(string name)
        {
            char[] nameBroken = name.ToCharArray();
            int asciiDifference = 48;
            int zeroIndexDifference = 1;

            if (name != string.Empty || name != null)
            {
                CBXChooseInstance.SelectedIndex = Array.IndexOf(EnumStringStorage.StringCategory, EnumStringStorage.StringCategory.FirstOrDefault(x => x.Contains(nameBroken[0].ToString())));
                CBXChooseInstanceSize.SelectedIndex = nameBroken[1] - asciiDifference - zeroIndexDifference;
                KBXClockSpeed.Checked = nameBroken.Contains('k') ? true : false;
                KBXNetworkSpeed.Checked = nameBroken.Contains('n') ? true : false;
                CBXChooseTempStorageType.SelectedIndex = nameBroken.Contains('t') ? (int)EnumStorageType.SSD : (int)EnumStorageType.HDD;
            }

        }

        //Checks all controls and their values to see if any buttons should be enabled/disabled.
        private void CheckButtons()
        {
            List<ComboBox> boxList = new List<ComboBox>();
            bool allowButtons = false;

            allowButtons = NMCResourceAmount.Value > 0
                        && NMCHoursSelect.Value > 0
                        && CBXChooseExternalStorageType.SelectedIndex >= 0
                        && CBXChooseExternalStorageSize.SelectedIndex >= 0;

            if (allowButtons)
            {
                switch (CBXChooseResource.SelectedIndex)
                {
                    case (int)EnumResourceType.VirtualMachine:
                        allowButtons = CBXChooseInstance.SelectedIndex >= 0
                                    && CBXChooseInstanceSize.SelectedIndex >= 0
                                    && CBXChooseTempStorageType.SelectedIndex >= 0
                                    && CBXChooseOperatingSystemType.SelectedIndex >= 0
                                    && CBXChooseTransactionsAmount.SelectedIndex >= 0;
                        break;
                    case (int)EnumResourceType.Database:
                        allowButtons = CBXChooseInstance.SelectedIndex >= 0
                                    && CBXChooseInstanceSize.SelectedIndex >= 0
                                    && CBXChooseTempStorageType.SelectedIndex >= 0
                                    && CBXChooseBackupStorageType.SelectedIndex >= 0
                                    && CBXChooseBackupStorageSize.SelectedIndex >= 0;
                        break;
                    case (int)EnumResourceType.Kuburnetes:
                        allowButtons = CBXChooseInstance.SelectedIndex >= 0
                                    && CBXChooseInstanceSize.SelectedIndex >= 0
                                    && CBXChooseTempStorageType.SelectedIndex >= 0
                                    && CBXChooseOperatingSystemType.SelectedIndex >= 0;
                        break;
                    case (int)EnumResourceType.ExternalStorage:
                        allowButtons = CBXChooseTransactionsAmount.SelectedIndex >= 0;
                        break;
                }
            }

            BTNPreview.Enabled = allowButtons;
            BTNCreate.Enabled = allowButtons;
        }

        //Resets all costs when using the preview button to zero.
        private void ClearCosts(int index)
        {
            string setDefault = "$0";

            switch (index)
            {
                case (int)EnumResourceType.VirtualMachine:
                    LBLBackupStorageHourlyPrice.Text = setDefault;
                    LBLBackupStorageMonthlyPrice.Text = setDefault;
                    break;
                case (int)EnumResourceType.Database:
                    LBLOperatingSystemMonthlyPrice.Text = setDefault;
                    LBLTransactionsHourlyPrice.Text = setDefault;
                    LBLTransactionsMonthlyPrice.Text = setDefault;
                    break;
                case (int)EnumResourceType.Kuburnetes:
                    LBLTransactionsHourlyPrice.Text = setDefault;
                    LBLTransactionsMonthlyPrice.Text = setDefault;
                    LBLBackupStorageHourlyPrice.Text = setDefault;
                    LBLBackupStorageMonthlyPrice.Text = setDefault;
                    break;
                case (int)EnumResourceType.ExternalStorage:
                    LBLInstanceHourlyPrice.Text = setDefault;
                    LBLInstanceMonthlyPrice.Text = setDefault;
                    LBLOperatingSystemMonthlyPrice.Text = setDefault;
                    LBLBackupStorageHourlyPrice.Text = setDefault;
                    LBLBackupStorageMonthlyPrice.Text = setDefault;
                    break;
                default:
                    break;
            }
        }

        //Method used to add value of resource creator control to a list of values which will be used by main form to populate grid row with new resource or edited resource.
        private object CellBuild(int resourceIndex, IResource tempResource, EnumField field)
        {
            Type objectType;
            dynamic convertedResource;

            switch (resourceIndex)
            {
                case (int)EnumResourceType.VirtualMachine:
                    objectType = typeof(VirtualMachine);
                    break;
                case (int)EnumResourceType.Database:
                    objectType = typeof(Database);
                    break;
                case (int)EnumResourceType.Kuburnetes:
                    objectType = typeof(Kuburnetes);
                    break;
                case (int)EnumResourceType.ExternalStorage:
                    objectType = typeof(ExternalStorage);
                    break;
                default:
                    objectType = null;
                    break;
            }

            convertedResource = Convert.ChangeType(tempResource, objectType);

            switch (field)
            {
                case EnumField.Name:
                    return convertedResource.Name.ToString();
                case EnumField.CPUCores:
                    return (int)convertedResource.CPUCores;
                case EnumField.Memory:
                    return (int)convertedResource.Memory;
                case EnumField.TempStorageType:
                    return convertedResource.TemporaryStorageType.ToString();
                case EnumField.TempStorageSize:
                    return (int)convertedResource.TemporaryStorageSize;
                case EnumField.GPUCores:
                    return (int)convertedResource.GPUCores;
                case EnumField.ClockSpeed:
                    return ((decimal)convertedResource.ClockSpeed) / 10;
                case EnumField.NetworkSpeed:
                    return (int)convertedResource.NetworkSpeed;
                case EnumField.IOSpeed:
                    return (int)convertedResource.IOSpeed;
                case EnumField.StorageType:
                    return convertedResource.StorageType.ToString();
                case EnumField.StorageSize:
                    return (int)convertedResource.StorageSize;
                case EnumField.OperatingSystem:
                    return convertedResource.OperatingSystem.ToString();
                case EnumField.Transactions:
                    return (int)convertedResource.TransactionsMonthly;
                case EnumField.BackupStorageType:
                    return convertedResource.BackupStorageType.ToString();
                case EnumField.BackupStorageSize:
                    return (int)convertedResource.BackupStorageSize;
                case EnumField.HoursUsed:
                    return (int)convertedResource.HoursUsedMonthly;
                case EnumField.HourlyCost:
                    return Math.Round(convertedResource.HourlyCost, 2);
                case EnumField.MonthlyCost:
                    return Math.Round(convertedResource.MonthlyCost, 2);
                default:
                    return null;
            }
        }

        //Builds a temporary resource object from controls parameters and sets all the fields to what you chose in the controls of the form.
        private void ResourceBuild(int index)
        {
            string? ct = CBXChooseInstance.Enabled == true ? CBXChooseInstance.Text.Split(':').First().Replace(" ", "") : null;
            string? sz = CBXChooseInstanceSize.Enabled == true ? CBXChooseInstanceSize.Text : null;
            bool? networkSpeedBoost = KBXNetworkSpeed.Enabled == true ? KBXNetworkSpeed.Checked : null;
            bool? storageTypeBoost = CBXChooseTempStorageType.Enabled == true ? (CBXChooseTempStorageType.Text == "SSD" ? true : false) : null;
            bool? clockSpeedBoost = KBXClockSpeed.Enabled == true ? KBXClockSpeed.Checked : null;
            int? hours = NMCHoursSelect.Enabled == true ? (int)NMCHoursSelect.Value : null;
            EnumStorageType? st = CBXChooseExternalStorageType.Enabled == true ? (EnumStorageType)Enum.Parse(typeof(EnumStorageType), CBXChooseExternalStorageType.Text) : null;
            EnumStorageSize? ss = CBXChooseExternalStorageSize.Enabled == true ? (EnumStorageSize)Enum.Parse(typeof(EnumStorageSize), CBXChooseExternalStorageSize.Text.Split(':').First()) : null;
            EnumOperatingSystem? os = CBXChooseOperatingSystemType.Enabled == true ? (EnumOperatingSystem)Enum.Parse(typeof(EnumOperatingSystem), CBXChooseOperatingSystemType.Text) : null;
            EnumTransactions? ta = CBXChooseTransactionsAmount.Enabled == true ? (EnumTransactions)Enum.Parse(typeof(EnumTransactions), CBXChooseTransactionsAmount.Text.Split(':').First()) : null;
            EnumStorageType? bst = CBXChooseBackupStorageType.Enabled == true ? (EnumStorageType)Enum.Parse(typeof(EnumStorageType), CBXChooseBackupStorageType.Text) : null;
            EnumStorageSize? bss = CBXChooseBackupStorageSize.Enabled == true ? (EnumStorageSize)Enum.Parse(typeof(EnumStorageSize), CBXChooseBackupStorageSize.Text.Split(':').First()) : null;

            switch (index)
            {
                case (int)EnumResourceType.VirtualMachine:
                    tempResource = VirtualMachine.VMBuilder(ct, sz, networkSpeedBoost, storageTypeBoost, clockSpeedBoost, hours, st, ss, os, ta);
                    return;
                case (int)EnumResourceType.Database:
                    tempResource = Database.DBBuilder(ct, sz, networkSpeedBoost, storageTypeBoost, clockSpeedBoost, hours, st, ss, bst, bss);
                    return;
                case (int)EnumResourceType.Kuburnetes:
                    tempResource = Kuburnetes.KNBuilder(ct, sz, networkSpeedBoost, storageTypeBoost, clockSpeedBoost, hours, st, ss, os);
                    return;
                case (int)EnumResourceType.ExternalStorage:
                    tempResource = new ExternalStorage(st, ss, ta, hours);
                    return;
            }
        }

        //Method which handes when a resource type was changed. Resets any parameters if no longer necessary.
        private void ChooseResourceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CBXChooseResource.SelectedIndex;
            ClearCosts(index);

            switch (index)
            {
                case (int)EnumResourceType.VirtualMachine:
                    GRPInstance.Enabled = true;
                    GRPExternalStorage.Enabled = true;
                    GRPOperatingSystem.Enabled = true;
                    GRPTransactions.Enabled = true;
                    GRPBackupStorage.Enabled = false;
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseBackupStorageSize);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseBackupStorageType);
                    break;
                case (int)EnumResourceType.Database:
                    GRPInstance.Enabled = true;
                    GRPExternalStorage.Enabled = true;
                    GRPOperatingSystem.Enabled = false;
                    GRPTransactions.Enabled = false;
                    GRPBackupStorage.Enabled = true;
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseOperatingSystemType);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseTransactionsAmount);
                    break;
                case (int)EnumResourceType.Kuburnetes:
                    GRPInstance.Enabled = true;
                    GRPExternalStorage.Enabled = true;
                    GRPOperatingSystem.Enabled = true;
                    GRPTransactions.Enabled = false;
                    GRPBackupStorage.Enabled = false;
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseTransactionsAmount);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseBackupStorageSize);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseBackupStorageType);
                    break;
                case (int)EnumResourceType.ExternalStorage:
                    GRPInstance.Enabled = false;
                    GRPExternalStorage.Enabled = true;
                    GRPOperatingSystem.Enabled = false;
                    GRPTransactions.Enabled = true;
                    GRPBackupStorage.Enabled = false;
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseInstance);
                    SetAllCommonComboBoxes.ClearRelevantControls(KBXClockSpeed);
                    SetAllCommonComboBoxes.ClearRelevantControls(KBXNetworkSpeed);
                    SetAllCommonComboBoxes.ClearRelevantControls(NMCHoursSelect);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseInstanceSize);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseTempStorageType);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseOperatingSystemType);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseBackupStorageType);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseBackupStorageSize);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseBackupStorageType);
                    break;
                default:
                    GRPInstance.Enabled = false;
                    GRPExternalStorage.Enabled = false;
                    GRPOperatingSystem.Enabled = false;
                    GRPTransactions.Enabled = false;
                    GRPBackupStorage.Enabled = false;
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseExternalStorageType);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseExternalStorageSize);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseInstance);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseInstanceSize);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseTempStorageType);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseOperatingSystemType);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseTransactionsAmount);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseBackupStorageType);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseBackupStorageSize);
                    SetAllCommonComboBoxes.ClearRelevantControls(CBXChooseBackupStorageType);
                    break;
            }

            CheckButtons();
        }

        //Handles the preview button. Shows costs of every part of the resource by hourly and monthly costs.
        private void PreviewButton_Click(object sender, EventArgs e)
        {
            ResourceBuild(CBXChooseResource.SelectedIndex);

            switch (CBXChooseResource.SelectedIndex)
            {
                case (int)EnumResourceType.VirtualMachine:
                    LBLInstanceHourlyPrice.Text = ((VirtualMachine)tempResource).TotalInstanceCost.ToString(format);
                    LBLInstanceMonthlyPrice.Text = ((decimal)(((VirtualMachine)tempResource).TotalInstanceCost * tempResource.HoursUsedMonthly + ((VirtualMachine)tempResource).TemporaryStorageTypeCost)).ToString(format);
                    LBLExternalStorageHourlyPrice.Text = ((VirtualMachine)tempResource).TotalStorageCost.ToString(format);
                    LBLExternalStorageMonthlyPrice.Text = ((decimal)((((VirtualMachine)tempResource).TotalStorageCost * tempResource.HoursUsedMonthly) + ((VirtualMachine)tempResource).StorageTypeCost)).ToString(format);
                    LBLOperatingSystemMonthlyPrice.Text = ((VirtualMachine)tempResource).TotalOSCost.ToString(format);
                    LBLTransactionsHourlyPrice.Text = ((VirtualMachine)tempResource).TotalTransactionsCost.ToString(format);
                    LBLTransactionsMonthlyPrice.Text = ((decimal)(((VirtualMachine)tempResource).TotalTransactionsCost * tempResource.HoursUsedMonthly)).ToString(format);
                    LBLUnitHourlyPrice.Text = ((VirtualMachine)tempResource).HourlyCost.ToString(format);
                    LBLUnitMonthlyPrice.Text = ((VirtualMachine)tempResource).MonthlyCost.ToString(format);
                    LBLTotalHourlyPrice.Text = (((VirtualMachine)tempResource).HourlyCost * (double)NMCResourceAmount.Value).ToString(format);
                    LBLTotalMonthlyPrice.Text = (((VirtualMachine)tempResource).MonthlyCost * (double)NMCResourceAmount.Value).ToString(format);
                    break;
                case (int)EnumResourceType.Database:
                    LBLInstanceHourlyPrice.Text = ((Database)tempResource).TotalInstanceCost.ToString(format);
                    LBLInstanceMonthlyPrice.Text = ((decimal)(((Database)tempResource).TotalInstanceCost * tempResource.HoursUsedMonthly + ((Database)tempResource).TemporaryStorageTypeCost)).ToString(format);
                    LBLExternalStorageHourlyPrice.Text = ((Database)tempResource).TotalStorageCost.ToString(format);
                    LBLExternalStorageMonthlyPrice.Text = ((decimal)((((Database)tempResource).TotalStorageCost * tempResource.HoursUsedMonthly) + ((Database)tempResource).StorageTypeCost)).ToString(format);
                    LBLBackupStorageHourlyPrice.Text = ((Database)tempResource).TotalBackupStorageCost.ToString(format);
                    LBLBackupStorageMonthlyPrice.Text = ((decimal)((((Database)tempResource).TotalBackupStorageCost * tempResource.HoursUsedMonthly) + ((Database)tempResource).BackupStorageTypeCost)).ToString(format);
                    LBLUnitHourlyPrice.Text = ((Database)tempResource).HourlyCost.ToString(format);
                    LBLUnitMonthlyPrice.Text = ((Database)tempResource).MonthlyCost.ToString(format);
                    LBLTotalHourlyPrice.Text = (((Database)tempResource).HourlyCost * (double)NMCResourceAmount.Value).ToString(format);
                    LBLTotalMonthlyPrice.Text = (((Database)tempResource).MonthlyCost * (double)NMCResourceAmount.Value).ToString(format);
                    break;
                case (int)EnumResourceType.Kuburnetes:
                    LBLInstanceHourlyPrice.Text = ((Kuburnetes)tempResource).TotalInstanceCost.ToString(format);
                    LBLInstanceMonthlyPrice.Text = ((decimal)(((Kuburnetes)tempResource).TotalInstanceCost * tempResource.HoursUsedMonthly + ((Kuburnetes)tempResource).TemporaryStorageTypeCost)).ToString(format);
                    LBLExternalStorageHourlyPrice.Text = ((Kuburnetes)tempResource).TotalStorageCost.ToString(format);
                    LBLExternalStorageMonthlyPrice.Text = ((decimal)((((Kuburnetes)tempResource).TotalStorageCost * tempResource.HoursUsedMonthly) + ((Kuburnetes)tempResource).StorageTypeCost)).ToString(format);
                    LBLOperatingSystemMonthlyPrice.Text = ((Kuburnetes)tempResource).TotalOSCost.ToString(format);
                    LBLUnitHourlyPrice.Text = ((Kuburnetes)tempResource).HourlyCost.ToString(format);
                    LBLUnitMonthlyPrice.Text = ((Kuburnetes)tempResource).MonthlyCost.ToString(format);
                    LBLTotalHourlyPrice.Text = (((Kuburnetes)tempResource).HourlyCost * (double)NMCResourceAmount.Value).ToString(format);
                    LBLTotalMonthlyPrice.Text = (((Kuburnetes)tempResource).MonthlyCost * (double)NMCResourceAmount.Value).ToString(format);
                    break;
                case (int)EnumResourceType.ExternalStorage:
                    LBLExternalStorageHourlyPrice.Text = ((ExternalStorage)tempResource).TotalStorageCost.ToString(format);
                    LBLExternalStorageMonthlyPrice.Text = ((decimal)((((ExternalStorage)tempResource).TotalStorageCost * tempResource.HoursUsedMonthly) + ((ExternalStorage)tempResource).StorageTypeCost)).ToString(format);
                    LBLTransactionsHourlyPrice.Text = ((ExternalStorage)tempResource).TotalTransactionsCost.ToString(format);
                    LBLTransactionsMonthlyPrice.Text = ((decimal)(((ExternalStorage)tempResource).TotalTransactionsCost * tempResource.HoursUsedMonthly)).ToString(format);
                    LBLUnitHourlyPrice.Text = ((ExternalStorage)tempResource).HourlyCost.ToString(format);
                    LBLUnitMonthlyPrice.Text = ((ExternalStorage)tempResource).MonthlyCost.ToString(format);
                    LBLTotalHourlyPrice.Text = (((ExternalStorage)tempResource).HourlyCost * (double)NMCResourceAmount.Value).ToString(format);
                    LBLTotalMonthlyPrice.Text = (((ExternalStorage)tempResource).MonthlyCost * (double)NMCResourceAmount.Value).ToString(format);
                    break;
                default:
                    break;
            }
        }

        //Handles the create button. Used to build an object, add object fields to a list, and use the list in the main form to add new resource to grid.
        private void CreateButton_Click(object sender, EventArgs e)
        {
            string type;
            List<EnumField> specsListValues = new List<EnumField>();

            ResourceBuild(CBXChooseResource.SelectedIndex);
            int resourceType = CBXChooseResource.SelectedIndex;

            switch (resourceType)
            {
                case (int)EnumResourceType.VirtualMachine:
                    type = EnumStringStorage.StringResourceType[(int)EnumResourceType.VirtualMachine];
                    specsListValues = ListVMField;
                    break;
                case (int)EnumResourceType.Database:
                    type = EnumStringStorage.StringResourceType[(int)EnumResourceType.Database];
                    specsListValues = ListDBField;
                    break;
                case (int)EnumResourceType.Kuburnetes:
                    type = EnumStringStorage.StringResourceType[(int)EnumResourceType.Kuburnetes];
                    specsListValues = ListKNField;
                    break;
                case (int)EnumResourceType.ExternalStorage:
                    type = EnumStringStorage.StringResourceType[(int)EnumResourceType.ExternalStorage];
                    specsListValues = ListESField;
                    break;
                default:
                    type = string.Empty;
                    break;
            }

            foreach (EnumField f in specsListValues)
                specsList.Add(CellBuild(resourceType, tempResource, f));

            specsList[(int)EnumField.ResourceType] = type;
            MainForm.Amount = (int)NMCResourceAmount.Value;

            this.Close();
        }

        //Method which validates all buttons in resource form when any combo box item is changed.
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }
    }
}

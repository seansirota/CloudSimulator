using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudSimulator
{
    //Class containing methods used in main form.
    public partial class MainForm : Form
    {
        private EnumBuildMode buildMode;
        private EnumFilterMode filterMode;
        private List<int> selectedRowIndices = new List<int>();
        private bool selectAllMode = true;

        public static int Amount { get; set; }
        public List<object> rowValues = new List<object>();
        public List<DataGridViewRow> allRows = new List<DataGridViewRow>();

        //Constructor and initializer of main form.
        public MainForm()
        {
            InitializeComponent();

            BTNEditResource.Enabled = false;
            BTNDeleteResource.Enabled = false;
            BTNSelectAll.Enabled = false;
            BTNImport.Enabled = false;
            BTNCostAnalysis.Enabled = false;

            if (EnumStringStorage.StringFilterMode.Length > 0)
            {
                CBXView.Items.Clear();
                foreach (string item in EnumStringStorage.StringFilterMode)
                    CBXView.Items.Add(item);
            }
        }

        //Method which adds data to new row of data grid and to hidden stored row list.
        private void RowMaster(ResourceCreator rc)
        {
            DataGridView grid = Program.mainForm.GRDResource;
            DataGridViewRow gridRow;
            int typeIndex;

            switch (buildMode)
            {
                case EnumBuildMode.Create:
                    for (int i = 0; i < Amount; i++)
                    {
                        gridRow = grid.Rows[grid.Rows.Add()];

                        typeIndex = Array.IndexOf(EnumStringStorage.StringResourceType, rc.SpecsList[(int)EnumField.ResourceType]);
                        if (!(filterMode == EnumFilterMode.All || (int)filterMode - 1 == typeIndex))
                            grid.Rows.RemoveAt(grid.Rows.Count - 1);

                        gridRow.Cells[(int)EnumField.ResourceID].Value = IDCreator.IDGenerate();
                        gridRow.Cells[(int)EnumField.ResourceType].Value = rc.SpecsList[(int)EnumField.ResourceType];

                        for (int j = (int)EnumField.Name; j < rc.SpecsList.Count; j++)
                            gridRow.Cells[j].Value = rc.SpecsList[j];

                        allRows.Add(gridRow);
                    }
                    break;
                case EnumBuildMode.Edit:
                    gridRow = grid.Rows[allRows.FirstOrDefault(x => (int)x.Cells[1].Value == selectedRowIndices.FirstOrDefault()).Index];
                    gridRow.Cells[(int)EnumField.SelectResource].Value = false;
                    gridRow.Cells[(int)EnumField.ResourceType].Value = rc.SpecsList[(int)EnumField.ResourceType];

                    for (int j = (int)EnumField.Name; j < rc.SpecsList.Count; j++)
                        gridRow.Cells[j].Value = rc.SpecsList[j];

                    allRows[allRows.FindIndex(x => (int)x.Cells[1].Value == selectedRowIndices.FirstOrDefault())] = gridRow;

                    typeIndex = Array.IndexOf(EnumStringStorage.StringResourceType, rc.SpecsList[(int)EnumField.ResourceType]);
                    if (!(filterMode == EnumFilterMode.All || (int)filterMode - 1 == typeIndex))
                        grid.Rows.Remove(gridRow);
                    break;
            }

            SelectRowIndices();
            SelectionValidate();
        }

        //Validates currently selected items in main form to see if any buttons should be enabled/disabled based on selection.
        public void SelectionValidate()
        {
            DataGridView grid = Program.mainForm.GRDResource;
            int selectedRowsCount = selectedRowIndices.Count;

            if (selectedRowsCount <= 0)
            {
                BTNEditResource.Enabled = false;
                BTNDeleteResource.Enabled = false;
            }
            else if (selectedRowsCount == 1)
            {
                BTNEditResource.Enabled = true;
                BTNDeleteResource.Enabled = true;
            }
            else if (selectedRowsCount > 1)
            {
                BTNEditResource.Enabled = false;
                BTNDeleteResource.Enabled = true;
            }

            if (grid.RowCount == 0)
                BTNSelectAll.Enabled = false;
            else
                BTNSelectAll.Enabled = true;
        }

        //Add index of selected item to list every time an item is selected in main form.
        public void SelectRowIndices()
        {
            DataGridView grid = Program.mainForm.GRDResource;
            DataGridViewRow row;

            if (grid.Columns[0].CellType == typeof(DataGridViewCheckBoxCell))
            {
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    row = grid.Rows[i];
                    bool checkBox = Convert.ToBoolean(row.Cells[0].Value);
                    int id = (int)row.Cells[1].Value;

                    if (checkBox && selectedRowIndices.Contains(id) || !checkBox && !selectedRowIndices.Contains(id))
                        continue;
                    else if (!checkBox && selectedRowIndices.Contains(id))
                        selectedRowIndices.Remove(id);
                    else if (checkBox && !selectedRowIndices.Contains(id))
                        selectedRowIndices.Add(id);
                    else
                        continue;
                }
            }
        }

        //Method for handling create resource requests.
        private void CreateButton_Click(object sender, EventArgs e)
        {
            buildMode = EnumBuildMode.Create;
            ResourceCreator creator = new ResourceCreator(buildMode, null);
            creator.ShowDialog();
            RowMaster(creator);
        }

        //Method for handling edit resource requests.
        private void EditButton_Click(object sender, EventArgs e)
        {
            DataGridView grid = Program.mainForm.GRDResource;
            buildMode = EnumBuildMode.Edit;

            if (rowValues == null)
                return;
            else
                rowValues.Clear();

            foreach (DataGridViewCell cell in allRows.Find(x => (int)x.Cells[1].Value == selectedRowIndices.FirstOrDefault()).Cells)
            {
                rowValues.Add(cell.Value);
            }

            ResourceCreator creator = new ResourceCreator(buildMode, rowValues);
            creator.ShowDialog();
            RowMaster(creator);
        }

        //Refreshes data grid every time this is changed to filter out the correct resource types.
        private void ViewComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView grid = Program.mainForm.GRDResource;
            filterMode = (EnumFilterMode)CBXView.SelectedIndex;
            EnumResourceType type;

            foreach (DataGridViewRow row in grid.Rows)
                row.Cells[0].Value = false;

            grid.Rows.Clear();
            selectedRowIndices.Clear();

            switch (filterMode)
            {
                case EnumFilterMode.VirtualMachines:
                    type = EnumResourceType.VirtualMachine;
                    break;
                case EnumFilterMode.Databases:
                    type = EnumResourceType.Database;
                    break;
                case EnumFilterMode.Kuburnetes:
                    type = EnumResourceType.Kuburnetes;
                    break;
                case EnumFilterMode.ExternalStorage:
                    type = EnumResourceType.ExternalStorage;
                    break;
                default:
                    foreach (DataGridViewRow row in allRows)
                        grid.Rows.Add(row);

                    SelectionValidate();

                    selectAllMode = true;
                    BTNSelectAll.Text = EnumStringStorage.StringSelectMode[(int)EnumSelectMode.All];
                    return;
            }

            foreach (DataGridViewRow row in allRows.Where(x => x.Cells[2].Value == EnumStringStorage.StringResourceType[(int)type]))
                grid.Rows.Add(row);

            SelectionValidate();

            selectAllMode = true;
            BTNSelectAll.Text = EnumStringStorage.StringSelectMode[(int)EnumSelectMode.All];
        }

        //Executes every time a row is selected by the checkbox. Procedurally adds row to list of indexes of selected rows.
        private void GRDResource_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridView grid = Program.mainForm.GRDResource;

            if (grid.CurrentCell is DataGridViewCheckBoxCell)
            {
                grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
                if (selectedRowIndices.Count < grid.RowCount)
                {
                    selectAllMode = true;
                    BTNSelectAll.Text = EnumStringStorage.StringSelectMode[(int)EnumSelectMode.All];
                }
                else if (selectedRowIndices.Count == grid.RowCount)
                {
                    selectAllMode = false;
                    BTNSelectAll.Text = EnumStringStorage.StringSelectMode[(int)EnumSelectMode.None];
                }
            }

            SelectRowIndices();
            SelectionValidate();
        }

        //Handles delete row requests.
        private void BTNDeleteResource_Click(object sender, EventArgs e)
        {
            DataGridView grid = Program.mainForm.GRDResource;
            buildMode = EnumBuildMode.Delete;
            int index = 0;
            DataGridViewRow row;

            for (int i = 0; i < allRows.Count;)
            {
                row = allRows[i];
                if (Convert.ToBoolean(row.Cells[0].Value) == true)
                {
                    index = (int)row.Cells[1].Value;
                    grid.Rows.Remove(row);
                    allRows.Remove(row);
                    selectedRowIndices.Remove(index);
                    continue;
                }
                i++;
            }

            SelectRowIndices();
            SelectionValidate();
        }

        //Either selects all rows in the grid or none if every row is selected.
        private void BTNSelectAll_Click(object sender, EventArgs e)
        {
            DataGridView grid = Program.mainForm.GRDResource;
            DataGridViewRow row;

            if (grid.Columns[0].CellType == typeof(DataGridViewCheckBoxCell))
            {
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    row = grid.Rows[i];
                    if (selectAllMode)
                        ((DataGridViewCheckBoxCell)row.Cells[0]).Value = true;
                    else
                        ((DataGridViewCheckBoxCell)row.Cells[0]).Value = false;
                }

                BTNSelectAll.Text = selectAllMode ? EnumStringStorage.StringSelectMode[(int)EnumSelectMode.None] : EnumStringStorage.StringSelectMode[(int)EnumSelectMode.All];
                selectAllMode = selectAllMode ? false : true;
            }

            SelectRowIndices();
            SelectionValidate();
        }

        //Exports current grid view to CSV file.
        private void BTNExport_Click(object sender, EventArgs e)
        {
            DataGridView grid = Program.mainForm.GRDResource;
            StringBuilder sb = new StringBuilder();
            string fileName;

            IEnumerable<DataGridViewColumn> headers = grid.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in grid.Rows)
            {
                IEnumerable<DataGridViewCell> cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }

            FDGExport.ShowDialog();
            fileName = FDGExport.FileName;
            File.WriteAllText(fileName + ".csv", sb.ToString());
        }

        //Imports a CSV file and validates data before creating a data grid view. Currently incomplete.
        private void BTNImport_Click(object sender, EventArgs e)
        {
            DataGridView grid = Program.mainForm.GRDResource;
            DataTable table = new DataTable();
            string fileName;
            bool boolItem;
            int intItem;
            string stringItem;
            bool failImport = false;
            int failRow = -1;
            int failCol = -1;

            FDGImport.ShowDialog();
            fileName = FDGImport.FileName;

            //File.ReadLines(fileName).Take(1)
            //    .SelectMany(x => x.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
            //    .ToList()
            //    .ForEach(x => table.Columns.Add(x.Trim()));

            File.ReadLines(fileName).Skip(1)
                .Select(x => x.Split(';'))
                .ToList()
                .ForEach(line => table.Rows.Add(line));

            foreach (DataGridViewRow row in table.Rows)
            {
                failRow = row.Index;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    failCol = cell.ColumnIndex;

                    switch (cell.ColumnIndex)
                    {
                        case (int)EnumField.SelectResource:
                            failImport = Boolean.TryParse(cell.Value.ToString().ToLower(), out boolItem);
                            break;
                        case (int)EnumField.ResourceID:
                            intItem = IDCreator.IDGenerate();
                            break;
                        case (int)EnumField.ResourceType:
                            stringItem = EnumStringStorage.StringResourceType.Contains(cell.Value.ToString()) ? cell.Value.ToString() : null;
                            failImport = stringItem != null ? false : true;
                            break;
                        case (int)EnumField.Name:
                            failImport = cell.Value.ToString().Length >= 2
                                      && cell.Value.ToString().Length <= 5;
                            if (!failImport)
                                break;

                            foreach (char c in new char[] { 'E', 'G', 'C', 'M', 'A', 'G', 'H' })
                            {
                                failImport = !(cell.Value.ToString()[0] == c);
                                if (!failImport)
                                {
                                    MessageBox.Show("Import failed because of incompatibility at cell reference (" + failCol + ", " + failRow + ").");
                                    return;
                                }
                            }
                            foreach (char c in new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' })
                            {
                                failImport = !(cell.Value.ToString()[1] == c);
                                if (!failImport)
                                {
                                    MessageBox.Show("Import failed because of incompatibility at cell reference (" + failCol + ", " + failRow + ").");
                                    return;
                                }
                            }
                            if (cell.Value.ToString().Length > 2)
                            {
                                foreach (char c in new char[] { 'k', 'n', 't' })
                                {
                                    foreach (char d in cell.Value.ToString().Substring(2))
                                    {
                                        failImport = !(d == c);
                                        if (!failImport)
                                        {
                                            MessageBox.Show("Import failed because of incompatibility at cell reference (" + failCol + ", " + failRow + ").");
                                            return;
                                        }
                                    }
                                }
                            }
                            break;
                        case (int)EnumField.CPUCores:

                            break;
                        case (int)EnumField.Memory:

                            break;
                        case (int)EnumField.TempStorageType:

                            break;
                        case (int)EnumField.TempStorageSize:

                            break;
                        case (int)EnumField.GPUCores:

                            break;
                        case (int)EnumField.ClockSpeed:

                            break;
                        case (int)EnumField.NetworkSpeed:

                            break;
                        case (int)EnumField.IOSpeed:

                            break;
                        case (int)EnumField.StorageType:

                            break;
                        case (int)EnumField.StorageSize:

                            break;
                        case (int)EnumField.OperatingSystem:

                            break;
                        case (int)EnumField.Transactions:

                            break;
                        case (int)EnumField.BackupStorageType:

                            break;
                        case (int)EnumField.BackupStorageSize:

                            break;
                        case (int)EnumField.HoursUsed:

                            break;
                        case (int)EnumField.HourlyCost:

                            break;
                        case (int)EnumField.MonthlyCost:

                            break;
                        default:

                            break;
                    }

                    if (failImport == false)
                    {
                        MessageBox.Show("Import failed because of incompatibility at cell reference (" + failCol + ", " + failRow + ").");
                        return;
                    }

                    //grid.Rows[row.Index].Cells[cell.ColumnIndex].Value = item;
                }
            }
        }

        //Method which ends the application when the main form is closed.
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSimulator
{
    //Class and method for giving a resource a unique idea.
    class IDCreator
    {
        private static int lastUsedID = 1;

        public static int IDGenerate()
        {
            return lastUsedID++;
        }
    }

    //Class and method which populates all combo boxes in resource form with the associated items.
    class SetAllCommonComboBoxes
    {
        public static void UpdateComboBox(ComboBox cb, EnumComboBoxes e)
        {
            Type enumType;
            string sizeString;
            string typeOfSize;

            switch (e)
            {
                case EnumComboBoxes.InstanceSize:
                    enumType = typeof(EnumSize);
                    typeOfSize = string.Empty;
                    break;
                case EnumComboBoxes.ExternalStorageSize:
                case EnumComboBoxes.BackupStorageSize:
                    enumType = typeof(EnumStorageSize);
                    typeOfSize = "GB";
                    break;
                case EnumComboBoxes.TransactionsAmount:
                    enumType = typeof(EnumTransactions);
                    typeOfSize = "Transactions";
                    break;
                case EnumComboBoxes.TemporaryStorageType:
                case EnumComboBoxes.ExternalStorageType:
                case EnumComboBoxes.BackupStorageType:
                    enumType = typeof(EnumStorageType);
                    typeOfSize = "GB";
                    break;
                case EnumComboBoxes.OperatingSystemType:
                    enumType = typeof(EnumOperatingSystem);
                    typeOfSize = string.Empty;
                    break;
                default:
                    enumType = typeof(Enum);
                    typeOfSize = string.Empty;
                    break;
            }

            if (enumType != typeof(EnumOperatingSystem) && enumType != typeof(EnumStorageType) && enumType != typeof(EnumSize))
            {
                foreach (int v in Enum.GetValues(enumType))
                {
                    sizeString = Enum.GetName(enumType, v);
                    cb.Items.Add(sizeString + ": " + v.ToString() + " " + typeOfSize);
                }
            }
            else
            {
                int limitCounter = 0;
                foreach (string s in Enum.GetNames(enumType))
                {
                    cb.Items.Add(s);
                    limitCounter++;
                    if (limitCounter == 5)
                        break;
                }
            }
        }

        //Set default values to all controls in resource form.
        public static void ClearRelevantControls(Control c)
        {
            Type cType = c.GetType();

            if (cType == typeof(ComboBox))
                c.Text = string.Empty;
            else if (cType == typeof(NumericUpDown))
                ((NumericUpDown)c).Value = 730;
            else if (cType == typeof(CheckBox))
                ((CheckBox)c).Checked = false;
        }
    }
}

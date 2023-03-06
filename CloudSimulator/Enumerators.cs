using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSimulator
{
    //All enums used in application stored here.
    public enum EnumStorageType
    {
        HDD,
        SSD
    }
    public enum EnumStorageSize
    {
        Tiny = 32,
        Small = 64,
        Medium = 128,
        Large = 256,
        XLarge = 512,
        X2Large = 1024,
        X3Large = 2048,
        X4Large = 4096,
        X5Large = 8192
    }
    public enum EnumCPUCores
    {
        Tiny = 2,
        Small = 4,
        Medium = 8,
        Large = 16,
        XLarge = 32,
        X2Large = 64,
        X3Large = 128,
        X4Large = 256,
        X5Large = 512
    }
    public enum EnumMemory
    {
        Tiny = 8,
        Small = 16,
        Medium = 32,
        Large = 64,
        XLarge = 128,
        X2Large = 256,
        X3Large = 512,
        X4Large = 1024,
        X5Large = 2048
    }
    public enum EnumClockSpeed
    {
        Tiny = 20,
        Small = 23,
        Medium = 26,
        Large = 29,
        XLarge = 32,
        X2Large = 35,
        X3Large = 38,
        X4Large = 41,
        X5Large = 44
    }
    public enum EnumNetworkSpeed
    {
        Tiny = 10,
        Small = 15,
        Medium = 20,
        Large = 30,
        XLarge = 40,
        X2Large = 60,
        X3Large = 80,
        X4Large = 100,
        X5Large = 120
    }
    public enum EnumIOSpeed
    {
        Tiny = 10,
        Small = 10,
        Medium = 15,
        Large = 15,
        XLarge = 20,
        X2Large = 20,
        X3Large = 30,
        X4Large = 30,
        X5Large = 50
    }
    public enum EnumGPUCores
    {
        None = 0,
        Tiny = 1,
        Small = 1,
        Medium = 2,
        Large = 2,
        XLarge = 4,
        X2Large = 4,
        X3Large = 8,
        X4Large = 8,
        X5Large = 16,
    }
    public enum EnumCategory
    {
        Economy,
        GeneralPurpose,
        ComputeOptimized,
        MemoryOptimized,
        AcceleratorOptimized,
        StorageOptimized,
        HighPerformanceComputing
    }

    public enum EnumSize
    {
        Tiny,
        Small,
        Medium,
        Large,
        XLarge,
        X2Large,
        X3Large,
        X4Large,
        X5Large
    }
    public enum EnumOperatingSystem
    {
        Linux,
        Windows
    }
    public enum EnumTransactions
    {
        Tiny = 10000,
        Small = 20000,
        Medium = 30000,
        Large = 40000,
        XLarge = 50000,
        X2Large = 60000,
        X3Large = 70000,
        X4Large = 80000,
        X5Large = 90000
    }
    public enum EnumComponent
    {
        CPU,
        Memory,
        Storage,
        GPU,
        ClockSpeed,
        NetworkSpeed,
        IOSpeed,
        Transactions
    }

    public enum EnumField
    {
        SelectResource,
        ResourceID,
        ResourceType,
        Name,
        CPUCores,
        Memory,
        TempStorageType,
        TempStorageSize,
        GPUCores,
        ClockSpeed,
        NetworkSpeed,
        IOSpeed,
        StorageType,
        StorageSize,
        OperatingSystem,
        Transactions,
        BackupStorageType,
        BackupStorageSize,
        HoursUsed,
        HourlyCost,
        MonthlyCost,
        None
    }

    public enum EnumResourceType
    {
        VirtualMachine,
        Database,
        Kuburnetes,
        ExternalStorage
    }

    public enum EnumComboBoxes
    {
        InstanceType,
        InstanceSize,
        TemporaryStorageType,
        ExternalStorageType,
        ExternalStorageSize,
        BackupStorageType,
        BackupStorageSize,
        OperatingSystemType,
        TransactionsAmount
    }

    public enum EnumBuildMode
    {
        Create,
        Edit,
        Delete
    }

    public enum EnumFilterMode
    {
        All,
        VirtualMachines,
        Databases,
        Kuburnetes,
        ExternalStorage
    }

    public enum EnumSelectMode
    {
        All,
        None
    }

    //String array counterparts for some enums above stored below. Used for indexing enums and returning related string.
    public class EnumStringStorage
    {
        public static string[] StringResourceType =
        {
            "Virtual Machine",
            "Database",
            "Kuburnetes",
            "External Storage"
        };

        public static string[] StringCategory =
        {
            "Economy",
            "General Purpose",
            "Compute Optimized",
            "Memory Optimized",
            "Accelerator Optimized",
            "Storage Optimized",
            "High Performance Computing"
        };

        public static string[] StringComboBoxes =
        {
            "Instance Type",
            "Instance Size",
            "Temporary Storage Type",
            "External Storage Type",
            "External Storage Size",
            "Backup Storage Type",
            "Backup Storage Size",
            "Operating System Type",
            "Transactions Amount"
        };

        public static string[] StringFilterMode =
        {
            "All",
            "Virtual Machines",
            "Databases",
            "Kuburnetes",
            "External Storage"
        };

        public static string[] StringSelectMode =
        {
            "Select All Rows",
            "Select No Rows"
        };
    }

    //Class containing fields and methods used to calculate costs for the resources.
    class PriceCalculator
    {
        //Variable prices per hardware component or aspect which are billed hourly.
        private const double cpuCost = 0.003;
        private const double memoryCost = 0.001;
        private const double storageCost = 0.00011;
        private const double gpuCost = 0.048;
        private const double clockSpeedCost = 0.007;
        private const double networkSpeedCost = 0.003;
        private const double ioSpeedCost = 0.003;
        private const double transactionCost = 0.000005;

        //Fixed costs that are only billed monthly.
        private const int hddCost = 5;
        private const int ssdCost = 8;
        private const int windowsCost = 20;
        private const int linuxCost = 10;

        //Calculates the price of a hardware component per amount.
        public static double CostPerUnitCalculator(EnumComponent c, int amount)
        {
            double unitPrice;
            double cost;

            switch (c)
            {
                case EnumComponent.CPU:
                    unitPrice = cpuCost;
                    break;
                case EnumComponent.Memory:
                    unitPrice = memoryCost;
                    break;
                case EnumComponent.Storage:
                    unitPrice = storageCost;
                    break;
                case EnumComponent.GPU:
                    unitPrice = gpuCost;
                    break;
                case EnumComponent.ClockSpeed:
                    unitPrice = clockSpeedCost;
                    break;
                case EnumComponent.NetworkSpeed:
                    unitPrice = networkSpeedCost;
                    break;
                case EnumComponent.IOSpeed:
                    unitPrice = ioSpeedCost;
                    break;
                case EnumComponent.Transactions:
                    unitPrice = transactionCost;
                    break;
                default:
                    unitPrice = 0;
                    break;
            }

            cost = unitPrice * amount;
            return cost;
        }

        //Calculates cost of a fixed cost such as operating system or hard drive type.
        public static double FixedCostCalculator(object o)
        {
            int cost;

            switch (o)
            {
                case EnumStorageType.HDD:
                    cost = hddCost;
                    break;
                case EnumStorageType.SSD:
                    cost = ssdCost;
                    break;
                case EnumOperatingSystem.Windows:
                    cost = windowsCost;
                    break;
                case EnumOperatingSystem.Linux:
                    cost = linuxCost;
                    break;
                default:
                    cost = 0;
                    break;
            }

            return cost;
        }

        //Method used to populate properties of a resource related to hardware and aspects of it.
        public static object GenerateSpecs(string? resourceType, string? ct, string? sz, bool? networkBoost, bool? storageTypeBoost, bool? clockSpeedBoost)
        {
            object obj;
            EnumCategory category = (EnumCategory)Enum.Parse(typeof(EnumCategory), ct);
            EnumSize size = (EnumSize)Enum.Parse(typeof(EnumSize), sz);

            int sizeIncrease = 0;
            int cpuIncrease = 0;
            int memoryIncrease = 0;
            int storageIncrease = 0;
            int ioSpeedIncrease = 0;
            int networkIncrease = (bool)networkBoost ? 1 : 0;
            string networkSign = (bool)networkBoost ? "n" : string.Empty;
            EnumStorageType storageType = (bool)storageTypeBoost ? EnumStorageType.SSD : EnumStorageType.HDD;
            string storageSign = (bool)storageTypeBoost ? "t" : string.Empty;
            int clockSpeedIncrease = (bool)clockSpeedBoost ? 1 : 0;
            string clockSpeedSign = (bool)clockSpeedBoost ? "k" : string.Empty;
            bool gpuIncluded = false;

            switch (category)
            {
                case EnumCategory.Economy:
                    break;
                case EnumCategory.GeneralPurpose:
                    sizeIncrease = 1;
                    break;
                case EnumCategory.ComputeOptimized:
                    sizeIncrease = 1;
                    cpuIncrease = 2;
                    break;
                case EnumCategory.MemoryOptimized:
                    sizeIncrease = 1;
                    memoryIncrease = 2;
                    break;
                case EnumCategory.AcceleratorOptimized:
                    cpuIncrease = 1;
                    memoryIncrease = 1;
                    storageIncrease = 1;
                    gpuIncluded = true;
                    break;
                case EnumCategory.StorageOptimized:
                    sizeIncrease = 1;
                    storageIncrease = 2;
                    break;
                case EnumCategory.HighPerformanceComputing:
                    sizeIncrease = 2;
                    cpuIncrease = 1;
                    memoryIncrease = 1;
                    storageIncrease = 1;
                    break;
                default:
                    break;
            }

            EnumCPUCores cpu = (EnumCPUCores)Enum.Parse(typeof(EnumCPUCores), ((EnumSize)((int)size + sizeIncrease + cpuIncrease)).ToString());
            EnumMemory mem = (EnumMemory)Enum.Parse(typeof(EnumMemory), ((EnumSize)((int)size + sizeIncrease + memoryIncrease)).ToString());
            EnumStorageSize ss = (EnumStorageSize)Enum.Parse(typeof(EnumStorageSize), ((EnumSize)((int)size + sizeIncrease + storageIncrease)).ToString());
            EnumClockSpeed cs = (EnumClockSpeed)Enum.Parse(typeof(EnumClockSpeed), ((EnumSize)((int)size + sizeIncrease + clockSpeedIncrease + cpuIncrease)).ToString());
            EnumNetworkSpeed ns = (EnumNetworkSpeed)Enum.Parse(typeof(EnumNetworkSpeed), ((EnumSize)((int)size + sizeIncrease + networkIncrease)).ToString());
            EnumIOSpeed io = (EnumIOSpeed)Enum.Parse(typeof(EnumIOSpeed), ((EnumSize)((int)size + sizeIncrease + ioSpeedIncrease + storageIncrease)).ToString());
            EnumGPUCores gpu = gpuIncluded ? (EnumGPUCores)Enum.Parse(typeof(EnumGPUCores), ((EnumSize)((int)size + sizeIncrease)).ToString()) : EnumGPUCores.None;

            string name = Enum.GetName(typeof(EnumCategory), category).ToString()[0] + ((int)size + 1).ToString() + networkSign + storageSign + clockSpeedSign;
            string startString = "CloudSimulator.";

            if (resourceType == startString + EnumResourceType.VirtualMachine.ToString())
                obj = new VirtualMachine(cpu, mem, storageType, ss, cs, ns, io, gpu, category, size, name);
            else if (resourceType == startString + EnumResourceType.Database.ToString())
                obj = new Database(cpu, mem, storageType, ss, cs, ns, io, gpu, category, size, name);
            else if (resourceType == startString + EnumResourceType.Kuburnetes.ToString())
                obj = new Kuburnetes(cpu, mem, storageType, ss, cs, ns, io, gpu, category, size, name);
            else 
                obj = null;

            return obj;
        }
    }
}

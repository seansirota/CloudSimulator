using CloudSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSimulator
{
    class VirtualMachine : AVirtualMachine
    {
        //Virtual Machine constructor.
        public VirtualMachine(EnumCPUCores cpu, EnumMemory mem, EnumStorageType tst, EnumStorageSize tss, EnumClockSpeed cs, EnumNetworkSpeed ns, EnumIOSpeed io, EnumGPUCores gpu, EnumCategory ct, EnumSize sz, string name)
        {
            CPUCores = cpu;
            CPUCoreCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.CPU, (int)cpu);
            Memory = mem;
            MemoryCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.Memory, (int)mem);
            TemporaryStorageType = tst;
            TemporaryStorageTypeCost = PriceCalculator.FixedCostCalculator(tst);
            TemporaryStorageSize = tss;
            TemporaryStorageSizeCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.Storage, (int)tss);
            ClockSpeed = cs;
            ClockSpeedCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.ClockSpeed, (int)cs);
            NetworkSpeed = ns;
            NetworkSpeedCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.NetworkSpeed, (int)ns);
            IOSpeed = io;
            IOSpeedCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.IOSpeed, (int)io);
            GPUCores = gpu;
            GPUCoreCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.GPU, (int)gpu);
            Category = ct;
            Size = sz;
            Name = name;
        }

        //Method which uses Virtual Machine constructor and fills out its remaining fields.
        public static VirtualMachine VMBuilder(string? ct, string? sz, bool? networkBoost, bool? storageTypeBoost, bool? clockSpeedBoost, int? hours, EnumStorageType? st, EnumStorageSize? ss, EnumOperatingSystem? os, EnumTransactions? ta)
        {
            VirtualMachine vm = (VirtualMachine)PriceCalculator.GenerateSpecs(typeof(VirtualMachine).ToString(), ct, sz, networkBoost, storageTypeBoost, clockSpeedBoost);

            vm.HoursUsedMonthly = hours;
            vm.StorageType = st;
            vm.StorageTypeCost = PriceCalculator.FixedCostCalculator(st);
            vm.StorageSize = ss;
            vm.StorageSizeCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.Storage, (int)ss);
            vm.OperatingSystem = os;
            vm.TransactionsMonthly = ta;

            vm.TotalInstanceCost = vm.CPUCoreCost + vm.MemoryCost + vm.TemporaryStorageSizeCost + vm.ClockSpeedCost + vm.NetworkSpeedCost + vm.IOSpeedCost + vm.GPUCoreCost;
            vm.TotalStorageCost = vm.StorageSizeCost;            
            vm.TotalOSCost = PriceCalculator.FixedCostCalculator(os);
            vm.TotalTransactionsCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.Transactions, (int)ta);
            vm.HourlyCost = vm.TotalInstanceCost + vm.TotalStorageCost + vm.TotalTransactionsCost;
            vm.MonthlyCost = (double)(vm.HourlyCost * vm.HoursUsedMonthly) + vm.TemporaryStorageTypeCost + vm.StorageTypeCost + vm.TotalOSCost;

            return vm;
        }
    }

    class Database : ADatabase
    {
        //Database constructor.
        public Database(EnumCPUCores cpu, EnumMemory mem, EnumStorageType tst, EnumStorageSize tss, EnumClockSpeed cs, EnumNetworkSpeed ns, EnumIOSpeed io, EnumGPUCores gpu, EnumCategory ct, EnumSize sz, string name)
        {
            CPUCores = cpu;
            CPUCoreCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.CPU, (int)cpu);
            Memory = mem;
            MemoryCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.Memory, (int)mem);
            TemporaryStorageType = tst;
            TemporaryStorageTypeCost = PriceCalculator.FixedCostCalculator(tst);
            TemporaryStorageSize = tss;
            TemporaryStorageSizeCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.Storage, (int)tss);
            ClockSpeed = cs;
            ClockSpeedCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.ClockSpeed, (int)cs);
            NetworkSpeed = ns;
            NetworkSpeedCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.NetworkSpeed, (int)ns);
            IOSpeed = io;
            IOSpeedCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.IOSpeed, (int)io);
            GPUCores = gpu;
            GPUCoreCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.GPU, (int)gpu);
            Category = ct;
            Size = sz;
            Name = name;
        }

        //Method which uses Database constructor and fills out its remaining fields.
        public static Database DBBuilder(string? ct, string? sz, bool? networkBoost, bool? storageTypeBoost, bool? clockSpeedBoost, int? hours, EnumStorageType? st, EnumStorageSize? ss, EnumStorageType? bst, EnumStorageSize? bss)
        {
            Database db = (Database)PriceCalculator.GenerateSpecs(typeof(Database).ToString(), ct, sz, networkBoost, storageTypeBoost, clockSpeedBoost);

            db.HoursUsedMonthly = hours;
            db.StorageType = st;
            db.StorageTypeCost = PriceCalculator.FixedCostCalculator(st);
            db.StorageSize = ss;
            db.StorageSizeCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.Storage, (int)ss);
            db.BackupStorageType = bst;
            db.BackupStorageTypeCost = PriceCalculator.FixedCostCalculator(bst);
            db.BackupStorageSize = bss;
            db.BackupStorageSizeCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.Storage, (int)bss);

            db.TotalInstanceCost = db.CPUCoreCost + db.MemoryCost + db.TemporaryStorageSizeCost + db.ClockSpeedCost + db.NetworkSpeedCost + db.IOSpeedCost + db.GPUCoreCost;
            db.TotalStorageCost = db.StorageSizeCost;
            db.TotalBackupStorageCost = db.BackupStorageSizeCost;
            db.HourlyCost = db.TotalInstanceCost + db.TotalStorageCost + db.TotalBackupStorageCost;
            db.MonthlyCost = (double)(db.HourlyCost * db.HoursUsedMonthly) + db.TemporaryStorageTypeCost + db.StorageTypeCost + db.BackupStorageTypeCost;

            return db;
        }
    }

    class Kuburnetes : AKuburnetes
    {
        //Kuburnetes constructor.
        public Kuburnetes(EnumCPUCores cpu, EnumMemory mem, EnumStorageType tst, EnumStorageSize tss, EnumClockSpeed cs, EnumNetworkSpeed ns, EnumIOSpeed io, EnumGPUCores gpu, EnumCategory ct, EnumSize sz, string name)
        {
            CPUCores = cpu;
            CPUCoreCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.CPU, (int)cpu);
            Memory = mem;
            MemoryCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.Memory, (int)mem);
            TemporaryStorageType = tst;
            TemporaryStorageTypeCost = PriceCalculator.FixedCostCalculator(tst);
            TemporaryStorageSize = tss;
            TemporaryStorageSizeCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.Storage, (int)tss);
            ClockSpeed = cs;
            ClockSpeedCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.ClockSpeed, (int)cs);
            NetworkSpeed = ns;
            NetworkSpeedCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.NetworkSpeed, (int)ns);
            IOSpeed = io;
            IOSpeedCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.IOSpeed, (int)io);
            GPUCores = gpu;
            GPUCoreCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.GPU, (int)gpu);
            Category = ct;
            Size = sz;
            Name = name;
        }

        //Method which uses Kuburnetes constructor and fills out its remaining fields.
        public static Kuburnetes KNBuilder(string? ct, string? sz, bool? networkBoost, bool? storageTypeBoost, bool? clockSpeedBoost, int? hours, EnumStorageType? st, EnumStorageSize? ss, EnumOperatingSystem? os)
        {
            Kuburnetes kn = (Kuburnetes)PriceCalculator.GenerateSpecs(typeof(Kuburnetes).ToString(), ct, sz, networkBoost, storageTypeBoost, clockSpeedBoost);

            kn.HoursUsedMonthly = hours;
            kn.StorageType = st;
            kn.StorageTypeCost = PriceCalculator.FixedCostCalculator(st);
            kn.StorageSize = ss;
            kn.StorageSizeCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.Storage, (int)ss);
            kn.OperatingSystem = os;

            kn.TotalInstanceCost = kn.CPUCoreCost + kn.MemoryCost  + kn.TemporaryStorageSizeCost + kn.ClockSpeedCost + kn.NetworkSpeedCost + kn.IOSpeedCost + kn.GPUCoreCost;
            kn.TotalStorageCost = kn.StorageSizeCost;
            kn.TotalOSCost = PriceCalculator.FixedCostCalculator(os);
            kn.HourlyCost = kn.TotalInstanceCost + kn.TotalStorageCost;
            kn.MonthlyCost = (double)(kn.HourlyCost * kn.HoursUsedMonthly) + kn.TemporaryStorageTypeCost + kn.StorageTypeCost + kn.TotalOSCost;

            return kn;
        }
    }

    class ExternalStorage : AExternalStorage
    {
        //External Storage constructor.
        public ExternalStorage(EnumStorageType? st, EnumStorageSize? ss, EnumTransactions? ta, int? hours)
        {
            HoursUsedMonthly = hours;
            StorageType = st;
            StorageTypeCost = PriceCalculator.FixedCostCalculator(st);
            StorageSize = ss;
            StorageSizeCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.Storage, (int)ss);
            TransactionsMonthly = ta;

            TotalStorageCost = StorageSizeCost;
            TotalTransactionsCost = PriceCalculator.CostPerUnitCalculator(EnumComponent.Transactions, (int)ta);
            HourlyCost = TotalStorageCost + TotalTransactionsCost;
            MonthlyCost = (double)(HourlyCost * HoursUsedMonthly) + StorageTypeCost;
        }
    }
}
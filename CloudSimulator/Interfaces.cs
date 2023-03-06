using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSimulator
{
    //Generic interface which all resources inherit.
    interface IResource
    {
        public int ResourceID { get; set; }
        public int? HoursUsedMonthly { get; set; }
        public double HourlyCost { get; set; }
        public double MonthlyCost { get; set; }
    }

    //Contains properties related to hard drive storage.
    interface IStorage
    {
        public EnumStorageType? StorageType { get; set; }
        public double StorageTypeCost { get; set; }
        public EnumStorageSize? StorageSize { get; set; }
        public double StorageSizeCost { get; set; }
        public double TotalStorageCost { get; set; }
    }

    //Contains properties related to virtual machine hardware.
    interface IInstanceType
    {
        public EnumCPUCores? CPUCores { get; set; }
        public double CPUCoreCost { get; set; }
        public EnumMemory? Memory { get; set; }
        public double MemoryCost { get; set; }
        public EnumStorageType? TemporaryStorageType { get; set; }
        public double TemporaryStorageTypeCost { get; set; }
        public EnumStorageSize? TemporaryStorageSize { get; set; }
        public double TemporaryStorageSizeCost { get; set; }
        public EnumClockSpeed? ClockSpeed { get; set; }
        public double ClockSpeedCost { get; set; }
        public EnumNetworkSpeed? NetworkSpeed { get; set; }
        public double NetworkSpeedCost { get; set; }
        public EnumIOSpeed? IOSpeed { get; set; }
        public double IOSpeedCost { get; set; }
        public EnumGPUCores? GPUCores { get; set; }
        public double GPUCoreCost { get; set; }
        public double TotalInstanceCost { get; set; }
        public EnumCategory? Category { get; set; }
        public EnumSize? Size { get; set; }
        public string Name { get; set; }
    }

    //Contains properties related to an operating system.
    interface IOperatingSystem
    {
        public EnumOperatingSystem? OperatingSystem { get; set; }
        public double TotalOSCost { get; set; }
    }

    //Contains properties related to read/write transactions.
    interface ITransactions
    {
        public EnumTransactions? TransactionsMonthly { get; set; }
        public double TotalTransactionsCost { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSimulator
{
    //Generic resource abstract class.
    abstract class AResource : IResource
    {
        public int ResourceID { get; set; }
        public int? HoursUsedMonthly { get; set; }
        public double HourlyCost { get; set; }
        public double MonthlyCost { get; set; }
    }

    //Virtual Machine abstract class. Contains all Virtual Machine fields.
    abstract class AVirtualMachine : AResource, IStorage, IInstanceType, IOperatingSystem, ITransactions
    {
        public EnumStorageType? StorageType { get; set; }
        public double StorageTypeCost { get; set; }
        public EnumStorageSize? StorageSize { get; set; }
        public double StorageSizeCost { get; set; }
        public double TotalStorageCost { get; set; }
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
        public EnumOperatingSystem? OperatingSystem { get; set; }
        public double TotalOSCost { get; set; }
        public EnumTransactions? TransactionsMonthly { get; set; }
        public double TransactionCost { get; set; }
        public double TotalTransactionsCost { get; set; }
    }

    //Database abstract class. Contains all Database fields.
    abstract class ADatabase : AResource, IStorage, IInstanceType
    {
        public EnumStorageType? StorageType { get; set; }
        public double StorageTypeCost { get; set; }
        public EnumStorageSize? StorageSize { get; set; }
        public double StorageSizeCost { get; set; }
        public double TotalStorageCost { get; set; }
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
        public EnumStorageType? BackupStorageType { get; set; }
        public double BackupStorageTypeCost { get; set; }
        public EnumStorageSize? BackupStorageSize { get; set; }
        public double BackupStorageSizeCost { get; set; }
        public double TotalBackupStorageCost { get; set; }
    }

    //Kuburnetes abstract class. Contains all Kuburnetes fields.
    abstract class AKuburnetes : AResource, IStorage, IInstanceType, IOperatingSystem
    {
        public EnumStorageType? StorageType { get; set; }
        public double StorageTypeCost { get; set; }
        public EnumStorageSize? StorageSize { get; set; }
        public double StorageSizeCost { get; set; }
        public double TotalStorageCost { get; set; }
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
        public EnumOperatingSystem? OperatingSystem { get; set; }
        public double TotalOSCost { get; set; }
    }

    //External Storage abstract class. Contains all External Storage fields.
    abstract class AExternalStorage : AResource, IStorage, ITransactions
    {
        public EnumStorageType? StorageType { get; set; }
        public double StorageTypeCost { get; set; }
        public EnumStorageSize? StorageSize { get; set; }
        public double StorageSizeCost { get; set; }
        public double TotalStorageCost { get; set; }
        public EnumTransactions? TransactionsMonthly { get; set; }
        public double TotalTransactionsCost { get; set; }
    }
}
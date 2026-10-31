using ApplianceRepairSystem.Interfaces;

namespace ApplianceRepairSystem.Models
{

    public abstract class Appliance : IAppliance
    {
        private readonly string _serialNumber;
        private string _brand;
        private string _status;
        protected decimal _baseRepairCost; 

        public string SerialNumber => _serialNumber; 

        public string Brand
        {
            get => _brand;
            set => _brand = value;
        }

        public string Status
        {
            get => _status;
            set => _status = value;
        }

        protected Appliance(string serialNumber, string brand, decimal baseRepairCost)
        {
            _serialNumber = serialNumber;
            _brand = brand;
            _baseRepairCost = baseRepairCost;
            _status = "Under maintenance";
        }

        public abstract decimal CalculateRepairCost();

        public virtual void DisplayInfo()
        {
            System.Console.WriteLine($"[Device ID: {_serialNumber}] | Brand: {_brand} | Status: {_status}");
        }
    }
}
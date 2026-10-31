using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplianceRepairSystem.Interfaces
{
    public interface IAppliance
    {
        string SerialNumber { get; }

        string Brand { get; set; }

        string Status { get; set; }

        void DisplayInfo();
    }
}

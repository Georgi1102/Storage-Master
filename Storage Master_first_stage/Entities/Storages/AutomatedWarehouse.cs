using Storage_Master_first_stage.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Master_first_stage.Entities.Storages
{
    public class AutomatedWarehouse : Storage
    {
        private const int capacity = 1;
        private const int slots = 2;
        private static Vehicle[] Warehousevehicles = { new Truck() };

        public AutomatedWarehouse(string name) 
            : base(name, capacity, slots, Warehousevehicles)
        {
        }
    }
}

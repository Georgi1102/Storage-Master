using Storage_Master_first_stage.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Master_first_stage.Entities.Storages
{
    public class Warehouse : Storage
    {
        private const int capacity = 10;
        private const int slots = 10;
        private static Vehicle[] Warehousevehicles = { new Semi(),
            new Semi(),
            new Semi()
        };

        public Warehouse(string name) 
            : base(name, capacity, slots, Warehousevehicles)
        {
        }
    }
}

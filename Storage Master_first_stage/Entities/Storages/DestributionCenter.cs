using Storage_Master_first_stage.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Master_first_stage.Entities.Storages
{
    [Serializable]
    public class DestributionCenter : Storage
    {
        private const int capacity = 2;
        private const int slots = 5;
        private static Vehicle[] Destributionvehicles = { new Van(),
            new Van(),
            new Van()
        };

        public DestributionCenter(string name)
            : base(name, capacity, slots, Destributionvehicles)
        {
        }
    }
}

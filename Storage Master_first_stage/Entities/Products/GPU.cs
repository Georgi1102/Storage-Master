using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace Storage_Master_first_stage.Entities.Products

{
    [Serializable]
    public class GPU : Product
    {
        private const double GpuWeight = 0.7;

        public GPU(double price): base(price, GpuWeight)
        {

        }
    }
}

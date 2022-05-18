using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Master_first_stage.Entities.Products
{
    [Serializable]
    public class Ram : Product
    {
        private const double RamWeight = 0.1;

        public Ram(double price) : base(price, RamWeight)
        {
        }
    }
}

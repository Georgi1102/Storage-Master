using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Master_first_stage.Entities.Products
{
    public class GPU : Product
    {
        private const double GpuWeight = 0.7;

        public GPU(double price): base(price, GpuWeight)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Master_first_stage.Entities.Products
{
    public class HardDrive : Product
    {
        private const double HardDriveWeight = 1;

        public HardDrive(double price) : base(price, HardDriveWeight)
        {
        }
    }
}

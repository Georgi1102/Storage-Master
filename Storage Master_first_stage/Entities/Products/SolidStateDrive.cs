using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Master_first_stage.Entities.Products
{
   public class SolidStateDrive : Product
    {
        private const double SolidStateDriveWeight = 0.2;

        public SolidStateDrive (double price) : base(price, SolidStateDriveWeight)
        {
        }
    }
}

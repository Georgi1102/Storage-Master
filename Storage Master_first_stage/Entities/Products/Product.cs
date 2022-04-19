using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Master_first_stage.Entities.Products
{
    public abstract class Product
    {
        private double price;

        protected Product(double price, double weight)
        {
            this.Price = price;
            this.Weight = weight;
        }

        public double Price { get => this.price;

            private set
            {
                if (value < 0)
                {
                    throw new InvalidCastException("Price can not be negative!");
                }

                this.price = value;
            }
        }

        public double Weight { get; private set; }
        
    }
}

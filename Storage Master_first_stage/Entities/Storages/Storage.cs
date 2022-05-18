using Storage_Master_first_stage.Entities.Products;
using Storage_Master_first_stage.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Master_first_stage.Entities.Storages
{
    [Serializable]
    public abstract class Storage
    {
        private Vehicle[] garage;
        private List<Product> products;

        protected Storage(string name, int capacity, int garageSlots,
            IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;
            this.garage = new Vehicle[this.GarageSlots];
            this.products = new List<Product>();

            this.FillGarage(vehicles);
        }

        private void FillGarage(IEnumerable<Vehicle> vehicles)
        {
            int index = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                this.garage[index++] = vehicle;
            }
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int GarageSlots { get; private set; }

        public bool IsFull => this.products.Sum(p => p.Weight) >= this.Capacity;

        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(this.garage);

        //this is string and can use only .AsReadOnly
        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();


        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= this.GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }

            Vehicle vehicle = this.garage[garageSlot];
            return vehicle;
        }

        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = this.GetVehicle(garageSlot);
            int deliveryLocationGarageIndex = deliveryLocation.AddVehicle(vehicle);

            this.garage[garageSlot] = null;

            return deliveryLocationGarageIndex;
        }

        public int AddVehicle(Vehicle vehicle)
        {
            int index = Array.IndexOf(this.garage, null);

            if (index == -1)
            {
                throw new InvalidOperationException("No room in garage!");
            }

            this.garage[index] = vehicle;

            return index;
        }

        public int UnloadVechicle(int garageSlot)
        {
            if (this.IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }

            Vehicle vehicle = this.GetVehicle(garageSlot);
            int unloadedProducts = 0;

            while (!vehicle.IsEmpty && !this.IsFull)
            {
                Product product = vehicle.Unload();
                this.products.Add(product);
                unloadedProducts++;
            }

            return unloadedProducts;
        }
    }
}

using Storage_Master_first_stage.Entities.Products;
using Storage_Master_first_stage.Entities.Storages;
using Storage_Master_first_stage.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

namespace Storage_Master_first_stage
{

    public class StorageMaster
    {
        private Dictionary<string, Stack<Product>> products;
        private Dictionary<string, Storage> storages;
        private Vehicle currentVehicle;
        private const string path = "D:\\dataStorage.txt";
        private const string pathToSave = "D:\\FullStorageData.txt";

        public Dictionary<string, Stack<Product>> Products { get => products; set => products = value; }
        public Dictionary<string, Storage> Storages { get => storages; set => storages = value; }


        public StorageMaster()
        {
            this.Products = new Dictionary<string, Stack<Product>>();
            this.Storages = new Dictionary<string, Storage>();
        }

        public string AddProduct(string type, double price)
        {
            Product product = CreateProduct(type, price);

            Serialize(product);        

            if (Products.ContainsKey(type) == false)
            {
                Products.Add(type, new Stack<Product>());
            }

            Products[type].Push(product);

            string result = $"Added {type} to pool";
            return result;
        }

        public string RegisterStorage(string type, string name)
        {
            Storage storage = CreateStorage(type, name);

            Serialize(storage);

            this.storages.Add(name, storage);

            string result = $"Registered storage: {name}";
            return result;
        }

        public string SelectVehicle(string storageName, int garageSlots)
        {
            Storage storage = this.storages[storageName];
            Vehicle vehicle = storage.GetVehicle(garageSlots);
            this.currentVehicle = vehicle;

            string result = $"Selected {vehicle.GetType().Name}";
            return result;
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {

            int loadedProductsCount = 0;
            int productCount = productNames.Count();
            foreach (string productName in productNames)
            {
                if (this.Products.ContainsKey(productName) && Products[productName].Count > 0)
                {
                    Product product = this.Products[productName].Pop();
                    this.currentVehicle.LoadProduct(product);
                    loadedProductsCount++;
                }

                else
                {
                    throw new InvalidOperationException($"{productName} is out of stock");
                }
            }

            string result = $"Loaded {loadedProductsCount}/{productCount} products into {this.currentVehicle.GetType().Name}";
            return result;
        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            if (this.storages.ContainsKey(sourceName) == false)
            {
                throw new InvalidOperationException("Invalid source storage!");
            }

            if (this.storages.ContainsKey(destinationName) == false)
            {
                throw new InvalidOperationException("Invalid destination storage!");
            }

            Storage sourceStorage = this.storages[sourceName];
            Vehicle vehicle = sourceStorage.GetVehicle(sourceGarageSlot);
            Storage destinationStorage = this.storages[destinationName];
            int destinationGarageSlot = sourceStorage.SendVehicleTo(sourceGarageSlot, destinationStorage);

            sourceStorage.SendVehicleTo(sourceGarageSlot, destinationStorage);

            string result = $"Sent {vehicle.GetType().Name} to {destinationName} (slot {destinationGarageSlot})";
            return result;
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Storage storage = this.storages[storageName];
            Vehicle vehicle = storage.GetVehicle(garageSlot);
            int productsInVehicle = vehicle.Trunk.Count;
            int unloadedProductsCount = storage.UnloadVechicle(garageSlot);

            string result = $"Unloaded {unloadedProductsCount}/{productsInVehicle} products at {storageName}";

            return result;
        }

        public string GetStorageStatus(string storageName)
        {
            Storage storage = this.storages[storageName];
            Dictionary<string, int> productsAndCounts = new Dictionary<string, int>();

            foreach (Product product in storage.Products)
            {
                string type = product.GetType().Name;

                if (!productsAndCounts.ContainsKey(type))
                {
                    productsAndCounts.Add(type, 0);
                }

                productsAndCounts[type]++;
            }

            string[] sortedProducts = productsAndCounts.OrderByDescending(p => p.Value).
                  ThenBy(p => p.Key).
                  Select(s => $"{s.Key} ({s.Value})").ToArray();

            string stock = $"Stock ({storage.Products.Sum(p => p.Weight)}/{storage.Capacity}): [{string.Join(", ", sortedProducts)}]";

            string[] garageNames =
                storage.
                Garage.
                Select(g =>
               {
                   string result;
                   if (g == null)
                   {
                       result = "empty";
                   }
                   else
                   {
                       result = g.GetType().Name;
                   }

                   return result;
               }).ToArray();

            string garageLine = $"Garage: [{string.Join("|", garageNames)}]";

            string result = stock + Environment.NewLine + garageLine;

            return result;
        }

        public string GetSummary()
        {
            var sorted = this.storages.
                OrderByDescending(s => s.Value.Products.Sum(p => p.Price)).
                ToDictionary(x => x.Key, x => x.Value);

            StringBuilder sb = new StringBuilder();

            foreach (var storage in sorted)
            {
                sb.AppendLine($"{storage.Key}:");
                double storagePrice = storage.Value.Products.Sum(p => p.Price);
                sb.AppendLine($"Storage worth: ${storagePrice:f2}");
            }

            string result = sb.ToString().Trim();

            return result;
        }

        private Product CreateProduct(string type, double price)
        {
            Product product = null;

            switch (type)
            {
                case "Ram":
                    product = new Ram(price);
                    break;

                case "GPU":
                    product = new GPU(price);
                    break;

                case "HardDrive":
                    product = new HardDrive(price);
                    break;

                case "SolidStateDrive":
                    product = new SolidStateDrive(price);
                    break;

                default:
                    throw new InvalidOperationException("Invalid product type!");

            }

            return product;
        }

        private Storage CreateStorage(string type, string name)
        {
            Storage storage = null;

            switch (type)
            {
                case "AutomatedWarehouse":
                    storage = new AutomatedWarehouse(name);
                    break;

                case "DistributionCenter":
                    storage = new DestributionCenter(name);
                    break;

                case "Warehouse":
                    storage = new Warehouse(name);
                    break;

                default:
                    throw new InvalidOperationException("Invalid storage type!");

            }

            return storage;
        }

        private void Serialize<T>(T toSerObj)
        {
            IFormatter objFormatter = new BinaryFormatter();

            Stream objStream = new FileStream(path,
             FileMode.Create,
             FileAccess.ReadWrite,
             FileShare.None);

#pragma warning disable SYSLIB0011 // Type or member is obsolete
            objFormatter.Serialize(objStream, toSerObj);
#pragma warning restore SYSLIB0011 // Type or member is obsolete

            objStream.Close();

            string[] lines = System.IO.File.ReadAllLines(path);

            Save(lines);
        }

        private void Save(string[] lines)
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine("D:\\", "FullStorageData.txt"), true))
            {
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                }
                outputFile.WriteLine("-------");
                outputFile.Close();
            }
        }
    }
}

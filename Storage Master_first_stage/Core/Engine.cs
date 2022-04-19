using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage_Master_first_stage.Core
{
    public class Engine
    {
        private StorageMaster storageMaster;
        private bool isRunning;
        private StringBuilder outputs;

        public Engine()
        {
            this.storageMaster = new StorageMaster();
            this.outputs = new StringBuilder();
        }

        public void Run()
        {
            this.isRunning = true;
            while (isRunning)
            {
                try
                {
                    string line = Console.ReadLine();

                    string result = this.ProcessComand(line);
                    outputs.AppendLine(result);
                }
                catch (InvalidOperationException e)
                {
                    outputs.AppendLine($"Error: {e.Message}");

                }
            }

            Console.Clear();
            Console.WriteLine(outputs.ToString().Trim());
        }

        private string ProcessComand(string line)
        {
            string[] tokens = line.Split();
            string command = tokens[0];
            string output = "";
            string storageName;
            int garageSlot;
            switch (command)
            {
                case "AddProduct":
                    string productType = tokens[1];
                    double price = double.Parse(tokens[2]);
                    output = storageMaster.AddProduct(productType, price);
                    break;

                case "RegisterStorage":
                    string storageType = tokens[1];
                    string name = tokens[2];
                    output = storageMaster.RegisterStorage(storageType, name);
                    break;

                case "SelectVehicle":
                    storageName = tokens[1];
                    garageSlot = int.Parse(tokens[2]);
                    output = storageMaster.SelectVehicle(storageName, garageSlot);
                    break;

                case "LoadVehicle":
                    string[] productNames = tokens.Skip(1).ToArray();
                    output = storageMaster.LoadVehicle(productNames);
                    break;

                case "SendVehicleTo":
                    string sourceName = tokens[1];
                    int sourceGarageSlot = int.Parse(tokens[2]);
                    string destinationName = tokens[3];
                    output = storageMaster.SendVehicleTo(sourceName, sourceGarageSlot, destinationName);
                    break;

                case "UnloadVehicle":
                    storageName = tokens[1];
                    garageSlot = int.Parse(tokens[2]);
                    output = storageMaster.UnloadVehicle(storageName, garageSlot);
                    break;

                case "GetStorageStatus":
                    storageName = tokens[1];
                    output = storageMaster.GetStorageStatus(storageName);
                    break;

                case "END":
                    isRunning = false;
                    output = storageMaster.GetSummary();
                    break;
                default:
                    break;
            }

            return output;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurman_A2
{
    class Car
    {
        public string Manufacturer { get; }
        public int Make { get; }
        public string Model { get; }
        public static int VI_NUMBER = 1021;
        public int VIN { get; }
        public double BasePrice { get; }
        public CarType Type { get; }

        public Car(string manufacturer, int make, string model, double basePrice, CarType type)
        {
            this.Manufacturer = manufacturer;

            this.Make = make;

            this.Model = model;
            this.BasePrice = basePrice;
            this.Type = type;
            VIN = VI_NUMBER + 100;
            VI_NUMBER = VIN;
        }

        public static bool operator ==(Car first, Car second)
        {
            

            if ((first.Manufacturer == second.Manufacturer) && (first.Model == second.Model) && (first.Type == second.Type))
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public static bool operator !=(Car first, Car second)
        {
            

            if ((first.Manufacturer != second.Manufacturer) && (first.Model != second.Model) && (first.Type != second.Type))
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }

        public override string ToString()
        {
            
            return $"{VIN}: {this.Manufacturer}, {this.Make}, {this.Model}, {this.BasePrice}, {this.Type}";
        }

        
    }
}

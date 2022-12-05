using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gurman_A2
{
    class Dealership
    {
        private static string fetchData = "Dealership_Cars.txt";
        private string ID { get; }
        private string Name { get; }
        private string Address { get; }

        public List<Car> CarList;


        public Dealership(string ID, string name, string address)
        {
            this.CarList = new List<Car>();
            this.ID = ID;
            this.Name = name;
            this.Address = address;
            

            using (StreamReader reader = new StreamReader(fetchData))

            {
                string vehicleList;



                while ((vehicleList = reader.ReadLine()) != null)
                {
                    string[] values = vehicleList.Split(',');

                    if (this.ID == values[0])
                    {
                        string manufacturer = values[1];
                        int make = Convert.ToInt32(values[2]);
                        string model = values[3];
                        double basePrice = double.Parse(values[4]);

                        CarType type = (CarType)Enum.Parse(typeof(CarType), values[5]);

                        Car Car = new Car(manufacturer, make, model, basePrice, type);
                       
                        this.CarList.Add(Car);
                    }
                    
                }
                reader.Close();
            }
            

        }
        public void ShowCars()
        {
            foreach (Car car in this.CarList)
            {
                Console.WriteLine(car.ToString());
            }

        }

        public void ShowCars(string manufacturer)
        {
            foreach (Car car in this.CarList)
            {
                if (manufacturer == car.Manufacturer)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(car.ToString());

                }
            }
        }

        public void ShowCars(Car carToBeSearched)
        {
            foreach (Car cars in this.CarList)
            {
                if (cars == carToBeSearched)
                {
                    Console.WriteLine(cars.ToString());
                    break;
                }
                
                if (cars != carToBeSearched)
                {
                    Console.WriteLine("None");
                    break;
                }
               
            }


        }


        public override string ToString()
        {
            
            return $"\n{this.ID}, {this.Name}, {this.Address}\n";
            
        }



    }
}

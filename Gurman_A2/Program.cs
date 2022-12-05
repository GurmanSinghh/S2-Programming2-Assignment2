namespace Gurman_A2
{
    public class Program
    {
        static void TestDealership()
        {
            Console.WriteLine("Assignment 2 Output");

            Dealership dealership1 = new Dealership("D1_22_T501", "The Six Cars", "1 Main Street, Toronto");
            Console.WriteLine(dealership1.ToString());
            dealership1.ShowCars();

            Dealership dealership2 = new Dealership("D2_22_B321", "Car Street", "5th avenue, Brampton");
            Console.WriteLine(dealership2.ToString());
            dealership2.ShowCars();

            Console.WriteLine("\nToyota Cars available in Dealership 1");
            
            dealership1.ShowCars("Toyota");

            Console.WriteLine("\nToyota Cars available in Dealership 2");
            
            dealership2.ShowCars("Toyota");

            Car favCar = new Car("Hyundai", 2020, "Elantra", 30000.00, CarType.Sedan);
            Console.WriteLine($"\nCar to match : ");
            Console.WriteLine($"{favCar.ToString()}");

            Console.WriteLine("\nMatching car(s) from Dealership 1 : ");
            dealership1.ShowCars(favCar);

            Console.WriteLine("\nMatching car(s) from Dealership 2 : ");
            Console.WriteLine(" ");
            dealership2.ShowCars(favCar);

            //favCar = new Car("Honda", 2018, "Civic", 20000.00, CarType.SUV, CarSpecifications.FogLights | CarSpecifications.TintendGlasses);
            favCar = new Car("Honda", 2018, "Civic", 20000.00, CarType.SUV);

            Console.WriteLine($"\nCar to match : ");
            Console.WriteLine($"{favCar.ToString()}");

            Console.WriteLine("\nMatching car(s) from Dealership 1 : ");
            dealership1.ShowCars(favCar);

            Console.WriteLine("\nMatching car(s) from Dealership 2 : ");
            
            dealership2.ShowCars(favCar);

            Console.WriteLine("\nList of similiar car models available in both dealership : ");

            foreach (Car firstCar in dealership1.CarList)
            {
                foreach (Car secondsCar in dealership2.CarList)
                {
                    if (firstCar == secondsCar)
                    {
                        Console.WriteLine($"Dealership 1 : ");
                        Console.WriteLine($"{firstCar.ToString()}");
                        Console.WriteLine($"Dealership 2 : ");
                        Console.WriteLine($"{secondsCar.ToString()}");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            TestDealership();
        }
    }
}

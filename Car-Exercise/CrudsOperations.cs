using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Car_Exercise;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace Car_Exercise
{
    internal class CrudsOperations :Car 
    {
        private MyDbContext context;

        public CrudsOperations(MyDbContext dbContext)
        {
            context = dbContext;
        }
        public void CreateCarData()
        {
            Console.WriteLine("Enter Car Information");
            Console.Write("Brand: ");
            string brand = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Car newCar = new Car
            {
                Brand = brand,
                Model = model,
                Year = year
            };

            context.Cars.Add(newCar);
            context.SaveChanges();

            Console.WriteLine("Car information has been added successfully to the Database");
        }
        public void DeleteCarData()
        {
            Console.WriteLine("Enter the Car's Id you want to Delete it:");
            string IdCar= Console.ReadLine();
            if (int.TryParse(IdCar, out int deleteCarId))
            {

                Car removeCar = context.Cars.FirstOrDefault(x => x.Id == deleteCarId);
                if (removeCar != null)
                {
                    context.Cars.Remove(removeCar);
                    context.SaveChanges();
                    Console.WriteLine("Car deleted successfully");
                }
                else
                {
                    Console.WriteLine("Car not found");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid Car Id.");
            }
        }

        public void GetCarData() {

            List<Car> Result = context.Cars.ToList();
            printList(Result);

         
        }
        public void UpdateCarData()
        {
            Console.WriteLine("Enter the Car's Id you want to Update it:");
            string IdCar = Console.ReadLine();
            if (int.TryParse(IdCar, out int updateCarId))
            {
                Car updateCar = context.Cars.FirstOrDefault(x => x.Id == updateCarId);
                if (updateCar != null)
                {
                    Console.WriteLine($"Current Brand: {updateCar.Brand}");
                    Console.Write("Enter New Brand (press Enter to keep current value): ");
                    string newBrand = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newBrand))
                    {
                        updateCar.Brand = newBrand;
                    }
                    Console.WriteLine($"Current Model: {updateCar.Model}");
                    Console.Write("Enter New Model (press Enter to keep current value): ");
                    string newModel = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newModel))
                    {
                        updateCar.Model = newModel;
                    }

                    Console.WriteLine($"Current Year: {updateCar.Year}");
                    Console.Write("Enter New Year (press Enter to keep current value): ");
                    string newYear = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newYear))
                    {
                        if (int.TryParse(newYear, out int UpdateYear))
                        {
                            updateCar.Year = UpdateYear;
                        }

                        else { Console.WriteLine("You Entered unvalid value"); }


                        
                    }
                   
                    context.Cars.Update(updateCar);
                    context.SaveChanges();
                    Console.WriteLine("Car information updated successfully");

                }
                else
                {
                    Console.WriteLine("Car not found");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid Car Id.");
            }
        }

        public void printList(List<Car> list)
        {
            Console.WriteLine("Id".PadRight(15) + "Brand".PadRight(15) + "Model".PadRight(15) + "Year".PadRight(15));
            Console.WriteLine("--------------------------------------------------------");

            foreach (var item in list)
            {
                Console.WriteLine(item.Id.ToString().PadRight(15) + item.Brand.PadRight(15) + item.Model.ToString().PadRight(15) + item.Year.ToString().PadRight(15));
            }
            Console.WriteLine("Press any key to return to the main Menu");
            Console.ReadKey(); // Pause to display the items before clearing the console
        }
        public int GetNumberOfCars()
        {
          
            int totalCars = context.Cars.Count();
            return totalCars;
        }
    }
}

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            //ColorTest();
            //BrandTest();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result.Success)
            {

                foreach (var brand in brandManager.GetAll().Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
                Console.WriteLine();
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            if (result.Success)
            {

                foreach (var color in colorManager.GetAll().Data)
                {
                    Console.WriteLine(color.ColorName);
                }
                Console.WriteLine();
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            Car car1 = new Car {  CarId =2004, BrandId=4, ColorId=10, ModelYear="2011", DailyPrice = 350, Descriptions="BMW 116i" };   

            var result = carManager.Update(car1);
            if (result.Success)
            {

                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.CarName + " - " + car.BrandName);

                }
                Console.WriteLine();
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           // CarTest();
             BrandTest();
        }

        private static void BrandTest()
        {
            BrandManager categoryManager = new BrandManager(new EfBrandDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager productManager = new CarManager(new EfCarDal());

           // foreach (var product in productManager.GetCarDetails())
            //{
               // Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            //}
        }
    }
}

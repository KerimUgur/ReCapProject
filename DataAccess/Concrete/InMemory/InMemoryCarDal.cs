using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, CategoryId=1, BrandId=1, ColorId=1, DailyPrice=200, Description="2021 model Fiat  ", ModelYear=2021},
                new Car{CarId=2, CategoryId=2, BrandId=3, ColorId=2, DailyPrice=500, Description="2021 model Peugeot ", ModelYear=2021},
                new Car{CarId=3, CategoryId=2, BrandId=5, ColorId=3, DailyPrice=2000, Description="2021 model Bmw ", ModelYear=2021},
                new Car{CarId=4, CategoryId=3, BrandId=4, ColorId=4, DailyPrice=4000, Description="2021 model Porsche ", ModelYear=2021},
                new Car{CarId=5, CategoryId=3, BrandId=6, ColorId=5, DailyPrice=100, Description="2021 model Renault ", ModelYear=2021},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int categoryId)
        {
            return _cars.Where(c => c.CategoryId == categoryId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CategoryId = car.CategoryId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}

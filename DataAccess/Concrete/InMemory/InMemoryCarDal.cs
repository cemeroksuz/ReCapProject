using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId =1, BrandId=1, ColorId=2, ModelYear="2005", DailyPrice=120000, Descriptions="Toyota Corolla" },
                new Car{CarId =2, BrandId=2, ColorId=1, ModelYear="2011", DailyPrice=350000, Descriptions="Wolksvagen Passat" },
                new Car{CarId =3, BrandId=3, ColorId=4, ModelYear="2021", DailyPrice=450000, Descriptions="Fiar Egea Cross" },
                new Car{CarId =4, BrandId=2, ColorId=3, ModelYear="2006", DailyPrice=95000, Descriptions="Wolksvagen Golf" },
                new Car{CarId =5, BrandId=4, ColorId=1, ModelYear="2007", DailyPrice=125000, Descriptions="Ford Focus" },
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

        public Car Get(Expression<Func<Car, bool>> filter)
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

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdete.BrandId = car.BrandId;
            carToUpdete.ColorId = car.ColorId;
            carToUpdete.ModelYear = car.ModelYear;
            carToUpdete.DailyPrice = car.DailyPrice;
            carToUpdete.Descriptions = car.Descriptions;
        

        }
    }
}

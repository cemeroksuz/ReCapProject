using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class CarManager : ICarService
	{
		ICarDal _carDal;

		public CarManager(ICarDal carDal)
		{
			_carDal = carDal;
		}

		public void Add(Car car)
		{
			
			if(car.DailyPrice>0)
			{
				_carDal.Add(car);
			}
			else
				Console.WriteLine("günlük fiyatı 0'dan büyük giriniz!");
		}

		public void Update(Car car)
		{
			_carDal.Update(car);
		}

		public void Delete(Car car)
		{
			_carDal.Delete(car);
		}

		public List<Car> GetAll()
		{
			return _carDal.GetAll();
		}
		public List<Car> GetById(int Id)
		{
			return _carDal.GetAll(c => c.Id == Id);
		}
		
		public List<Car> GetCarsByBrandId(int id)
		{
			return _carDal.GetAll(c => c.BrandId == id);
		}

		public List<Car> GetCarsByColorId(int id)
		{
			return _carDal.GetAll(c => c.BrandId == id);
		}

		public List<CarDetailDto> GetCarDetails()
		{
			return _carDal.GetCarDetails();
		}
	}
}

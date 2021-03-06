using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface ICarService
	{
		void Add(Car car);
		void Update(Car car);
		void Delete(Car car);
		List<Car> GetAll();
		List<Car> GetById(int Id);
		List<Car> GetCarsByColorId(int id);
		List<Car> GetCarsByBrandId(int id);
		List<CarDetailDto> GetCarDetails();
	}
}

using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class BrandManager : IBrandService
	{
		IBrandDal _brandDal;

		public BrandManager(IBrandDal brandDal)
		{
			_brandDal = brandDal;
		}

		public void Add(Brand brand)
		{
			if (brand.Name.Length >= 2)
				_brandDal.Add(brand);
			else
				Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır.");
		}

		public void Update(Brand brand)
		{
			if (brand.Name.Length >= 2)
				_brandDal.Update(brand);
			else
				Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır.");
		}

		public void Delete(Brand brand)
		{
			_brandDal.Delete(brand);
		}

		public List<Brand> GetAll()
		{
			return _brandDal.GetAll();
		}

		public Brand GetById(int id)
		{
			return _brandDal.Get(b => b.Id == id);
		}
		
	}
}
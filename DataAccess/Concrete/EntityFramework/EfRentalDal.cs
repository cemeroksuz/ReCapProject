using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<CarRentalDetailDto> GetCarRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from ca in context.Cars
                             join re in context.Rentals
                                 on ca.CarId equals re.CarId
                             join cu in context.Customers
                                 on re.CustomerId equals cu.CustomerId
                             join u in context.Users
                                 on cu.UserId equals u.UserId
                             join br in context.Brands
                                 on ca.BrandId equals br.BrandId
                             join co in context.Colors
                                 on ca.ColorId equals co.ColorId

                             select new CarRentalDetailDto
                             {
                                 RentalId = re.RentalId,
                                 CustomerFirstName = u.FirstName,
                                 CustomerLastName = u.LastName,
                                 CarName = ca.Descriptions,
                                 BrandName = br.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = ca.DailyPrice,
                                 CustomerCompanyName = cu.CompanyName,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}

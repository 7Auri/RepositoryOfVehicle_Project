using RepositoryOfVehicle.Core.DataAccess.EntityFramework;
using RepositoryOfVehicle.DataAccess.Abstract;
using RepositoryOfVehicle.Entities.Concrete;
using RepositoryOfVehicle.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfVehicle.DataAccess.Concrete.EntityFramework
{
   public class EfCarDal: EfEntityRepositoryBase<Car, VehicleDbContext>, ICarDal
    {
        

        public List<CarColorDetailsDto> GetCarColorDetailsDto(Expression<Func<CarColorDetailsDto, bool>> filter )
        {
            using (VehicleDbContext context = new ())
            {
                var result = from car in context.Cars
                             join c in context.Colors
                             on car.Color.Id equals c.Id
                             
                             select new CarColorDetailsDto
                             {
                                 ColorId=car.Color.Id,
                                 CarId = car.Id,
                                 ColorName = c.ColorName,
                                 CarName=car.Name,
                                 
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

       
    }
}

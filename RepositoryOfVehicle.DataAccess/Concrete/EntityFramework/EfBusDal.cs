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
   public class EfBusDal : EfEntityRepositoryBase<Bus, VehicleDbContext>, IBusDal
    {
        public List<BusColorDetailsDto> GetBusColorDetailsDto(Expression<Func<BusColorDetailsDto, bool>> filter)
        {
            using (VehicleDbContext context = new())
            {
                var result = from bus in context.Buses
                             join b in context.Colors
                             on bus.Color.Id equals b.Id
                             select new BusColorDetailsDto
                             {
                                 ColorId=bus.Color.Id,
                                 BusId = bus.Id,
                                 ColorName = b.ColorName,

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}

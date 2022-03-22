using RepositoryOfVehicle.Core.DataAccess.EntityFramework;
using RepositoryOfVehicle.DataAccess.Abstract;
using RepositoryOfVehicle.Entities.Concrete;
using RepositoryOfVehicle.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RepositoryOfVehicle.DataAccess.Concrete.EntityFramework
{
    public class EfBoatDal : EfEntityRepositoryBase<Boat, VehicleDbContext>, IBoatDal
    {
        public List<BoatColorDetailsDto> GetBoatColorDetailsDto(Expression<Func<BoatColorDetailsDto, bool>> filter)
        {
            using (VehicleDbContext context = new())
            {
                var result = from boat in context.Boats
                             join b in context.Colors
                             on boat.Color.Id equals b.Id
                         
                             select new BoatColorDetailsDto
                             {
                                 ColorId = boat.Color.Id,
                                 BoatId = boat.Id,
                                 ColorName = b.ColorName,

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}

using RepositoryOfVehicle.Core.DataAccess;
using RepositoryOfVehicle.Entities.Concrete;
using RepositoryOfVehicle.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfVehicle.DataAccess.Abstract
{
   public interface ICarDal : IEntityRepository<Car>
    {
        List<CarColorDetailsDto> GetCarColorDetailsDto(Expression<Func<CarColorDetailsDto, bool>> filter );
        
    }
}

using RepositoryOfVehicle.Core.DataAccess;
using RepositoryOfVehicle.Entities.Concrete;
using RepositoryOfVehicle.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RepositoryOfVehicle.DataAccess.Abstract
{
    public interface IBusDal : IEntityRepository<Bus>
    {
        List<BusColorDetailsDto> GetBusColorDetailsDto(Expression<Func<BusColorDetailsDto, bool>> filter);
    }
}

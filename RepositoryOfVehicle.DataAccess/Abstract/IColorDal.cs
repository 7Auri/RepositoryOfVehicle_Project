using RepositoryOfVehicle.Core.DataAccess;
using RepositoryOfVehicle.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfVehicle.DataAccess.Abstract
{
   public interface IColorDal : IEntityRepository<Color>
    {
    }
}

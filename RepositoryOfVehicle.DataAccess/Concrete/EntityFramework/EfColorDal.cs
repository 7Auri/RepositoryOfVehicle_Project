using RepositoryOfVehicle.Core.DataAccess.EntityFramework;
using RepositoryOfVehicle.DataAccess.Abstract;
using RepositoryOfVehicle.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfVehicle.DataAccess.Concrete.EntityFramework
{
   public class EfColorDal : EfEntityRepositoryBase<Color, VehicleDbContext>, IColorDal
    {
    }
}

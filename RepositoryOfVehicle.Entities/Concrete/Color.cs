using RepositoryOfVehicle.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfVehicle.Entities.Concrete
{
   public class Color : IEntity
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
    }
}

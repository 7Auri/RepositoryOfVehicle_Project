using RepositoryOfVehicle.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfVehicle.Entities.Concrete
{
    public class Boat:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
    }
}

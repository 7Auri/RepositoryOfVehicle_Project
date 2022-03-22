using RepositoryOfVehicle.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfVehicle.Entities.DTOs
{
   public class BoatColorDetailsDto: IDto
    {
        public int ColorId { get; set; }
        public int BoatId { get; set; }
        public string ColorName { get; set; }
    }
}

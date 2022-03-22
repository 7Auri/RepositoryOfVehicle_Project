using RepositoryOfVehicle.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfVehicle.Entities.DTOs
{
   public class BusColorDetailsDto: IDto
    {
        public int ColorId { get; set; }
        public int BusId { get; set; }
        public string BusName { get; set; }
        public string ColorName { get; set; }
    }
}

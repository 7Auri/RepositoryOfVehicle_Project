using RepositoryOfVehicle.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfVehicle.Entities.DTOs
{
   public class CarColorDetailsDto: IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}

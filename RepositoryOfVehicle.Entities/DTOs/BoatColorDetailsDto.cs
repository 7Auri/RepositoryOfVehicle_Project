using RepositoryOfVehicle.Core.Entities;

namespace RepositoryOfVehicle.Entities.DTOs
{
    public class BoatColorDetailsDto : IDto
    {
        public int ColorId { get; set; }
        public int BoatId { get; set; }
        public string BoatName { get; set; }
        public string ColorName { get; set; }
    }
}

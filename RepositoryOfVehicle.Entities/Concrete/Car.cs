using RepositoryOfVehicle.Core.Entities;
using System.Collections.Generic;

namespace RepositoryOfVehicle.Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public bool Headlights { get; set; } = false;
        public string Wheels { get; set; }
    }
}

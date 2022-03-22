using RepositoryOfVehicle.Core.Utilities.Result;
using RepositoryOfVehicle.Entities.Concrete;
using RepositoryOfVehicle.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfVehicle.Business.Abstract
{
   public interface IBoatService
    {
        IDataResult<List<Boat>> GetAll();
        IResult Add(Boat boat);
        IResult Update(Boat boat);
        IResult Delete(Boat boat);
        IDataResult<List<Boat>> GetColorById(int colorId);
        IDataResult<List<BoatColorDetailsDto>> GetBoatColorDetailsDto(string colorName);
    }
}

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
    public interface IBusService
    {
        IDataResult<List<Bus>> GetAll();
        IResult Add(Bus bus);
        IResult Update(Bus bus);
        IResult Delete(Bus bus);
        IDataResult<List<Bus>> GetColorById(int colorId);
        IDataResult<List<BusColorDetailsDto>> GetBusColorDetailsDto(string colorName);
    }
}

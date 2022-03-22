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
   public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<Car>> GetColorById(int colorId);
        IDataResult<List<CarColorDetailsDto>> GetCarColorDetailsDto(string colorName);
    }
}

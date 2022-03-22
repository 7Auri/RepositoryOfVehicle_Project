using RepositoryOfVehicle.Business.Abstract;
using RepositoryOfVehicle.Business.Constants;
using RepositoryOfVehicle.Core.Utilities.Result;
using RepositoryOfVehicle.DataAccess.Abstract;
using RepositoryOfVehicle.Entities.Concrete;
using RepositoryOfVehicle.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryOfVehicle.Business.Concrete
{
    public class BusManager : IBusService
    {
        IBusDal _busDal;

        public BusManager(IBusDal busDal)
        {
            _busDal = busDal;
        }

        public IResult Add(Bus bus)
        {
            _busDal.Add(bus);
            return new SuccessResult(Messages.SuccessAdd);
        }

        public IResult Delete(Bus bus)
        {
            _busDal.Delete(bus);
            return new SuccessResult(Messages.SuccessDelete);
        }

        public IDataResult<List<Bus>> GetAll()
        {
            return new SuccessDataResult<List<Bus>>(_busDal.GetAll(), Messages.SuccessListed);
        }

        public IDataResult<List<BusColorDetailsDto>> GetBusColorDetailsDto(string colorName)
        {
            return new SuccessDataResult<List<BusColorDetailsDto>>(_busDal.GetBusColorDetailsDto(x => x.ColorName == colorName), Messages.SuccessListed);
        }

        public IDataResult<List<Bus>> GetColorById(int colorId)
        {
            return new SuccessDataResult<List<Bus>>(_busDal.Get(x => x.Color.Id== colorId), Messages.SuccessListed);
        }

        public IResult Update(Bus bus)
        {
            _busDal.Update(bus);
            return new SuccessResult(Messages.SuccessUpdate);
        }
    }
}

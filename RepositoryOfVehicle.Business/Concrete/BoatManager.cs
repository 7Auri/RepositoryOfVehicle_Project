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
    public class BoatManager : IBoatService
    {
        IBoatDal _boatDal;

        public BoatManager(IBoatDal boatDal)
        {
            _boatDal = boatDal;
        }

        public IResult Add(Boat boat)
        {
            _boatDal.Add(boat);
            return new SuccessResult(Messages.SuccessAdd);
        }

        public IResult Delete(Boat boat)
        {
            _boatDal.Delete(boat);
            return new SuccessResult(Messages.SuccessDelete);
        }

        public IDataResult<List<Boat>> GetAll()
        {
            return new SuccessDataResult<List<Boat>>(_boatDal.GetAll(), Messages.SuccessListed);
        }

        public IDataResult<List<BoatColorDetailsDto>> GetBoatColorDetailsDto(string colorName)
        {
            return new SuccessDataResult<List<BoatColorDetailsDto>>(_boatDal.GetBoatColorDetailsDto(x => x.ColorName == colorName), Messages.SuccessListed);
        }

        public IDataResult<List<Boat>> GetColorById(int colorId)
        {
            return new SuccessDataResult<List<Boat>>(_boatDal.Get(x => x.Color.Id == colorId), Messages.SuccessListed);
        }

        public IResult Update(Boat boat)
        {
            _boatDal.Update(boat);
            return new SuccessResult(Messages.SuccessUpdate);
        }
    }
}

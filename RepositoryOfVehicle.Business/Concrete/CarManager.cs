using RepositoryOfVehicle.Business.Abstract;
using RepositoryOfVehicle.Business.Constants;
using RepositoryOfVehicle.Core.Utilities.Result;
using RepositoryOfVehicle.DataAccess.Abstract;
using RepositoryOfVehicle.Entities.Concrete;
using RepositoryOfVehicle.Entities.DTOs;
using System.Collections.Generic;

namespace RepositoryOfVehicle.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IResult Add(Car car)
        {

            _carDal.Add(car);
            return new SuccessResult(Messages.SuccessAdd);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.SuccessDelete);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.SuccessListed);
        }

        public IDataResult<List<CarColorDetailsDto>> GetCarColorDetailsDto(string colorName)
        {
            return new SuccessDataResult<List<CarColorDetailsDto>>(_carDal.GetCarColorDetailsDto(x => x.ColorName == colorName), Messages.SuccessListed);
        }

        public IDataResult<List<Car>> GetColorById(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.Get(x => x.Color.Id == colorId), Messages.SuccessListed);
        }

        public IResult Update(Car car)
        {
            if (car.Headlights == true)
            {

                _carDal.Update(car);
                return new SuccessResult(Messages.SuccessHeadlights);
            }
            else
            {
                _carDal.Update(car);
                return new ErrorResult(Messages.ErrorHeadlights);
            }


        }
    }
}

using RepositoryOfVehicle.Core.Utilities.Result;
using RepositoryOfVehicle.Entities.Concrete;
using RepositoryOfVehicle.Entities.DTOs;
using System;
using System.Collections.Generic;

namespace RepositoryOfVehicle.Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetById(int id);
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
        IDataResult <List<Color>> GetByColorName(string name);
    }
}

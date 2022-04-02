using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BuildingManager : IBuildingService
    {
        public IResult Add(Building apartment)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Building apartment)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Building> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Building apartment)
        {
            throw new NotImplementedException();
        }
    }
}

using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBuildingService
    {
        IDataResult<Building> GetById(int id);
        IResult Add(Building apartment);
        IResult Delete(Building apartment);
        IResult Update(Building apartment);
    }
}

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
    public class ApartmentManager : IApartmentService
    {
        public IResult Add(Apartment apartment)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Apartment apartment)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Apartment> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Apartment apartment)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class SiteManager : ISiteService
    {
        public IResult Add(Site site)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Site site)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Site> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Site site)
        {
            throw new NotImplementedException();
        }
    }
}

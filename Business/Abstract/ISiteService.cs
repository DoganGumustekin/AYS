using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISiteService
    {
        IDataResult<Site> GetById(int id);
        IResult Add(Site site);
        IResult Delete(Site site);
        IResult Update(Site site);
    }
}

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
    public class PaymentManager : IPaymentService
    {
        public IResult Add(Payment payment)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Payment payment)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Payment> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Payment payment)
        {
            throw new NotImplementedException();
        }
    }
}

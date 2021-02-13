using Business.Abstract;
using Business.Constanst;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customers customers)
        {
            if (customers.CompanyName.Length<2)
            {
                return new ErrorResult(Messages.CompanyNameInvalid);
            }
            _customerDal.Add(customers);

            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customers customers)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customers>> GetAll()
        {
            return new SuccessDataResult<List<Customers>>(_customerDal.GetAll());
        }

        public IDataResult<Customers> GetByCustomerId(int id)
        {
            return new SuccessDataResult<Customers>(_customerDal.Get(c => c.CustomerId == id));
        }
    }
}

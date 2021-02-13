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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rentals rentals)
        {
            return new SuccessResult(Messages.CarAdded);
        }

        public IDataResult<List<Rentals>> GetRentDetail(Rentals rental)
        {
            if (DateTime.Now.Hour==22 )
            {
                return new ErrorDataResult<List<Rentals>>(Messages.MaintainceTime);
            }

            return new SuccessDataResult<List<Rentals>>(_rentalDal.GetAll());
        }
    }
}

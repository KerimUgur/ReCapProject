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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(Users users)
        {
            if (users.FirstName.Length<2)
            {
                return new ErrorResult(Messages.FirstNameInvalid);
            }
            _userDal.Add(users);

            return new SuccessResult(Messages.UserAdded);
        }

        public IDataResult<Users> GetById(int id)
        {
            return new SuccessDataResult<Users>(_userDal.Get(u => u.Id == id));
        }

        public IDataResult<List<Users>> GetUsers()
        {
            return new SuccessDataResult<List<Users>>(_userDal.GetAll());
        }
    }
}

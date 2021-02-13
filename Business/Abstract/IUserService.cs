using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserService
    {
        IResult Add(Users users);
        IDataResult<List<Users>> GetUsers();
        IDataResult<Users> GetById(int id);
    }
}

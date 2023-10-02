using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zippersale.Models;

namespace zippersale.Repositories
{
    public interface IUserRegisterRepository
    {
        bool RegisterUserRegister(UserRegister newUserRegister, UserLogin newUserLogin);
    }
}
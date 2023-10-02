using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zippersale.Models;
using Microsoft.EntityFrameworkCore;
using zippersale.ContextDB;

namespace zippersale.Repositories
{
    public class UserRegisterRepository : IUserRegisterRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRegisterRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public bool RegisterUserRegister(UserRegister newUserRegister, UserLogin newUserLogin){
            try{
                _appDbContext.UserLogin.Add(newUserLogin);
                _appDbContext.SaveChanges();

                _appDbContext.UserRegister.Add(newUserRegister);
                _appDbContext.SaveChanges();
                return true;
            }
            catch(Exception ex){
                return false;
            }
        }

        
    }
}
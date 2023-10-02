using zippersale.ContextDB;
using zippersale.Models;

namespace zippersale.Repositories
{
    public class UserLoginRepository : IUserLoginRepository
    {
        private readonly AppDbContext _AppDbContext;

        public UserLoginRepository(AppDbContext appDbContext)
        {
            _AppDbContext = appDbContext;
        }
        public bool TryLogonUser(UserLogin userLogin)
        {
            UserLogin user = _AppDbContext.UserLogin.FirstOrDefault(x => x.Email == userLogin.Email && x.Password == userLogin.Password); 
            if(user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
}

using zippersale.Models;

namespace zippersale.Repositories
{
    public interface IUserLoginRepository
    {
        bool TryLogonUser(UserLogin userLogin);
    }
}

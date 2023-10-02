using zippersale.Models;

namespace zippersale.Repositories
{
    public interface IContactRepository
    {
        bool SaveContactMessage(Contact newContact);
    }
}

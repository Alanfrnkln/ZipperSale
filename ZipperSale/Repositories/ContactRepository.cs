using zippersale.ContextDB;
using zippersale.Models;

namespace zippersale.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly AppDbContext _AppDbContext;

        public ContactRepository(AppDbContext appDbContext)
        {
            _AppDbContext = appDbContext;
        }

        public bool SaveContactMessage(Contact newContact)
        {
            try
            {
                _AppDbContext.Contact.Add(newContact);
                _AppDbContext.SaveChanges();

                return true;
            }

            catch(Exception ex)
            {
                return false;
            }
        }
    }
}

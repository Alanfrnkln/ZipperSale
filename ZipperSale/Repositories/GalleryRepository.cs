using Microsoft.AspNetCore.Mvc;
using zippersale.ContextDB;
using zippersale.Models;
using zippersale.Repositories;

namespace zippersale.Repositories
{
    public class GalleryRepository : IGalleryRepository
    {
        
        private readonly AppDbContext _appDbContext;

        public GalleryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ShopItem> GetAllItens()
        {
            return _appDbContext.ShopItem.Where(x => x.ShopItemID > 0).ToList();
        }
    }
}

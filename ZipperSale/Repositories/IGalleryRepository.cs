using zippersale.Models;

namespace zippersale.Repositories
{
    public interface IGalleryRepository
    {
        IEnumerable<ShopItem> GetAllItens();
    }
}

using Microsoft.AspNetCore.Mvc;
using zippersale.Models;
using zippersale.Repositories;

namespace zippersale.Repositories
{
    public class GalleryController : Controller
    {
        private readonly IGalleryRepository _galleryRepository;

        public GalleryController(IGalleryRepository galleryRepository)
        {
            _galleryRepository = galleryRepository;
        }

        public IActionResult Index()
        {
            var listItens = _galleryRepository.GetAllItens();
            ShopItem spItem = new ShopItem();
            spItem.Items = listItens;

            return View(spItem);
        }
    }
}

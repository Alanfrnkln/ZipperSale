using System.ComponentModel.DataAnnotations;

namespace zippersale.Models
{
    public class ShopItem
    {
        [Key]
        public int ShopItemID { get; set; }
        public string ItemName { get; set; }
        public string ReferenceCod { get; set; }
        public string Price { get; set; }
        public string Discount { get; set; }
        public string ItemModelType { get; set; }
        public string Brand { get; set; }
        public string QtdAvaliable { get; set; }
        public string StoreAvaliable { get; set; }
        public string ShowOnPage { get; set; }
        public string ItemPic { get; set; }
        public IEnumerable<ShopItem> Items { get; set; }
    }
}

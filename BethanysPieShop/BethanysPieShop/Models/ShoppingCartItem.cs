using System.ComponentModel.DataAnnotations;

namespace BethanysPieShop.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppintCartItemID { get; set; }
        public Pie Pie { get; set; } = default!;
        public int Amount { get; set; }
        public string? ShoppingCartId { get; set; }
    }
}

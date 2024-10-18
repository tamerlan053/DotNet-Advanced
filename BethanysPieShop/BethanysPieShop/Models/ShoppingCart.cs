using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models;

public class ShoppingCart : IShoppingCart {
    private readonly BethanysPieShopDbContext _bethanysPieShopDbContext;

    public string? ShoppingCartId { get; }

    //public List<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;

    private ShoppingCart(BethanysPieShopDbContext bethanysPieShopDbContext, string cartId)
    {
        ShoppingCartId = cartId;
        _bethanysPieShopDbContext = bethanysPieShopDbContext;
    }
}

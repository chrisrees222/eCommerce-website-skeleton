using eCommerce_website_skeleton.Models;

namespace eCommerce_website_skeleton.Data.Services
{
    public interface IOrderService
    {
        Task StoreOrder(List<ShoppingCartItem> items, string userId, string EmalAddress);
        Task<List<Order>> GetOrderByUserIDAsync(string userId);
    }
}

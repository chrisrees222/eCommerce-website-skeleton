using eCommerce_website_skeleton.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce_website_skeleton.Data.Services
{
    public class _ordersService : IOrderService
    {
        private readonly AppDbContext _context;

        public _ordersService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetOrderByUserIDAsync(string userId)
        {
            var orders = await _context.Orders.Include(n => n.OrderItems).ThenInclude(n => n.Movie).Where(n => n.UserId == userId).ToListAsync();
            return orders;
        }
               
        public async Task StoreOrder(List<ShoppingCartItem> items, string UserId, string userEmailAddress)
        {
            var order = new Order()
            {
                UserId = UserId,
                Email = userEmailAddress
            };
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            foreach (var item in items)
            {
                var orderItem = new OrderItem()
                {
                    Amount = item.Amount,
                    MovieId = item.Movie.Id,
                    OrderId = order.Id,
                    Price = item.Movie.Price
                };
                await _context.OrderItems.AddAsync(orderItem);
            }
            await _context.SaveChangesAsync();
        }
    }
}

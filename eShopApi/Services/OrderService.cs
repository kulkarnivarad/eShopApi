using eShopApi.Interfaces;
using eShopApi.Models;
using eShopApi.Repository;

namespace eShopApi.Services
{
    public class OrderService
    {
        private readonly IOrder _orderRepo;

        public OrderService(IOrder orderRepo)
        {
            _orderRepo = orderRepo;
        }

        public async Task<string> DeleteOrder(int orderId)
        {
            return await _orderRepo.DeleteOrderDetails(orderId);
        }

        public async Task<List<Order>> GetAllOrders()
        {
            return await _orderRepo.GetAllOrderDetails();
        }

        public async Task<Order> GetOrderById(int orderId)
        {
            return await _orderRepo.GetOrderDetails(orderId);
        }

        public async Task<string> SaveOrder(Order order)
        {
            return await _orderRepo.SaveOrderDetails(order);
        }

        public async Task<string> UpdateOrder(Order order)
        {
            return await _orderRepo.UpdateOrderDetails(order);
        }
    }
}

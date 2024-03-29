﻿namespace Szakdolgozat.Server.Services.OrderService
{
    public interface IOrderService
    {
        Task<ServiceResponse<bool>> PlaceOrder();
        Task<ServiceResponse<List<OrderOverviewResponseDTO>>> GetOrders();

        
        Task<ServiceResponse<OrderDetailsResponseDTO>> GetOrderDetails(int orderId);
    }
}

/*using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PearlPineproject.Model;
using PearlPineproject.DTOs;

namespace PearlPineproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class orderController : ControllerBase
    {
        private readonly AppDbContext _context;
        public orderController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("PlaceOrder")]
        public async Task<IActionResult> PlaceOrder([FromBody] List<orderModel> orders)
        {
            foreach (var order in orders)
            {
                var product = await _context.Products
                    .FindAsync(order.Id);

                if (product == null)
                {
                    return NotFound("Product not found");
                }

                if (order.Quantity > product.Stock)
                {
                    return BadRequest($"Only {product.Stock} items available");
                }

                // Reduce stock
                product.Stock -= order.Quantity;
            }

            // Save all orders
            await _context.Orders.AddRangeAsync(orders);

            await _context.SaveChangesAsync();

            return Ok(new { message = "Order Saved Successfully" });
        }

        [HttpGet("GetOrders/{email}")]
        public IActionResult GetOrders(string email)
        {
            var orders = _context.Orders
                .Where(o => o.UserEmail == email)
                .ToList();

            return Ok(orders);
        }
    }
}*/

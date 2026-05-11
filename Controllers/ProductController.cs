using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PearlPineproject.Model;
using PearlPineproject.DTOs;

namespace PearlPineproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost("AddProducts")]
        public async Task<IActionResult> AddProduct(ProductModel product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }

        [HttpGet("GetProducts")]
        public IActionResult GetProducts()
        {
            var data = _context.Products.ToList();
            return Ok(data);
        }

        [HttpPut("UpdateStock/{id}")]
        public async Task<IActionResult> UpdateStock(int id, int stock)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
                return NotFound();

            product.Stock = stock;

            await _context.SaveChangesAsync();

            return Ok(product);
        }
    }
}

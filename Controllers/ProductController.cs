using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PearlPineproject.Model;
//using PearlPineproject.DTOs;

namespace PearlPineproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        [HttpGet("GetProducts")]
        public IActionResult GetProducts()
        {
            var products = new List<ProductModel>
            {
                new ProductModel
                {
                    Id = 1,
                    Name = "Hand Rolled Mango Chocolate Truffle",
                    Price = 250,
                    Image ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJzfLp9LFZVlIYGxGoOCOMWTYI-Qz_zn37WA&s",
                    Stock = 23,
                    Category = "Chocolate"
                },

                new ProductModel
                {
                    Id = 2,
                    Name = "Hazelnut Paste With Death By Chocolate",
                    Price = 200,
                    Image ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRUFpr_KJxVEoQDOCrwDm46evY_0kryvqtY4w&s",
                    Stock = 30,
                    Category = "Chocolate"
                },
                  new ProductModel
                {
                    Id = 3,
                    Name = "Almond Rocks",
                    Price = 150,
                    Image ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR0I3tEVlzxlCMQrPsty-c4Nw2XUDcWQGJlhg&s",
                    Stock = 0,
                    Category = "Chocolate"
                },

                    new ProductModel
                {
                    Id = 4,
                    Name = "Shredded Coconut Chocolate",
                    Price = 230,
                    Image ="https://5.imimg.com/data5/SELLER/Default/2025/4/503924912/AL/OJ/UI/227734232/coconut-chocolate-500x500.jpg",
                    Stock = 20,
                    Category = "Chocolate"
                },

                    new ProductModel
                {
                    Id = 5,
                    Name = "Honey & Gulkand",
                    Price = 100,
                    Image ="https://www.thecocoabeanchocolatier.in/cdn/shop/files/Honey_23fa3734-8449-4c99-8e14-ca852233cca1.png?v=1704794604&width=1920",
                    Stock = 0,
                    Category = "Chocolate"
                },

                     new ProductModel
                {
                    Id = 6,
                    Name = "Dulce de Leche",
                    Price = 260,
                    Image ="https://www.egmonthoney.co.nz/cdn/shop/articles/Blog_imagery_18.png?v=1700446115&width=2048",
                    Stock = 27,
                    Category = "Chocolate"
                },

                     new ProductModel
                {
                    Id = 7,
                    Name = "Dulce de Leche",
                    Price = 200,
                    Image ="https://www.twistandmake.com/hs-fs/hubfs/twist-and-make-images/New-Twist-and-Make-Recipes/640-Images/53-easy-oreo-truffles.jpg?width=640&height=640&name=53-easy-oreo-truffles.jpg",
                    Stock = 0,
                    Category = "Chocolate"
                },

                      new ProductModel
                {
                    Id = 8,
                    Name = "Mocha Truffle",
                    Price = 150,
                    Image ="https://kirbiecravings.com/wp-content/uploads/2025/04/2-ingredient-healthier-chocolate-truffles-7.jpg",
                    Stock = 0,
                    Category = "Chocolate"
                },

                    new ProductModel
                {
                    Id = 9,
                    Name = "Kaju Katli Truffle",
                    Price = 200,
                    Image ="https://carveyourcraving.com/wp-content/uploads/2022/10/Rose-almond-truffles.jpg",
                    Stock = 0,
                    Category = "Chocolate"
                },

                  new ProductModel
                {
                    Id = 10,
                    Name = "Raspberry Dark Chocolate Truffle",
                    Price = 220,
                    Image ="https://www.eatloveeats.com/wp-content/uploads/2022/02/Raspberry-Dark-Chocolate-Truffles-Featured.jpg",
                    Stock = 22,
                    Category = "Chocolate"
                },

                   new ProductModel
                {
                    Id = 11,
                    Name = "Modak",
                    Price = 230,
                    Image ="https://i.pinimg.com/736x/ed/56/0f/ed560fabc1d6c50594238a0e55a5640b.jpg",
                    Stock = 34,
                    Category = "Modak"
                },

                   new ProductModel
                {
                    Id = 12,
                    Name = "Modak Truffle",
                    Price = 200,
                    Image ="https://c.ndtvimg.com/2020-08/lsbpqo34_modak_625x300_18_August_20.jpg?im=FaceCrop,algorithm=dnn,width=1200,height=886",
                    Stock = 30,
                    Category = "Modak"
                },


                   new ProductModel
                {
                    Id = 13,
                    Name = "Kunafa Chocolate Pastry",
                    Price = 200,
                    Image ="https://americanpistachios.in/sites/india/files/inline-images/Chocolate%20Kunafa%20Cake_1.jpg",
                    Stock = 30,
                    Category = "Pastry"
                },

                   new ProductModel
                {
                    Id = 14,
                    Name = "Red Velvet Pastry",
                    Price = 180,
                    Image ="https://www.hindustantimes.com/ht-img/img/2024/10/01/1600x900/486a10f0-0e07-11ef-8dd3-417ed3ed1764_1715288650009_1727782007018.jpg",
                    Stock = 35,
                    Category = "Pastry"
                },

                     new ProductModel
                {
                    Id = 15,
                    Name = "Chocolate Truffle Pastry",
                    Price = 160,
                    Image ="https://doughandcream.com/cdn/shop/files/Chocolate_Truffle_Pastry_1080x.jpg?v=1732651787",
                    Stock = 45,
                    Category = "Pastry"
                }
            };
            return Ok(products);
        }
    }
}
   /* 
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
   */
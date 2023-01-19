using desafio_pmenoslab.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace desafio_pmenoslab.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private Context _context;
        public ProductController(Context context) 
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            List<Product> listProduct = await _context.Product.ToListAsync();
            return Ok(listProduct);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(Product product)
        {
            _context.Product.Add(product);
            await _context.SaveChangesAsync();
            return Created("", new {product.Id});

        }

    }
}

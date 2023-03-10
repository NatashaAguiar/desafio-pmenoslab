using desafio_pmenoslab.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace desafio_pmenoslab.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private Context _context;
        private Product product;

        public object Id { get; private set; }

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
        [HttpPut]
        public async Task<IActionResult> UpDateAsync(Product product)
        {
            _context.Product.Update(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int Id)
        {
            Product product = await _context.Product.FirstOrDefaultAsync(product => product.Id == Id);
            if (product != null)
            {
                _context.Product.Remove(product);
                await _context.SaveChangesAsync();
            }
            return NoContent();
        }

    }
}

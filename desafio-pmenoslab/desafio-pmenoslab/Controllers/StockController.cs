using desafio_pmenoslab.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace desafio_pmenoslab.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StockController : ControllerBase
    {
        private Context _context;
        
        public StockController(Context context) 
        {
            _context = context; 
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync() 
        {
            List<Stock> listStock = await _context.Stock.ToListAsync();
            return Ok(listStock); 
        }
        [HttpPost]
        public async Task<IActionResult> CreatAsync(Stock stock)
        {
            _context.Stock.Add(stock);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}

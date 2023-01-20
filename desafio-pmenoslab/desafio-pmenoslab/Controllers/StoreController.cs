using desafio_pmenoslab.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace desafio_pmenoslab.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        private Context _context;
        public StoreController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            List<Store> listStore = await _context.Store.ToListAsync();
            return Ok(listStore);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(Store store)
        {
            _context.Store.Add(store);
            await _context.SaveChangesAsync();
            return Created("", new { store.Id });
        }
        [HttpPut]
        public async Task<IActionResult> UpDataAsync(Store store)
        {
            _context.Store.Update(store);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int Id)
        {
            Store store = await _context.Store.FirstOrDefaultAsync(store => store.Id == Id);
            if(store != null)
            {
                _context.Store.Remove(store);
                await _context.SaveChangesAsync();
            }
            return NoContent();
        }

    }

}

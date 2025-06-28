using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stoof.Models;

namespace Stoof.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {

        private readonly StoofContext _context;

        public ItemsController(StoofContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //return Ok(new { message = "Hello from Stoof API!" });
            var items = await _context.Items.ToListAsync();
            return Ok(items);

        }
    }
}

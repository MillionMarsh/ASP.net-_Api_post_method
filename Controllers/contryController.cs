using apipractice.Data;
using apipractice.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apipractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class contryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public contryController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public ActionResult<Country> create([FromBodyAttribute]Country country)
            {
                _context.countries.Add(country);
                _context.SaveChanges();
                return Ok();
            }
    }
}

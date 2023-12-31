using be_fletchs_news_csharp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace be_fletchs_news_csharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TopicsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Topic>>> GetTopics()
        {
            return await _context.Topics.ToListAsync();
        }
    }
}

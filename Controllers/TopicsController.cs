using be_fletchs_news_csharp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using be_fletchs_news_csharp.Models;
using be_fletchs_news_csharp.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace be_fletchs_news_csharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        private readonly ITopicRepository _topicRepository;

        public TopicsController(ITopicRepository topicRepository)
        {
            _topicRepository = topicRepository;
        }

        /// <summary>
        /// Retrieves all topics.
        /// </summary>
        /// <returns>A list of topics</returns>
        /// <response code="200">Returns the list of topics</response>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Topic>>> GetTopics()
        {
            var topics = await _topicRepository.GetAllTopicsAsync();
            return Ok(topics);
        }

        /// <summary>
        /// Retrieves a specific topic by slug.
        /// </summary>
        /// <param name="slug">The slug of the topic to retrieve</param>
        /// <returns>The requested topic</returns>
        /// <response code="200">Returns the requested topic</response>
        /// <response code="404">If the topic is not found</response>
        [HttpGet("{slug}")]
        public async Task<ActionResult<Topic>> GetTopicBySlug(string slug)
        {
            var topic = await _topicRepository.GetTopicBySlugAsync(slug);
            if (topic == null)
            {
                return NotFound();
            }
            return Ok(topic);
        }
    }
}

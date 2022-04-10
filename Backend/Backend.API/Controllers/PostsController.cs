using Backend.API.Enums;
using Backend.Data.Schema;
using Backend.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Backend.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly ILogger<PostsController> _logger;
        private readonly PostsService _service;
        private readonly string invalidEnumErrorMessage = "Invalid enum value provided";

        public PostsController(ILogger<PostsController> logger)
        {
            _logger = logger;
            _service = new PostsService();
        }

        [HttpGet]
        [Route("{orderBy}")]
        public async Task<IEnumerable<Post>> Get(string orderBy)
        {
            SortBy parsedEnum;
            try
            {
                if (Enum.TryParse<SortBy>(orderBy, true, out parsedEnum))
                {
                    switch (parsedEnum)
                    {
                        case SortBy.New:
                            var res1 = await _service.NewPostsAsync();
                            return res1;
                        case SortBy.Popular:
                            var res2 = await _service.PopularPostsAsync();
                            return res2;
                        case SortBy.Trending:
                            var res3 = await _service.TrendingPostsAsync();
                            return res3;
                        default:
                            _logger.LogError(invalidEnumErrorMessage);
                            throw new System.Web.Http.HttpResponseException(HttpStatusCode.BadRequest);
                    }
                }
                else
                {
                    _logger.LogError(invalidEnumErrorMessage);
                    return new List<Post>();
                }
            }
            catch (Exception exc)
            {
                _logger.LogError(exc.Message);
                throw new System.Web.Http.HttpResponseException(HttpStatusCode.BadRequest);
            }
        }
    }
}

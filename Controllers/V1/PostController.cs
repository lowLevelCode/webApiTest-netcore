using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webApiTest.Domain.Posts;
using webApiTest.RoutesApi.V1;

namespace webApiTest.Controllers.V1
{
    [ApiController]
    [Route(ApiRoutes.URL)]
    public class PostController:ControllerBase
    {
        private List<Post> _post;

        public PostController()
        {
            _post = new List<Post>()
            {
                new Post { Id = Guid.NewGuid().ToString() },
                new Post { Id = Guid.NewGuid().ToString() },
                new Post { Id = Guid.NewGuid().ToString() }
            };
        }

        [HttpGet]
        public IEnumerable<Post> GetAllPosts()
        {
            return _post;
        }
    }
}
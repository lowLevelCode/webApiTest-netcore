using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webApiTest.Domain.Posts;


namespace webApiTest.Controllers.V1
{
    [ApiController]
    [Route(ApiRouteV1.URL)]
    public class PostController:ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public IEnumerable<Post> GetAllPosts()
        {
            return _postService.GetAllPosts();
        }

        [HttpGet("{id}")]
        public Post GetPostById(int id)
        {
            return _postService.GetPostById(id);
        }

        [HttpPost("Create")]
        public void CreatePost([FromBody] Post post)
        {
            _postService.CreatePost(post);
        }

        [HttpPut("update/{id}")]
        public void UpdatePost(int id, [FromBody] Post post)
        {
            _postService.UpdatePost(id,post);
        }

        [HttpDelete("delete/{id}")]
        public void DeletePost(int id)
        {
            _postService.DeletePost(id);
        }
    }
}
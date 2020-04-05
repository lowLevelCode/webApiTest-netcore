using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webApiTest.Domain.Posts;
using System.Threading.Tasks;

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
        public async Task<IEnumerable<Post>> GetAllPosts()=> await  _postService.GetAllPostsAsync();

        [HttpGet("{id}")]
        public async Task<Post> GetPostById(int id)=> await _postService.GetPostByIdAsync(id);        

        [HttpPost("Create")]
        public async Task<IActionResult> CreatePost([FromBody] Post post)
        {
            var created = await _postService.CreatePostAsync(post);
            if(created > 0)
                return Ok("Creado con exito!");
            
            return BadRequest("No se pudo crear el post");
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdatePostAsync(int id, [FromBody] Post post)
        {
            try
            {
                var updated = await _postService.UpdatePostAsync(id,post);
                if(updated > 0)
                    return Ok("Actualizado con exito!");            
                return BadRequest("No se pudo Actualizar el post");   
            }
            catch (Exception ex)
            {                
                return BadRequest(ex.Message);
            }            
        }        
    }
}
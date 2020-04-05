using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApiTest.Domain.Posts
{
    public class PostService:IPostService
    {
        private readonly IPostRepository _postRepository;        
        public PostService(IPostRepository postRepository)
        {            
            _postRepository = postRepository;            
        }

        public async Task<IEnumerable<Post>> GetAllPostsAsync()=> await _postRepository.GetAllAsync();
        public async Task<Post> GetPostByIdAsync(int id)=> await _postRepository.GetByIdAsync(id);
        public async Task<int> CreatePostAsync(Post post)
        {
            _postRepository.Add(post);
            return await _postRepository.SaveAsync();
        }        

        public async Task<int> UpdatePostAsync(int id, Post post)
        {
            var postResult = await _postRepository.GetByIdAsync(id);
            if(postResult == null)
                throw new NullReferenceException("No existe el post.");

            _postRepository.Update(postResult);
            return await _postRepository.SaveAsync();
        }

        public async Task<int> DeletePostAsync(int id)
        {
            var postResult = await _postRepository.GetByIdAsync(id);
            _postRepository.Remove(postResult);
            return await _postRepository.SaveAsync();            
        }        
    }
}
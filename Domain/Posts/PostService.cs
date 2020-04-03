using System;
using System.Collections.Generic;
using System.Linq;

namespace webApiTest.Domain.Posts
{
    public class PostService:IPostService
    {
        private readonly IPostRepository _postRepository;        
        public PostService(IPostRepository postRepository)
        {            
            _postRepository = postRepository;            
        }

        public IEnumerable<Post> GetAllPosts()
        {
            return _postRepository.GetAll();
        }

        public Post GetPostById(int id)   
        {
            return _postRepository.GetById(id);
        }

        public int CreatePost(Post post)
        {
            _postRepository.Add(post);
            return _postRepository.Save();            
        }

        public int UpdatePost(int id, Post post)
        {
            var postResult = _postRepository.GetById(id);
            _postRepository.Update(post);
            return _postRepository.Save();
        }

        public int DeletePost(int id)
        {
            var post = _postRepository.GetById(id);
            _postRepository.Remove(post);
            return _postRepository.Save();
        }
    }
}
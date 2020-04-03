using System.Collections.Generic;

namespace webApiTest.Domain.Posts
{
    public interface IPostService
    {
        IEnumerable<Post> GetAllPosts();
        Post GetPostById(int id);        
        int CreatePost(Post post);
        int UpdatePost(int id, Post post);
        int DeletePost(int id);
    }
}
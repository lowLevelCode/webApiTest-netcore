using System.Collections.Generic;
using System.Threading.Tasks;

namespace webApiTest.Domain.Posts
{
    public interface IPostService
    {
        Task<IEnumerable<Post>> GetAllPostsAsync();
        Task<Post> GetPostByIdAsync(int id);        
        Task<int> CreatePostAsync(Post post);
        Task<int> UpdatePostAsync(int id, Post post);
        Task<int> DeletePostAsync(int id);
    }
}
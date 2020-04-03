using System.Collections.Generic;
using webApiTest.Domain.SuperTypes;

namespace webApiTest.Domain.Posts
{
    public interface IPostRepository:IRepository<Post>
    {
        IEnumerable<Post> GetPostForPage(int pageIndex, int pageSize);
    }
}
using System.Collections.Generic;
using webApiTest.Domain.Posts;

namespace webApiTest.DataInfrastruture.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(AforeGlobalContext context) : base(context){}
    
        public IEnumerable<Post> GetPostForPage(int pageIndex, int pageSize)
        {
            throw new System.NotImplementedException();
        }
    }
}
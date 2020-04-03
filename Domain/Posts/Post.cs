using System;
using webApiTest.Domain.SuperTypes;

namespace webApiTest.Domain.Posts
{
    public class Post: AggregateRoot
    {        
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
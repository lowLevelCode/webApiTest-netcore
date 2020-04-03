using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using webApiTest.Domain.Posts;

namespace webApiTest.DataInfrastruture.Mapping
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p=>p.Id);
            builder.Property(p=>p.CreatedAt).ValueGeneratedOnAdd();
            builder.ToTable("post");
            builder.HasData(
                new Post { Id=1, Name="Post 1" , CreatedAt = DateTime.Now },
                new Post { Id=2, Name="Post 2" , CreatedAt = DateTime.Now },
                new Post { Id=3, Name="Post 3" , CreatedAt = DateTime.Now },
                new Post { Id=4, Name="Post 4" , CreatedAt = DateTime.Now },
                new Post { Id=5, Name="Post 5" , CreatedAt = DateTime.Now },
                new Post { Id=6, Name="Post 6" , CreatedAt = DateTime.Now },
                new Post { Id=7, Name="Post 7" , CreatedAt = DateTime.Now },
                new Post { Id=8, Name="Post 8" , CreatedAt = DateTime.Now },
                new Post { Id=9, Name="Post 9" , CreatedAt = DateTime.Now },
                new Post { Id=10, Name="Post 10", CreatedAt = DateTime.Now }
            );
        }
    }
}
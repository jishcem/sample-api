using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectApi.Models;

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}

public class PostEntityTypeConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.ToTable("posts");
        builder.Property(p => p.PostId).HasColumnName("post_id");
        builder.Property(p => p.Title).HasColumnName("title");
        builder.Property(p => p.Content).HasColumnName("content");
        builder.Property(p => p.BlogId).HasColumnName("blog_id");
    }
}
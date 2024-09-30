using BlogEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogEF.Data.Mappings
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
          builder.ToTable("Post");
          builder.HasKey(x => x.Id);
          builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();
          builder.Property(x => x.LastUpdateDate)
            .IsRequired()
            .HasColumnName("LastUpdateDate")
            .HasColumnType("SMALLDATETIME")
            .HasMaxLength(60)
            .HasDefaultValueSql("GETDATE()");
          
           builder.HasIndex(x => x.Slug, "IX_Post_Slug")
            .IsUnique();
        }
    }
}
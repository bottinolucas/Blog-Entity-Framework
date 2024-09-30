using BlogEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogEF.Data.Mappings 
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
      public void Configure(EntityTypeBuilder<Category> builder)
      {
        //Tabela
        builder.ToTable("Category");
        //Chave Primaria
        builder.HasKey(x => x.Id);
        //Identity
        builder.Property(x => x.Id)
          .ValueGeneratedOnAdd()
          .UseIdentityColumn(); //PRIMARY KEY IDENTITY(1,1)

      }
    }
}
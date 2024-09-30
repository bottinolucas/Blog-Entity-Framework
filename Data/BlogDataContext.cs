using BlogEF.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEF.Data
{
    //Para ser um Data Context, deve herdar de DbContext
    public class BlogDataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=34358873Lucas;TrustServerCertificate=True");
    }   
}
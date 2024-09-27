using BlogEF.Data;
using BlogEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;

using (var ctx = new BlogDataContext())
{
  //CREATE 
  //Exemplo: Criar uma nova Tag
  // var tag = new Tag {
  //   Name = "ASPNET",
  //   Slug = "aspnet"
  // };
  // ctx.Tags.Add(tag);
  // ctx.SaveChanges();

  //UPDATE
  //Exemplo: Alterar uma Tag (Rehydration)
  // var tag = ctx.Tags.FirstOrDefault(x => x.Id == 1);
  // tag.Name = ".NET";
  // tag.Slug = "dotnet";
  // ctx.Update(tag);
  // ctx.SaveChanges();

  //DELETE
  //Exemplo: Remover uma Tag 
  // var tag = ctx.Tags.FirstOrDefault(x => x.Id == 1);
  // ctx.Remove(tag);
  // ctx.SaveChanges();

  // var tags = ctx
  //   .Tags
  //   .Where(x => x.Name.Contains(".NET"))
  //   .ToList();

  //Where ANTES de ToList executa a query em tempo de execucao +Performance
  //Where DEPOIS de ToList executa a query no SGBD

  // var tags = ctx
  //   .Tags
  //   .AsNoTracking()
  //   .ToList();

  // //AsNoTracking desabilita a consulta (++Performance)

  // foreach(var item in tags) {
  //   System.Console.WriteLine(item.Name);
  // }

  // var tag = ctx
  //   .Tags
  //   .AsNoTracking()
  //   .FirstOrDefault(x => x.Id == 2);
  
  // Console.WriteLine(tag?.Name);

  // var user = new User(){
  //   Name = "Lucas Bottino",
  //   Slug = "lucasbottino",
  //   Email = "lucasgabottino@gmail.com",
  //   Bio = "Estudante de Engenharia de Software",
  //   Image = "https://balta.io",
  //   PasswordHash = "1q2w3e4r5t6y"
  // };

  // var category = new Category{
  //   Name = "Backend",
  //   Slug = "backend"
  // };

  // var post = new Post{
  //   Author = user,
  //   Category = category,
  //   Body = "<p>Hello World!</p>",
  //   Slug = "Entity Framework basico",
  //   Summary = "Aprendendo EF Core",
  //   Title = "EF Core",
  //   CreateDate = DateTime.Now,
  //   LastUpdateDate = DateTime.Now
  // };

  // ctx.Posts.Add(post);
  // ctx.SaveChanges();

  // var posts = ctx
  //   .Posts
  //   .AsNoTracking()
  //   .Include(x => x.Author) //Inner Join com Author
  //   .Include(y => y.Category) //Inner Join com Category
  //   .OrderByDescending(x => x.LastUpdateDate)
  //   .ToList();

  // foreach(var post in posts)
  // {
  //   Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} em {post.Category?.Name}");
  // }

  var post = ctx
    .Posts
    //.AsNoTracking()
    .Include(x => x.Author)
    .Include(x => x.Category)
    .OrderByDescending(x => x.LastUpdateDate)
    .FirstOrDefault();

  post.Author.Name = "Teste para troca";
  ctx.Posts.Update(post);
  ctx.SaveChanges();
}
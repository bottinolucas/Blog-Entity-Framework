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

  var tag = ctx
    .Tags
    .AsNoTracking()
    .FirstOrDefault(x => x.Id == 2);
  
  System.Console.WriteLine(tag?.Name);
}
using BlogEF.Data;
using BlogEF.Models;
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
  var tag = ctx.Tags.FirstOrDefault(x => x.Id == 1);
  ctx.Remove(tag);
  ctx.SaveChanges();
}
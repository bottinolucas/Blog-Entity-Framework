using BlogEF.Data;
using BlogEF.Models;

using var context = new BlogDataContext();
// context.Users.Add(new User
//   {
//     Bio = "Software",
//     Email = "lucasgabottino@gmail.com",
//     Image = "https://balta.io",
//     Name = "Lucas Bottino",
//     PasswordHash = "1q2w3e4r5t6y",
//     Slug = "software"
//   }
// );
// context.SaveChanges();

var user = context.Users.FirstOrDefault();

var post = new Post
{
  Author = user,
  Body = "article",
  Category = new Category 
  {
    Name = "backend",
    Slug = "some backend"
  },
  CreateDate = DateTime.Now,
  Slug = "some text",
  Summary = "Some summary",
  Title = "my article"
};

context.Posts.Add(post);
context.SaveChanges();


using ordinary;
using System.Text.Json;

TestDbContext ctx = new TestDbContext();

var zack = new Author
{
    Name = "zack",
    Description = "mvp"
};

ctx.Authors.Add(zack);

ctx.SaveChanges();

ctx.Books.Add(new Book {
    Author= zack,
    BookName = "ddd .net",
});

ctx.SaveChanges();

var list1 = ctx.Authors.ToArray();
var list2 = ctx.Books.ToArray();

Console.WriteLine("\n\n--------------------- Author Table Info  -------------------------");

Console.WriteLine(JsonSerializer.Serialize(list1));

Console.WriteLine("\n\n--------------------- Book Table Info  -------------------------");

Console.WriteLine(JsonSerializer.Serialize(list2));
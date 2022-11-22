

using StronglyTypedId;
using System;

TestDbContext ctx = new TestDbContext();

var zack = new Author
{
    Name = "zack",
    Description = "mvp"
};

ctx.Authors.Add(zack);

ctx.Books.Add(new Book {
    Author= zack.Id,
    BookName = "ddd .net",
});

ctx.SaveChanges();
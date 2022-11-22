using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StronglyTypedId
{
    internal class Book
    {
        public BookId Id { get; set; } = new BookId(Guid.NewGuid());

        public string BookName { get; set; }

        public AuthorId Author { get; set; }
    }

    public readonly struct BookId
    {
        public BookId(Guid value) => Value = value;
        public Guid Value { get; }
    }
}

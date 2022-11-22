using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StronglyTypedId
{
    internal class Author
    {
        public AuthorId Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Book> Books { get; } = new();
    }

    public readonly struct AuthorId
    {
        public AuthorId(long value) => Value = value;
        public long Value { get; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessCodeEF
{
    [HasStronglyTypedId(typeof(Guid))]
    internal class Book
    {
        public BookId Id { get; set; }

        public string BookName { get; set; }
        public Author? Author { get; set; }
        public AuthorId AuthorId { get; set; }
    }

}

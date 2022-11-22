using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordinary
{
    internal class Book
    {
        public Guid Id { get; set; }

        public string BookName { get; set; }

        public long Author { get; set; }
    }

}

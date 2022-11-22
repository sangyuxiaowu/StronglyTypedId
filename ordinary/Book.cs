namespace ordinary
{
    internal class Book
    {
        public Guid Id { get; set; }

        public string BookName { get; set; }

        public Author? Author { get; set; }
        public long AuthorId { get; set; }
    }

}

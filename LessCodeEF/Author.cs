
namespace LessCodeEF
{
    [HasStronglyTypedId]
    internal class Author
    {
        public AuthorId Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}

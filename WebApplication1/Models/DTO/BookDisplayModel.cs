namespace WebApplication1.Models.DTO
{
    public class BookDisplayModel
    {

        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}

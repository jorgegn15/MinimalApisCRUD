using MinimalApisCRUD.Models;

namespace MinimalApisCRUD.Services.Interfaces
{
    public interface IBookServices
    {
        Task<Book> CrearLibro(BookRequest request);
    }
}

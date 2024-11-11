using Bookstore.Data;
using Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Service
{
    public class GenreService
    {
        private readonly BookstoreContext _context;

        public GenreService(BookstoreContext context)
        {
            _context = context;
        }
        public async Task<List<Genre>> FindAllAsync()
        {
            return await _context.Genres.ToListAsync();

        }
        public async Task InsertAsync(Genre genre) 
        {
            _context.Add(genre);
            await _context.SaveChangesAsync();
        }
        public async  Task DeleteAsync(Genre genre) 
        {
            _context.Remove(genre);
            await _context.SaveChangesAsync();
        }
    }
}

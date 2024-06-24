using eCommerce_website_skeleton.Data.Base;
using eCommerce_website_skeleton.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce_website_skeleton.Data.Services
{
    public class MoviesService: EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly AppDbContext _context;

        public MoviesService(AppDbContext context) : base(context) 
        {
            _context = context;
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = await _context.Movies
            .Include(c => c.Cinema)
            .Include(p => p.Producer)
            .Include(am => am.Actor_Movies).ThenInclude(a => a.Actors)
            .FirstOrDefaultAsync(n=>n.Id == id);

            return movieDetails;
        }
    }
}

using eCommerce_website_skeleton.Data.Base;
using eCommerce_website_skeleton.Models;

namespace eCommerce_website_skeleton.Data.Services
{
    public interface IMoviesService: IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
    }
}

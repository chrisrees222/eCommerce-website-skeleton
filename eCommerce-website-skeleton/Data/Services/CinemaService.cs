using eCommerce_website_skeleton.Data.Base;
using eCommerce_website_skeleton.Models;

namespace eCommerce_website_skeleton.Data.Services
{
    public class CinemaService:EntityBaseRepository<Cinema>, ICinemaservice
    {
        public CinemaService(AppDbContext context) : base(context) 
        {            
        }
    }
}

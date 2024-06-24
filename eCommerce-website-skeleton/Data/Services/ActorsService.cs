using eCommerce_website_skeleton.Data.Base;
using eCommerce_website_skeleton.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce_website_skeleton.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actors>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
        
    }
}

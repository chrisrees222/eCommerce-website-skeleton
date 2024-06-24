using eCommerce_website_skeleton.Data.Base;
using eCommerce_website_skeleton.Models;

namespace eCommerce_website_skeleton.Data.Services
{
    public class ProducersServices: EntityBaseRepository<Producer>, IProducersServices
    {
        public ProducersServices(AppDbContext context) : base(context)
        {
            
        }
    }
}

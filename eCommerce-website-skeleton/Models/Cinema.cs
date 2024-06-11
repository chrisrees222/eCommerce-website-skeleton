using System.ComponentModel.DataAnnotations;

namespace eCommerce_website_skeleton.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace eCommerce_website_skeleton.Models
{
    public class Actors
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL {  get; set; }        
        public string FullName { get; set;}
        public string Bio { get; set;}

        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace eCommerce_website_skeleton.Models
{
    public class Actors
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL {  get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set;}
        [Display(Name = "Biography")]
        public string Bio { get; set;}

        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}

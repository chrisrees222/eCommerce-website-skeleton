using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using eCommerce_website_skeleton.Data.Base;

namespace eCommerce_website_skeleton.Models
{
    public class Actors:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage ="Profile picture required")]
        public string ProfilePictureURL {  get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 charactors long.")]
        public string FullName { get; set;}

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography description is required")]
        public string Bio { get; set;}

        #nullable disable
        public List<Actor_Movie> Actor_Movies { get; set; } = null!;
    }
}

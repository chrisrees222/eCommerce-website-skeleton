﻿using System.ComponentModel.DataAnnotations;

namespace eCommerce_website_skeleton.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //relationships
        public List<Movie> Movies { get; set; }
    }
}
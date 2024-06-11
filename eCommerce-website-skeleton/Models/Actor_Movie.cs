namespace eCommerce_website_skeleton.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int ActorID { get; set; }
        public Actors Actors { get; set; }  
    }
}

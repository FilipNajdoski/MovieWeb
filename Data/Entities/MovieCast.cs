namespace MovieWeb.Data.Entities
{
    public class MovieCast
    {
        public int MovieID { get; set; }
        public Movie Movie { get; set; }
        public int MovieRoleID { get; set; }
        public MovieRole MovieRole { get; set; }
        public int PersonID { get; set; }
        public Person Person { get; set; }
    }
}


using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieWeb.Data.Entities
{
    public class MovieRole
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public IList<MovieCast> MovieCast { get; set; }
    }
}
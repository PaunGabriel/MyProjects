using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class User
    {
        public Guid UserID { get; set; }
        public string UserName { get; set; }
        public string UserReview { get; set; }
        public DateTime ReviewDate { get; set; }
        public Movie Movie { get; set; }
    }
}

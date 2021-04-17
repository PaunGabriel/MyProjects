using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class ModelData
    {
        public ICollection<User> reviews { get; set; }
        public string Name { get; set; }
        public string DescriprionMovie { get; set; }
        public Movie movie { get; set; }
    }
}

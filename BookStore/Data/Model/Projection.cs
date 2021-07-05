using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data.Model
{
    public class Projection
    {
        public int Id { get; init; }

        public string MovieTitle { get; set; }

        public DateTime TimeOfProjection { get; set; }

        public string MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}

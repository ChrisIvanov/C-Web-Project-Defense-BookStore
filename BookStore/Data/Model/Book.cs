using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data.Model
{
    public class Book
    {
        public string Id { get; init; } = Guid.NewGuid().ToString();

        public string BookTitle { get; set; }

        public int Pages { get; set; }

        public string ImagePath { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string AuthorId { get; set; }
        public Author Author { get; set; }
        
        public double Recomendations { get; set; }
    }
}

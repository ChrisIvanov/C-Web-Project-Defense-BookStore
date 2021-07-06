using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data.Model
{
    public class Book
    {
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        public string BookTitle { get; set; }

        [Required]
        public int Pages { get; set; }

        public string ImagePath { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Description { get; set; }

        [Required]
        public string AuthorId { get; set; }
        public Author Author { get; set; }
        
        public double Recomendations { get; set; }
    }
}

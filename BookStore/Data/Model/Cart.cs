namespace BookStore.Data.Model
{
    using System;
    using System.Collections.Generic;

    public class Cart
    {
        public string Id { get; init; } = Guid.NewGuid().ToString();

        public ICollection<Book> Books { get; set; } = new List<Book>();

        public ICollection<Movie> Movies { get; set; } = new List<Movie>();

        public ICollection<Music> Music { get; set; } = new List<Music>();

        public ICollection<Game> Games { get; set; } = new List<Game>();

    }
}

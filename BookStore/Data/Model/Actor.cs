namespace BookStore.Data.Model
{
    using System;
    using System.Collections.Generic;

    public class Actor
    {
        public string Id { get; init; } = Guid.NewGuid().ToString();

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Movie> ActorMovies { get; set; }
    }
}
namespace BookStore.Data.Model
{
    using System;
    
    public class Song
    {
        public string Id { get; init; }

        public string Name { get; set; }

        public TimeSpan SongDuration { get; set; }
    }
}
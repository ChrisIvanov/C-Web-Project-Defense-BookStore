namespace BookStore.Data.Model
{
    using System;
    using System.Collections.Generic;

    public class User
    {
        public string Id { get; init; } = Guid.NewGuid().ToString();

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public Cart Cart { get; set; }
    }
}

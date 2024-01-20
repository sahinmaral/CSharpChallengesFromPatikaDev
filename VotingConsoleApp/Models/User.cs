namespace VotingConsoleApp
{
    class User
    {
        public User()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string FirstName { get; set; }= null!;
        public string LastName { get; set; }= null!;
        public string Email { get; set; }= null!;
        public string Username { get; set; }= null!;
        public string Password { get; set; } = null!;
    }
}
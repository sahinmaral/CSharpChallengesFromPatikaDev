namespace VotingConsoleApp
{
    class Category
    {
        public Category()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
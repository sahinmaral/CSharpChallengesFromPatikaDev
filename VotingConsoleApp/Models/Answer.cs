namespace VotingConsoleApp
{
    class Answer
    {
        public Answer()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string Content { get; set; } = null!;
    }
}
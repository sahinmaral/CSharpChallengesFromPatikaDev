namespace VotingConsoleApp
{
    class Vote
    {   
        public Vote()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string Content { get; set; } = null!;
        public List<Answer> Answers { get; set; } = null!;
        public Category Category { get; set; } = null!;
        public List<UserAnswer> UserAnswers { get; set; } = null!;
        public DateTime ExpiredAt { get; set; }
        public User CreatedUser { get; set; } = null!;
    }
}
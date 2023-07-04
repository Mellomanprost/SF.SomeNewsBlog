namespace SNB.DAL.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string? Content { get; set; }
        public DateTime DateAdd { get; set; }
        public string? UserName { get; set; }

        //public Guid UserId { get; set; }  при использовании создается копия в Identity
        public User? User { get; set; }
        public Guid PostId { get; set; }
        public Post? Post { get; set; }
    }
}

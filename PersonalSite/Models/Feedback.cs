namespace PersonalSite.Models
{
    public class Feedback
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
        public DateTime DatePosted { get; set; }
    }
}

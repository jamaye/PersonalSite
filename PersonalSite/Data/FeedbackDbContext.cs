    using Microsoft.EntityFrameworkCore;
using PersonalSite.Models;

namespace PersonalSite.Data
{
    public class FeedbackDbContext : DbContext
	{
        public FeedbackDbContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<Feedback> Feedbacks { get; set; }
    }
}

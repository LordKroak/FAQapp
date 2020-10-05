using System.Linq;
using Microsoft.EntityFrameworkCore;
using FAQapp.Models;

namespace FAQapp.Models
{
    public class FAQContext : DbContext
    {
        public FAQContext(DbContextOptions<FAQContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Name = "General" },
                new Category { CategoryID = 2, Name = "History" }
                );

            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicID = 1, Name = "Religion" },
                new Topic { TopicID = 2, Name = "Characters" },
                new Topic { TopicID = 3, Name = "Location" },
                new Topic { TopicID = 4, Name = "Faction" }
                );
            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    QuestionID = 1,
                    CategoryID = 1,
                    TopicID = 4,
                    FAQ = "What are the Lizardmen? A group of 4 races created by the Old Ones to oppose Chaos and teach the younger races."
                },
                new Question
                {
                    QuestionID = 2,
                    CategoryID = 1,
                    TopicID = 1,
                    FAQ = "Who are the Old Ones? A race of hyper-advanced aliens who created the Lizardmen, Elves, Dwarfs, Humans, Ogres, Giants, and Halflings."
                },
                new Question
                {
                    QuestionID = 3,
                    CategoryID = 2,
                    TopicID = 1,
                    FAQ = "Where are the Old Ones? The Old Ones either fled or died with the coming of Chaos when the Polar Gates collapsed."
                },
                new Question
                {
                    QuestionID = 4,
                    CategoryID = 1,
                    TopicID = 3,
                    FAQ = "Where do the Lizardmen live? In the jungles of Lustria and the Southlands."
                },
                new Question
                {
                    QuestionID = 5,
                    CategoryID = 1,
                    TopicID = 2,
                    FAQ = "Who is the strongest Slann? The strongest living Slann is Lord Mazdamundi."
                },
                new Question
                {
                    QuestionID = 6,
                    CategoryID = 1,
                    TopicID = 2,
                    FAQ = "Who is the strongest Saurus? Kroq'Gar, an ancient saurus leads the lizardmens armies as their general."
                },
                new Question
                {
                    QuestionID = 7,
                    CategoryID = 2,
                    TopicID = 4,
                    FAQ = "Who are the Lizardmen's main enemy? Their main enemy is Chaos."
                }
            );
        }
    }
}
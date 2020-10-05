//auto generated
using FAQapp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;

namespace FAQapp.Migrations
{
    [DbContext(typeof(FAQContext))]
    partial class FAQContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FAQapp.Models.Category", b =>
            {
                b.Property<int>("CategoryID")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Name")
                    .IsRequired();

                b.HasKey("CategoryID");

                b.ToTable("Categories");

                b.HasData(
                        new
                        {
                            CategoryID = 1,
                            Name = "General"
                        },
                        new
                        {
                            CategoryID = 2,
                            Name = "History"
                        });
            });

            modelBuilder.Entity("FAQapp.Models.Topic", b =>
            {
                b.Property<int>("TopicID")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Name")
                    .IsRequired();

                b.HasKey("TopicID");

                b.ToTable("Topics");

                b.HasData(
                    new
                    {
                        TopicID = 1,
                        Name = "Religion"
                    },
                    new
                    {
                        TopicID = 2,
                        Name = "Characters"
                    },
                    new
                    {
                        TopicID = 3,
                        Name = "Location"
                    },
                    new
                    {
                        TopicID = 4,
                        Name = "Faction"
                    });

            });

            modelBuilder.Entity("FAQapp.Models.Question", b =>
            {
                b.Property<int>("QuestionID")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("CategoryID");

                b.Property<int>("TopicID");

                b.Property<string>("FAQ")
                    .IsRequired();

                b.HasKey("QuestionID");

                b.HasIndex("CategoryID");
                b.HasIndex("TopicID");

                b.ToTable("Questions");

                b.HasData(
                    new Question
                    {
                        QuestionID = 1,
                        CategoryID = 1,
                        TopicID = 4,
                        FAQ = "What are the Lizardmen? A group of 4 races created by the Old Ones to oppose Chaos and teach the younger races."
                    },
                    new
                    {
                        QuestionID = 2,
                        CategoryID = 1,
                        TopicID = 1,
                        FAQ = "Who are the Old Ones? A race of hyper-advanced aliens who created the Lizardmen, Elves, Dwarfs, Humans, Ogres, Giants, and Halflings."
                    },
                    new
                    {
                        QuestionID = 3,
                        CategoryID = 2,
                        TopicID = 1,
                        FAQ = "Where are the Old Ones? The Old Ones either fled or died with the coming of Chaos when the Polar Gates collapsed."
                    },
                    new
                    {
                        QuestionID = 4,
                        CategoryID = 1,
                        TopicID = 3,
                        FAQ = "Where do the Lizardmen live? In the jungles of Lustria and the Southlands."
                    },
                    new
                    {
                        QuestionID = 5,
                        CategoryID = 1,
                        TopicID = 2,
                        FAQ = "Who is the strongest Slann? The strongest living Slann is Lord Mazdamundi."
                    },
                    new
                    {
                        QuestionID = 6,
                        CategoryID = 1,
                        TopicID = 2,
                        FAQ = "Who is the strongest Saurus? Kroq'Gar, an ancient saurus leads the lizardmens armies as their general."
                    },
                    new
                    {
                        QuestionID = 7,
                        CategoryID = 2,
                        TopicID = 4,
                        FAQ = "Who are the Lizardmen's main enemy? Their main enemy is Chaos."
                    });
            });

            modelBuilder.Entity("FAQapp.Models.Question", b =>
            {
                b.HasOne("FAQapp.Models.Category", "Category")
                    .WithMany()
                    .HasForeignKey("CategoryID");



                    b.HasOne("FAQapp.Models.Topic", "Topic")
                    .WithMany()
                    .HasForeignKey("TopicID");
    
            });
#pragma warning restore 612, 618
        }
    }
}
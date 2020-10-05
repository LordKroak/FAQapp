using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FAQapp.Models
{
    public class Question
    {
        // EF auto generates this value
        public int QuestionID { get; set; }
        public int CategoryID { get; set; }

        public Category Category { get; set; }

        public Topic Topic { get; set; }

        public int TopicID { get; set; }

        public string FAQ { get; set; }
    }
}
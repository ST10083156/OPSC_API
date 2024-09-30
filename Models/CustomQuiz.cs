using OPSC_API.Models;
using System.Collections.Generic;

namespace QuizApp.Models
{

    public class CustomQuiz
    {
        public string QuizName { get; set; }
        public string Category { get; set; }
        public List<Question> Questions { get; set; }
        public string UserID { get; set; }
    }
}

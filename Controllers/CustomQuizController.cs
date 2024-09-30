using Microsoft.AspNetCore.Mvc;
using QuizApp.Models;
using System.Collections.Generic;

namespace QuizApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomQuizController : ControllerBase
    {
        [HttpPost("CreateQuiz")]
        public IActionResult CreateQuiz([FromBody] CustomQuiz customQuiz)
        {
            if (customQuiz == null)
            {
                return BadRequest("Quiz data is null");
            }

            return Ok(new ApiResponse
            {
                Success = true,
                Message = "Quiz created successfully"
            });
        }

        
        [HttpGet("GetMyQuizzes/{uid}")]
        public IActionResult GetMyQuizzes(string uid)
        {
           
            var quizzes = new List<CustomQuiz>
            {
              /*  new CustomQuiz { QuizName = "Sample Quiz", Category = "General" },
                new CustomQuiz { QuizName = "Another Quiz", Category = "Science" }*/
            };

            return Ok(quizzes);
        }
    }
}

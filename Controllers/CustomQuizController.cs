using FirebaseAdmin.Auth;
using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;
using OPSC_API.Models;

namespace OPSC_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomQuizController : Controller
    {
        [HttpPost("create-quiz")]
        public async Task<IActionResult> CreateQuiz([FromBody] Quiz quiz)
        {
            try
            {
                DocumentReference docRef = await FirestoreManager.db.Collection("CustomQuizzes").AddAsync(quiz);
                return Ok(new { message = "Quiz added successfully", quizId = docRef.Id });
            }
            catch(Exception e) 
            {
            return BadRequest(e.Message);
            }
        }

        [HttpGet("my-quizzes")]
        public async Task<IActionResult> GetMyQuizzes(string uid)
        {
            try
            {
                QuerySnapshot docRef = await FirestoreManager.db.Collection("CustomQuizzes").WhereEqualTo("UserID",uid).GetSnapshotAsync();

                List<CustomQuiz> quizzes = new List<CustomQuiz>();

                foreach(DocumentSnapshot doc in docRef.Documents)
                {
                    if (doc.Exists)
                    {
                        CustomQuiz customQuiz = doc.ConvertTo<CustomQuiz>();

                        quizzes.Add(customQuiz);
                    }
                   
                }
                return Ok(quizzes);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}

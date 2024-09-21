using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;
using OPSC_API.Models;

namespace OPSC_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScoreController : Controller
    {

        [HttpGet("get-scores")]
        public async Task<IActionResult> GetScores([FromBody]string UserID)
        {
            try
            {
                QuerySnapshot snapshot = await FirestoreManager.db.Collection("Scores").WhereEqualTo("UserID", UserID).GetSnapshotAsync();
                List<Score> scores = new List<Score>();

                foreach(var snap in snapshot)
                {
                    Score score = snap.ConvertTo<Score>();
                    scores.Add(score);
                }
                return Ok(scores);

            }

            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("add-score")]
        public async Task<IActionResult> AddScore([FromBody]Score score)
        {
            try
            {
                DocumentReference docRef = await FirestoreManager.db.Collection("Scores").AddAsync(score);
                return Ok(new { message = "Quiz added successfully" });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}

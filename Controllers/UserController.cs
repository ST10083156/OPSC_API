using FirebaseAdmin.Auth;
using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;
using OPSC_API.Models;

namespace OPSC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {

        [HttpPost("add-user")]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            try
            {
                DocumentReference docRef = await FirestoreManager.db.Collection("Users").AddAsync(user);
                return Ok(new { message = "Quiz added successfully", quizId = docRef.Id });
            }

            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("update-settings")]
        public async Task<IActionResult> UpdateSettings([FromBody] Settings settings, string uid)
        {
            try
            {
                DocumentReference docRef = FirestoreManager.db.Collection("Users").Document(uid);

                await docRef.UpdateAsync(new Dictionary<string, object>
                {
                    { "Settings", settings }
                });

                return Ok(new { message = "Settings updated successfully" });
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}

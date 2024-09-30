using Google.Cloud.Firestore;
using Microsoft.AspNetCore.Mvc;
using OPSC_API.Models;

namespace OPSC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("add-user")]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            
            if (string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Username))
            {
                return BadRequest(new { message = "Name and Username cannot be empty." });
            }

            try
            {
                
                DocumentReference docRef = await FirestoreManager.db.Collection("Users").AddAsync(user);

                
                return Ok(new { message = "User added successfully", userId = docRef.Id });
            }
            catch (Exception e)
            {
                
                Console.WriteLine(e.Message);  

                
                return BadRequest(new { message = $"Failed to add user: {e.Message}" });
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
            catch (Exception e)
            {
               
                return BadRequest(new { message = $"Failed to update settings: {e.Message}" });
            }
        }
    }
}

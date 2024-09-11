using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostbackController : ControllerBase
    {
        // Simulate a list of keys (this could be replaced by a database)
        private static List<string> keys = new List<string>
        {
            "key1-abc-123",
            "key2-def-456",
            "key3-ghi-789"
        };

        // This method handles GET requests to /api/postback
        [HttpGet]
        public IActionResult ReceivePostback([FromQuery] string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                // Simulate returning a key (replace with actual logic)
                string key = keys.FirstOrDefault();

                if (!string.IsNullOrEmpty(key))
                {
                    // Return the key in JSON format
                    return Ok(new { key = key });
                }
                else
                {
                    // No keys available (replace this with your own logic)
                    return NotFound("No keys available.");
                }
            }
            else
            {
                // If no valid ID is provided, return a Bad Request
                return BadRequest("Invalid request. No ID provided.");
            }
        }
    }
}

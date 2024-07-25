using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        [HttpGet("download")]
        public IActionResult DownloadFile()
        {
            // Path to the file
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "GeneratedFiles", "kek.txt");

            // Check if the file exists
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            // Get the file content type
            var contentType = "application/octet-stream";
            var fileName = Path.GetFileName(filePath);

            // Read the file as a byte array
            var fileBytes = System.IO.File.ReadAllBytes(filePath);

            // Return the file as a FileContentResult
            return File(fileBytes, contentType, fileName);
        }
    }
}

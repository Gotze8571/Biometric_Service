using Bio_Core.DataObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bio_API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase 
    {
        public ImageController()
        { 
        }

        public async Task<IActionResult> GetImage(ImageCaptureRequest request) {
            return null;

        }

    }
}

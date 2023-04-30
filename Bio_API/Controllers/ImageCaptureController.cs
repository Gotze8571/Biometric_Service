using Bio_Core.DataObject;
using Bio_Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bio_API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ImageCaptureController : ControllerBase 
    {
        private readonly ImageCapture _imageCapture;
        public ImageCaptureController()
        { 
        }

        public async Task<IActionResult> GetImageCaptured(string RequestId) 
        {
            return null;
        }

        [HttpPost]
        public async Task<IActionResult> PostCaptureImage(ImageCaptureRequest request) {

            return null;

        }

        

    }
}

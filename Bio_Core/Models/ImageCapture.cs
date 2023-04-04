using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio_Core.Models {
    public class ImageCapture 
    {
        public Double Size { get; set; }
        public string Description { get; set; }
        public byte Image { get; set; }
        public DateTime CaptureDate { get; set; }
    }
}

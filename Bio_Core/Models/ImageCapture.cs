using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio_Core.Models {
    public class ImageCapture 
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public Double Dimension { get; set; }
        public Double Size { get; set; }
        public string Description { get; set; }
        public Byte Image { get; set; }
        public DateTime CaptureDate { get; set; }
    }
}

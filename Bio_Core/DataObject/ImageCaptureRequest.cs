using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio_Core.DataObject {  
    public class ImageCaptureRequest 
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public string ImageType { get; set; }
        public string Dimension_Size { get; set; }
        public string Format  { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime ImageCreated { get; set; }

    }
}

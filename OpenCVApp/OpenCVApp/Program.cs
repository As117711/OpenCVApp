using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.XFeatures2D;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;


namespace OpenCVApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var modelImage = new Image<Gray, byte>(@"model.jpg"))
            {
                var surfDetector = new SURF(400);
                var ImageFeatures = surfDetector.Detect(modelImage, null);

            }
        }
    }
}

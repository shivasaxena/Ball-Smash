using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metalop.Emgucv.BallSmash.Helpers
{
    // Data Structure to store the data of the circles
    struct CircleData
    {
        public CircleF circle;
        public Gray intensity;
        public int thickness;

        public CircleData(CircleF Circle, Gray Intensity, int Thickness)
        {
            circle = Circle;
            intensity = Intensity;
            thickness = Thickness;
        }

    }
}

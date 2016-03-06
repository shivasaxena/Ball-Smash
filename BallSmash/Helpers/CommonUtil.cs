using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metalop.Emgucv.BallSmash.UI.Helpers
{
    class  CommonUtil
    {
        // function to generate the random number

        public static int generateRandomXCoordinate(int xThreshold)
        {
            Random r = new Random();
            int ran = r.Next(0, xThreshold);
            return ran;

        }

        public static int generateRandomYCoordinate(int yThreshold)
        {
            Random r = new Random();
            int ran = r.Next(0, yThreshold);
            return ran;

        }
    }
}

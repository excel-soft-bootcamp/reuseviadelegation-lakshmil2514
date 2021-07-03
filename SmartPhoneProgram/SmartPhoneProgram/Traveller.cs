using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPhoneProgram
{
    class Traveller
    {
        public void Hike(IGPS gps)
        {
            gps.Navigate();
        }
    }
}

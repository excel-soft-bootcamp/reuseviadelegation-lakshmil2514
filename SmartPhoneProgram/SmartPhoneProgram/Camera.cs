using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPhoneProgram
{
    class Camera :ICamera
    {
        public void Click()
        {
            Console.WriteLine("Capture via Camera");

        }
    }
}

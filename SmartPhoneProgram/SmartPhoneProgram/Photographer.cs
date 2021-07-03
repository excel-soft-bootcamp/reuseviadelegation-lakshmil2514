using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPhoneProgram
{
    class Photographer
    {

        public void Capture(ICamera _camera)
        {
            _camera.Click();
        }
    }
}

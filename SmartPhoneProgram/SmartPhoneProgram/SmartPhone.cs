using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPhoneProgram
{
   
        class SmartPhone : ICamera,IGPS,IPhone
        {
            ICamera _camera;
            IGPS _gps;
            IPhone _phone;

            public void SetCamera(ICamera camera)
            {
                this._camera = camera;
            }
            public void SetGPS(IGPS gps)
            {
                this._gps = gps;
            }
            public void SetPhone(IPhone phone)
            {
                this._phone = phone;
            }

            public void Click()
            {
                this._camera.Click();
            }
            public void Navigate()
            {
                this._gps.Navigate();
            }
            public void Hangup()
            {
                this._phone.Hangup();
            }
            public void Release()
            {
                this._phone.Release();
            }

        }
    }


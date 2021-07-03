using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPhoneProgram
{
    
        class Phone : IPhone
        {
            public void Hangup()
            {
                Console.WriteLine("Call Hangup");
            }
            public void Release()
            {
                Console.WriteLine("Call Release");
            }
        }
    }


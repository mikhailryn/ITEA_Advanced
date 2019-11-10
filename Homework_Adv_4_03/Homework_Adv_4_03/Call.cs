﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Adv_4_03
{
    class Call
    {
        public event MyDelegate PhoneCall;
        public void DoEvent()
        {
            if (PhoneCall != null)
                PhoneCall.Invoke();  
        }
    }
}
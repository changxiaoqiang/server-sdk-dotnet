﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace io.rong.messages
{
    abstract class BaseMessage
    {
        public abstract String GetType();

        override
        public abstract String ToString();
    }
}

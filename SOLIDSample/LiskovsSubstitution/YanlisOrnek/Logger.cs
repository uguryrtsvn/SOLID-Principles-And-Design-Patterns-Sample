﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.LiskovsSubstitution.YanlisOrnek
{
    public abstract class Logger
    { 
        public abstract void OpenConnection();
        public abstract void CloseConnection();
        public abstract void Log();
    }
}

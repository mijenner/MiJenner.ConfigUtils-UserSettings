﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiJenner.ConfigUtils
{
    public enum UserDataPolicy
    {
        Unknown, 
        PolicyFileDocument,
        PolicyFileAppDataLocal,
        PolicyFileAppDataRoaming,
    }
}
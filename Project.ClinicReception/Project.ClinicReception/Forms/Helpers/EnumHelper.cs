﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.ClinicReception.Helpers
{
    public class EnumHelper
    {
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
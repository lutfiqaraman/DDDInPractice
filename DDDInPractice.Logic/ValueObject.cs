﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDInPractice.Logic
{
    public abstract class ValueObject<T> where T :ValueObject<T>
    {

    }
}

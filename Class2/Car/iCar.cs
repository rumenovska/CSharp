﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public interface ICar
    {
         string MotorNumber { get; set; }
         void Refuel();

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5
{
    // define the IDrivable interface
    public interface IDrivable
    {
        // method declarations
        void Start();
        void Stop();
        // property declaration
        bool Started
        {
            get;
        }
    }
    // define the ISteerable interface
    public interface ISteerable
    {
        // method declarations
        void TurnLeft();
        void TurnRight();
    }
    // define the IMovable interface (derived from IDrivable and ISteerable)
    public interface IMovable : IDrivable, ISteerable
    {
        // method declarations
        void Accelerate();
        void Brake();
    }

}

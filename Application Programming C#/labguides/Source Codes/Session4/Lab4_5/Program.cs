﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_5
{
   
    class Program
    {
        static void Main(string[] args)
        {
            // create a Car object
            Car myCar = new Car();
            // call myCar.Start()
            Console.WriteLine("Calling myCar.Start()");
            myCar.Start();
            // call myCar.TurnLeft()
            Console.WriteLine("Calling myCar.TurnLeft()");
            myCar.TurnLeft();
            // call myCar.Accelerate()
            Console.WriteLine("Calling myCar.Accelerate()");
            myCar.Accelerate();
            Console.ReadLine();
        }
    }

}

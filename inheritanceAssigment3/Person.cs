﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceAssigment3
{
    public abstract class Person

    {
        public virtual void sayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.ReadLine();
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
    }


}

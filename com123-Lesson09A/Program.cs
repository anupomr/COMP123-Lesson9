using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Name:
Anupom
Des: This is My Driver Class
Version: 0.2 -add power
*/
namespace com123_Lesson09A
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Supwr Drood");
            superHuman.Powers.Add(new Power("Anupom",50));
            superHuman.DisplayPower();
        }
    }
}

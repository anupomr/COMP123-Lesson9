using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Name: Anupom Roy
Date: 
Des: New power datatype
version: 0.2 Add Custom constractor
*/
namespace com123_Lesson09A
{

    /// <summary>
    /// The Power
    /// </summary>
    public class Power
    {
        public string Name { get; set; }
        public int Rank { get; set; }

        public Power(string name, int Rank)

        {
            this.Name = name;
            this.Rank = Rank;

        }
    }
}
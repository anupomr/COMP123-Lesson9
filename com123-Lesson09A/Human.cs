using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Name:
Anupom
Version: 0.1 -class created
*/

namespace com123_Lesson09A
{
    /// <summary>
    /// this is Humen abstract cluss
    /// </summary>
    public abstract class Human
    {
        //Private Fields
        private string _name;


        // Public properties
        public string Name
        {
            get
            {

                return this._name;
            }

            set
            {
                this._name = value;
            }
        }
        // constract-----------------
        public Human(string name)
        {

        }
    }
}
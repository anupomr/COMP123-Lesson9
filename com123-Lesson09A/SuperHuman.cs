using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Name: Anupom Roy
Date: 
version: 0.2 Added Private initialized Method
*/
namespace com123_Lesson09A
{
    /// <summary>
    /// This is super Human subclasss
    /// </summary>
    public class SuperHuman : Human
    {
        // private fields
        private List<Power> _power;
        // Public properties
        // constract-----------------
        public SuperHuman(string name)
            :base(name)
        {
            this._initialize();
        }
        //Private mathod
        /// <summary>
        /// 
        /// </summary>
        private void _initialize()
        {
            this._power = new List<Power>();
        }
    }
}
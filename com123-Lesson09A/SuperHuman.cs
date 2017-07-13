using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Name: Anupom Roy
Date: 
version: 0.6 Added overriden to string method
*/
namespace com123_Lesson09A
{
    /// <summary>
    /// This is super Human subclasss
    /// </summary>
    public class SuperHuman : Human
    {
        // private fields
        private List<Power> _powers;
        // Public properties
        public List<Power> Powers {
            get
            {
                return this._powers;
            }
             }

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
            this._powers = new List<Power>();
        }
        //public st
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
        public void DisplayPower()
        {
            foreach (var power in Powers)
            {
                Console.WriteLine("Name : "+power.Name+"Rank"+ power.Rank);
            }
        }
        public override string  ToString() {
            string outputString="";
            outputString += "========================================================\n";
            outputString += "Super humen Name " + this.Name + "\n";
            outputString += "========================================================\n";
            foreach (Power power in this.Powers)
            {
                outputString += "Power:" + power.Name + " Rank :  " + power.Rank + "\n";
            }
            return outputString;
        }
        /// <summary>
        /// This methods  override
        /// </summary>
        public override void DisplaySkill()
        {
            Console.WriteLine("Not implemented");
        }
    }
}
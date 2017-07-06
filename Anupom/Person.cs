using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom
{
    /// <summary>
    /// this parson Super classs
    /// </summary>
    public class Person
    {
        // proivate instance variable
        /// <summary>
        /// 
        /// </summary>
        private string _name;
        private int _age;

        //public properties
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
        public int Age
        {
            get
            {
                return this._age;
            }

            set { this._age = value; }
                }

        //this is the constratracto
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        /// <summary>
        /// 
        /// </summary>
        public void Talks()
        {
            Console.WriteLine(this._name+"is talking");
        }
    
    }
}

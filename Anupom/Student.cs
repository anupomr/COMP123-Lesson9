using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom
{
    public class Student :Person
    {
        // private instance variable
        private string _studentID;
        public string StudentID
        {
            get { return _studentID; }
            set { this._studentID = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public Student(string name, int age, string studentID)
            :base(name, age)
        {
            this.StudentID = studentID;

        }
        /// <summary>
        /// 
        /// </summary>
        public void Studies()
        {
            Console.WriteLine(this.Name+"Studing");
        }
    }
}

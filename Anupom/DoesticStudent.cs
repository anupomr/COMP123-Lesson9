using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anupom
{
    public class DoesticStudent: Student
    {
        //
        public int DomesticAddress
        {
            get;


            set;
        }
        public DoesticStudent(string name, int age, string studentID)
            :base(name,age, studentID)
        {
            //this.DomesticAddress ;
        }
    }
}
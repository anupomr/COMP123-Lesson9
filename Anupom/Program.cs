using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world" );
            Console.WriteLine("-------------");
            Console.WriteLine("");
            Person p = new Person("Tom",25);
            p.Talks();
            Student s1 = new Student("Joan", 19, "3205412");
            s1.Studies();
            s1.Talks();
            DoesticStudent d1 = new DoesticStudent("Marry", 22, "2354");
            d1.Talks();
        }
    }
}

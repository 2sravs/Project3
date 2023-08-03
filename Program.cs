using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConAppParameterizedConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student stud1 = new Student(12, "Sam", new DateTime(day: 12, month: 09, year: 2010));
            //Student stud2 = new Student(11, "Deep", new DateTime(day: 09, month: 11,year: 2009));
            //Console.WriteLine("*** Student one***");
            //stud1.Display();
            //Console.WriteLine("***Student two ***");
            //stud2.Display();



            Student student = new Student();
            student.Display();
            Student stud1 = new Student(12, "Sam", new DateTime(day: 12, month: 09, year: 2010));
            stud1.Display();
            Console.ReadKey();
        }
    }
}

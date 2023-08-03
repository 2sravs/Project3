using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppParameterizedConstructor
{ 
    
   public class Student
    {

        int id;
        string name;
        DateTime dob;
            
        public Student()
            
        {
               Console.WriteLine("Default Constructor");
            id = -1;
            name = "not given";
            dob = DateTime.Now;

        }              

           
        public Student(int id, string name, DateTime dob)
            
        {
                Console.WriteLine("Parameterized Constructor of Student");
                this.id = id;
                this.name = name;
                this.dob = dob;
           
        }
           
        public void Display()
            {
                Console.WriteLine("Student Details as Follows!!!");
                Console.WriteLine("ID:->" + id+"\t Name:->" + name + "\t Date of Birth:->" + dob);
            }
        }
    }

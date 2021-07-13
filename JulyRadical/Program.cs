using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulyRadical
{
    class Program
    {
        static void Main(string[] args)
        {

           // Developers d = new Developers();
            
            //ArrayList
            //Any Type of DataType
            ArrayList arr = new ArrayList();
            arr.Add(101);//int --Object
            arr.Add("Rakesh");

            Student s = new Student();
            s.ID = 201;
            s.Name = "Ramesh";

            arr.Add(s);

            //item--single
            foreach (var item in arr)
            {
                if (item.GetType().Name.Equals("Student"))
                {
                    var myobj=item as Student;
                    Console.WriteLine(myobj.ID+" "+myobj.Name);
                }

                else
                {
                    Console.WriteLine(item);
                }
                
            }

            Console.ReadLine();

        }
               
    }

    class Student
    {

        public int ID { get; set; }
        public string Name { get; set; }
    

    }


    //class Teacher---TID,Tname----
    //STudent Record:
    //101 ramesh
    //102 Rakesh

    //Teacher Records
    //201 James
    //202 Maya


    

    

   
   
}

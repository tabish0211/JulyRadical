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
            List<Student> students = new List<Student>();
            Student student_one = new Student();
            student_one.ID = 101;
            student_one.Name = "Rakesh";

            Student student_two = new Student();
            student_two.ID = 102;
            student_two.Name = "Ramesh";

            Student student_three = new Student();
            student_three.ID = 103;
            student_three.Name = "James";

            Student student_four = new Student();
            student_four.ID = 104;
            student_four.Name = "Maya";

            Student student_five = new Student();
            student_five.ID = 105;
            student_five.Name = "Kunal";

            students.Add(student_one);
            students.Add(student_two);
            students.Add(student_three);
            students.Add(student_four);
            students.Add(student_five);

            //All records
            foreach (Student item in students)
            {
                Console.WriteLine(item.ID +" "+item.Name);
            }

            //LINQ--Language Integrated Query---
            int count = students.Count();
            Console.WriteLine(count); 

           // Student result=students.Where(s=>s.ID== )
            var resul = students.Where(s => s.ID == 101).ToList();

            foreach (var item in resul)
            {
                Console.WriteLine(item.ID + " " + item.Name);
            }

            var resultWithName = students.Where(s => s.Name.Contains("R")).ToList();



           

            Console.WriteLine();


    

            Console.ReadLine();

        }
               
    }

    class Student
    {

        public int ID { get; set; }
        public string Name { get; set; }


    

    }



    

    

   
   
}

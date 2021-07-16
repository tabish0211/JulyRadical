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
            calc obj = new calc();
            obj.Divide();

            Console.ReadLine();

        }
               
    }


    class calc
    {

        public void Divide()
        {

            int a, b, r;
            Console.WriteLine("enter a and b values");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            try
            {
               // string v = null;
                //string z = v.ToString();
                MyMethod();
                //r = a / b;
                //Console.WriteLine(r);
            }


            catch (MyCustomException ex)
            {
                Console.WriteLine(ex.Message);

            } 
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine("may be you have done some wrong input like zero so we cant process");

            }

            finally
            { 
            
                //always executes--whether exceptions cimes or not it will always executed 
            
            
            }


          

            Console.WriteLine("Program is about to exit");
          

        
        }

        private void MyMethod()
        {
            int i = 1;
            if (i==1)
            {
                throw new MyCustomException();
            }
        }

    
    
    }

    class MyCustomException : Exception
    {
        public MyCustomException():base("This is my custom Message")
        {

        }

    }
   
}

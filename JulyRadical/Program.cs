using System;
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
            //var customer = new Customer();
            //int disc=customer.Discount();
            //Console.WriteLine("base customer: "+disc);

            var goldCustomer = new GoldCustomer("James","1");
            int disc=goldCustomer.Discount();
            Console.WriteLine("Gold Customer "+disc);

            Console.ReadLine();

        }
               
    }

    class Customer
    {
        private string _custName;
        public Customer(string custName)
        {
            this._custName = custName;
            Console.WriteLine("Hey i am from base customer");
        }

        //method overriding---true polymorphism
        public virtual int Discount()
        {             

            return 10;
        
        }
    
    }

    //base to child in constructor---destructor--child to base
    class GoldCustomer : Customer
    {
       // private string _goldCustName;
        private string _planType;

        public GoldCustomer(string custName,string plantype):base(custName)
        {
            //this._goldCustName = custName;
            this._planType = plantype;
            Console.WriteLine("Hey i am from gold customer");
        }
        public override int Discount()
        {
            return (5+base.Discount());
        }
    }
    


   
}

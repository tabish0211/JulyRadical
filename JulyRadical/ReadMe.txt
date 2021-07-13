

Day-3
//break= to get out of the loop
            //for (int i = 1; i < 11; i++)
            //{
            //    if (i==6)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
                
            //}

            //1234678910

            for (int i = 1; i < 11; i++)
            {
                if (i==5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }



			Console.WriteLine("Enter the count for roll number");
            int rollNumberCount = Convert.ToInt32(Console.ReadLine());

            int[] arrRollNumber = new int[rollNumberCount];

            Console.WriteLine("Enter {0} rollNumbers",rollNumberCount);

            for (int i = 0; i < arrRollNumber.Length; i++)
            {
                arrRollNumber[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You have enterd below roll numbers");
            for (int i = 0; i < arrRollNumber.Length; i++)
            {
                Console.WriteLine("Rollnumber at {0} is {1}",i,arrRollNumber[i]);
            }






			 Console.WriteLine("Enter the row count for roll numbers");
            int rowCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the col count for roll numbers");
            int colCount = Convert.ToInt32(Console.ReadLine());

            int[,] arrRollNumber = new int[rowCount,colCount];

            for (int row = 0; row < arrRollNumber.GetLength(0); row++)
            {
                Console.WriteLine("Enter {0} rollNumbers for the row number", colCount,row);

                for (int column = 0; column < arrRollNumber.GetLength(1); column++)
                {
                    arrRollNumber[row,column] = Convert.ToInt32(Console.ReadLine());
                }
                
            }


			 //how to display---assignment
            //the total matrix 3x3 with below output
           /* 101 102 103
            104 105 106
            107 108 109*/
           





		   static void Main(string[] args)
        {
           

            //primitive--int,float,char--on stack--on compile time
            //ref type--array,classes,string---string

            int num1 = 10,num2=12;
            int res, diff;
           // Sum(num1, num2);//pass by value
           // Sum(ref num1, ref num2);//pass by ref

           int myres= SumofTwoNumbers(ref num1, ref num2, out res, out diff);
            Console.WriteLine(res +" "+diff);
            Console.ReadLine();

        }

        private static void Sum(ref int num1, ref int num2)
        {
            int res = num1 + num2;
            Console.WriteLine(res);
        }

        //private static void Sum(int num1, int num2)
        //{
        //    int res = num1 + num2;
        //    Console.WriteLine(res);
        //}


        static int SumofTwoNumbers(ref int x, ref int y,out int res,out int diff)
        {
             res = x + y;
             diff = x - y;
            Console.WriteLine(res);
            return 0;
        
        }



		
            var x = 1;
            var s = "Rakesh";
            //s = 1;compile time--must to initailize
            //var x;
            //x = 1;

            dynamic y;
            y = 1;
            y = "Rakesh";


			

            sum(1,2,3);
			
        static void sum(int x, int y=1, int z=1)
        {
            int res = x + y + z;
            Console.WriteLine(res);
        
        }

		static void Main(string[] args)
        {
            AddEmployee(1, "Rahul", 123, "xyz");
            AddEmployee(name: "yz", id: 1, doj: "abc", sal: 2);
            Console.ReadLine();

        }


        static void AddEmployee(int id, string name, int sal, string doj)
        { 
        
        }









		
        static void Main(string[] args)
        {

            //string s = "xyz";
            //s = "Rakesh";

            //var s = new StringBuilder("Hello");
            //s.Append(" hi");
            //Console.WriteLine(s);

            //ToString()--Convert.ToSting()
            string s = null;
          //  Console.WriteLine(s.ToString());//cant handle null throw an exception
            Console.WriteLine(Convert.ToString(s));

            Console.ReadLine();

        }


        static void AddEmployee(int id, string name, int sal, string doj)
        { 
        
        }
      

	  
            

			
            //Jagged array--array of an array
            int[][] arrJagged = new int[3][];
            arrJagged[0] = new int[3];
            arrJagged[1] = new int[4];
            arrJagged[2] = new int[1];

            Console.WriteLine("Enter values for jagged");

            for (int i = 0; i < arrJagged.GetLength(0); i++)
            {
                for (int j = 0; j < arrJagged[i].Length; j++)
                {
                    arrJagged[i][j] = Convert.ToInt32(Console.ReadLine());
                    
                }
            }


            Console.WriteLine("values for jagged");

            for (int i = 0; i < arrJagged.GetLength(0); i++)
            {
                for (int j = 0; j < arrJagged[i].Length; j++)
                {
                    Console.WriteLine(arrJagged[i][j]);
                }
            }





			
            string s = null;
            int? x = null;//db--age--null---break
            x = 10;
            int y = x ?? 1;//when x is null y=1---x is not null then give the value x directly to y



			
            ///Boxing vs unboxing
            
            int i=1;
            Object o = i;

            //when you extract the primitive from reference type then it is unboxing
            int y = (int)o; 







			    class User
    {
        public string passwordAsPublic;
        private string password;

        void show()
        {
            password = "xyz";
        }
    }


	static void Main(string[] args)
        {

            User obj = new User();
            Console.WriteLine(obj.passwordAsPublic);
           // Console.WriteLine(password);

            Console.ReadLine();

        }







		 class User
    {
       
        // private string _password;

        //public void SetPassword(string pswd)
        //{
        //    password = pswd;
        //}

        //public string GetPassword()
        //{
        //    return password;
        //}

        //properties--C# 2.0
        //properties-Encapsulation

         //public string Password
         //{
         //    set {
         //        _password = value;
         //    }
             
         //    get {

         //        return _password;
         //    }

         //}


        public string Password { get; set; }




    }




	 static void Main(string[] args)
        {

            User obj = new User();
          //  Console.WriteLine(obj.passwordAsPublic);
           // Console.WriteLine(password);
            string password = "welcome";
          //  obj.SetPassword(password);
            //string str=obj.GetPassword();

            obj.Password = password;//set block of the property

            Console.WriteLine(obj.Password);


            Console.ReadLine();

        }



		class User
    {
        private int _id;
        private string _uname;
        private string _companyName;


        //constructor overloading
        public User(int id ,string uname)
        {
            this._id = id;
            this._uname = uname;


        }

        public User(int id, string uname,string cnm): this(id, uname)
        {
            
            this._companyName = cnm;


        }


        public void Show()
        {
            Console.WriteLine(_id+" "+_uname);
        
        }

        ~User()
        { 
            //parameters---CLR--calls the destructor
          //native os --filestream---resource free--destructor
          //we cant call destructor--CLR--Syste.GC--Claims memory--destroy
        
        }




    }








	class Student
    {
       // private const int _count=40;
        private readonly int _count;
        public Student(int count)
        {
            //constructor
            _count = count;
        }

        public void Show()
        {
            Console.WriteLine(_count);
        }

        public void AllocateStudent(int count)
        {

          //this._count = count;
        
        }
    
    }







	 static void Main(string[] args)
        {

            var s = new Student(60);
            s.AllocateStudent(30);
            s.Show();
            Console.ReadLine();

        }



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
    







	 //Material---XYZ
    abstract class Hardware
    {
        public void ShowCopyRight()
        {
            Console.WriteLine("This is a copyright");

        }
        public abstract void HardwareName();
    }

    class Iphone:Hardware
    {
        public override void HardwareName()
        {
            Console.WriteLine("This is iphone");

        }
    }

    class SamSung : Hardware
    {
        public override void HardwareName()
        {
            Console.WriteLine("This is Samsung");

        }
    }



	 Hardware iphone = new Iphone();
            iphone.HardwareName();
            iphone.ShowCopyRight();

            Hardware samsung = new SamSung();
            samsung.HardwareName();
            samsung.ShowCopyRight();

            //Hardware hardware = new Hardware();
           // hardware.HadwareName();



		    public static class InstanceFactory{

        public static IDBReadingOperations CreateReadingInstance()
        {

            IDBReadingOperations obj = new MyOracleDataBaseOperations();
            return obj;
        }

        public static IDBWritingOperations CreateWritingInstance()
        {

            IDBWritingOperations obj = new MyOracleDataBaseOperations();
            return obj;
        }
    
    }



    public interface IDBWritingOperations
    {

         void Add();
         void Update();
         void Delete();
         void xyz();

    }

    //Interface is a contract---for the client--abstarction over the class
    public interface IDBReadingOperations
    {

        void Fetch();
        void xyz();

    }

    public class MyOracleDataBaseOperations : IDBReadingOperations, IDBWritingOperations
    {
        public void IDBReadingOperations.xyz()
        { }

        public void IDBWritingOperations.xyz()
        { }
        public void Fetch()
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void test()
        { }
    }


    public class MySqlServerDataBaseOperations : IDBReadingOperations, IDBWritingOperations
    {


        public void Fetch()
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }



	 static void Main(string[] args)
        {


            var obj=InstanceFactory.CreateReadingInstance();
            obj.Fetch();
            obj.xyz();

            var objWriting = InstanceFactory.CreateWritingInstance();
            objWriting.Add();

            
            Console.ReadLine();

        }





		class A
    { 
    
    }

   sealed class B : A
    {



    }

    class c : B { 
    
    
    }






	
            int x = 1;
            int y = ++x + x++ + ++x;
            Console.WriteLine(y);//
            Console.WriteLine(x);//
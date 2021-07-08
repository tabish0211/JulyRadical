

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
      



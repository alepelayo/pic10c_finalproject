using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pic10c_finalproject
{
    class Staff
    {
        //treated similarly to private member variables of a class
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;

        //Constructors in C#: unlike C++, C# will automatically create a default constructor if one is not specified.
        //The default "simply initializes all the fields in the class to default values"
        //first constrctor
        public Staff(string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("---------------------");
        }

        //second constructor
        public Staff(string first, string last)
        {
            nameOfStaff = first + " " + last;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("-----------------------");
        }


        //known as a property. Kind of like member functions in C++. They are named using the same format as classes
        public int HoursWorked
        {
            get //accessor
            {
                return hWorked;
            }
            set //setter
            {
                if (value > 0) //refers to the value right side of the assignment statement when users use this property
                    hWorked = value;
                else
                    hWorked = 0;
            }

        }

        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay...");
        }

        public int CalculatePay()
        {
            PrintMessage();

            int staffPay;
            staffPay = hWorked * hourlyRate;

            if (hWorked > 0)
                return staffPay;
            else
                return 0;
        }

        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();

            if (hWorked > 0)
            {
                return hWorked * hourlyRate + bonus + allowance;
            }
            else
                return 0;
        }

        public override string ToString()
        {
            return "Name of Staff = " + nameOfStaff + ", hourlyRate = " + hourlyRate + ", hWorked = " + hWorked;
            //  return base ToString(); This is what it had originally. Need to make sure what it means exactly
        }


    }


    /*
    Next step is Instantiating an Object: basically ways to make use of the class to create objects 
    */

    static class MyStaticClass
    {
        //making and playing with lists and arrays
        public static void PrintFirstElement(int[] a)
        {
            Console.WriteLine("First element: {0} \n", a[0]);
        }

        public static void PrintArray(int[] a)
        {
            for(int i = 0; i < a.Length; ++i)
            {
                Console.WriteLine("{0} ", a[i]);
            }
        }

        public static int[] ReturnUserInput()
        {
            int[] a = new int[3];
            for(int i=0; i < a.Length; ++i)
            {
                Console.Write("Enter an integer: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Integer added to array.\n");
            }
            return a;
        }

        public static void PrintFirstListElement(List<int> a)
        {
            Console.WriteLine("First element of list: {0}", a[0]);
        }

        public static List<int> ReturnUserInputList()
        {
            List<int> a = new List<int>();
            int input;

            for(int i = 0; i < 4; ++i)
            {
                Console.Write("Enter an integer: ");
                input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Integer has been added to list.\n");
                a.Add(input);
            }
            return a;
        }
    }



    class Program
    {
        static void Main(string[] args) //this is static so that we do not have to make an object 
                                        //Program every time we want to want to use any of the member fields, properties or methods
        {
            int pay;
            Staff staff1 = new Staff("Peter");
            staff1.HoursWorked = 160;
            pay = staff1.CalculatePay(1000, 400);
            Console.WriteLine("Pay {0}", pay);

            Staff staff2 = new Staff("Jane", "Lee");
            staff2.HoursWorked = 160;
            pay = staff2.CalculatePay();
            Console.WriteLine("Pay {0}", pay);

            Staff staff3 = new Staff("Carol");
            staff3.HoursWorked = -10;
            pay = staff3.CalculatePay();
            Console.WriteLine("Pay = {0}", pay);

            Console.WriteLine("\n");

            int[] myArray = { 1, 2, 3, 4, 5 };
            MyStaticClass.PrintFirstElement(myArray);
            MyStaticClass.PrintArray(myArray);
           
            int[] myArray2 = MyStaticClass.ReturnUserInput ();
            MyStaticClass.PrintArray(myArray2);

            List<int> myList = new List<int> { 2, 4, 6, 8 };
            MyStaticClass.PrintFirstListElement(myList);
            List<int> myList2 = MyStaticClass.ReturnUserInputList();
            foreach(int i in myList2)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.Read();
        }
    }


}

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



    class Program
    {
        static void Main(string[] args)
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

            Console.Read();
        }
    }


}

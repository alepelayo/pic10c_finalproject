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
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World. What is your name: ");
            //string input = Console.ReadLine();
            //string [] split = input.Split(' ');
            
            Console.Read();
        }
    }

   
}

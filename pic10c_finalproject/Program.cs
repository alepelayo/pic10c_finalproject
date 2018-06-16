using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pic10c_finalproject
{

    class Card
    {

        private string suit;
        private string rank;

        //main constructor
        public Card()
        {

        Random rnd = new Random();
            int s = rnd.Next(1, 5); //creates a random number between 1 and 4
            int r = rnd.Next(1, 11); //creates a random number between 1 and 10
            
            switch(s)
            {
                case 1: suit = "OROS"; break;
                case 2: suit = "COPAS"; break;
                case 3: suit = "ESPADA"; break;
                case 4: suit = "BATOS"; break;
                default: break;
            }

            switch(r)
            {
                case 1: rank = "AS"; break;
                case 2: rank = "DOS"; break;
                case 3: rank = "TRES"; break;
                case 4: rank = "CUATRO"; break;
                case 5: rank = "CINCO"; break;
                case 6: rank = "SEIS"; break;
                case 7: rank = "SIETE"; break;
                case 8: rank = "SOTA"; break;
                case 9: rank = "CABALLO"; break;
                case 10: rank = "REY"; break;
                default: break;
            }
        }

    }



    class Program
    {
        static void Main(string[] args) //this is static so that we do not have to make an object 
                                        //Program every time we want to want to use any of the member fields, properties or methods
        {

            Console.Read();
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pic10c_finalproject;

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

            switch (s)
            {
                case 1: suit = "Oros"; break;
                case 2: suit = "Copas"; break;
                case 3: suit = "Espadas"; break;
                case 4: suit = "Batos"; break;
                default: break;
            }

            switch (r)
            {
                case 1: rank = "As"; break;
                case 2: rank = "Dos"; break;
                case 3: rank = "Tres"; break;
                case 4: rank = "Cuatro"; break;
                case 5: rank = "Cinco"; break;
                case 6: rank = "Seis"; break;
                case 7: rank = "Siete"; break;
                case 8: rank = "Sota"; break;
                case 9: rank = "Caballo"; break;
                case 10: rank = "Rey"; break;
                default: break;
            }
        }

        //spanish suit and rank methods
        public string get_spanish_suit()
        {
            return suit;
        }

        public string get_spanish_rank()
        {
            return rank;
        }

        //attempting to get rank as an int
        public int get_rank()
        {
            switch (rank)
            {
                case "As": return 1;
                case "Dos": return 2;
                case "Tres": return 3;
                case "Cuatro": return 4;
                case "Cinco": return 5;
                case "Seis": return 6;
                case "Siete": return 7;
                case "Sota": return 10;
                case "Caballo": return 11;
                case "Rey": return 12;
                default: return 0;
            }
        }
    }





    class Program
    {
        static void Main(string[] args) //this is static so that we do not have to make an object 
                                        //Program every time we want to want to use any of the member fields, properties or methods
        {
            Card myCard = new Card();
            Card myCard2 = new Card();
            Console.WriteLine(myCard.get_spanish_rank() + " de " + myCard.get_spanish_suit());
            Console.WriteLine(myCard2.get_spanish_rank() + " de " + myCard2.get_spanish_suit());
            Console.Read();
        }
    }
}


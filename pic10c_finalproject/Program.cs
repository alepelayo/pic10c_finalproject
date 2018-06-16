using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pic10c_finalproject
{

    public enum suit_t {OROS, COPAS, ESPADAS, BATOS};
    public enum rank_t {AS, DOS, TRES, CUATRO, CINCO, SEIS, SIETE, SOTA, CABALLO, REY};

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
                case 1: suit = "oros"; break;
                case 2: suit = "Copas"; break;
                case 3: suit = "Espadas"; break;
                case 4: suit = "Batos"; break;
                default: break;
            }

            switch(r)
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

        public string get_spanish_suit
        {
            
            get
            {
                return suit;
            }

        }

        public string get_spanish_rank
        {
            get
            {
                return rank;
            }
        }

       

    }
}





    class Program
    {
        static void Main(string[] args) //this is static so that we do not have to make an object 
                                        //Program every time we want to want to use any of the member fields, properties or methods
        {
            Card myCard = new Card();
            myCard.get_spanish_rank();
            Console.Read();
        }
    }


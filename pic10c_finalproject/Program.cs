using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pic10c_finalproject;

namespace pic10c_finalproject
{

    //public static class StaticRandom
    //{
    //    private static int seed;

    //    private static ThreadLocal<Random> threadLocal = new ThreadLocal<Random>
    //        (() => new Random(Interlocked.Increment(ref seed)));

    //    static StaticRandom()
    //    {
    //        seed = Environment.TickCount;
    //    }

    //    public static Random Instance { get { return threadLocal.Value; } }
    //}

//--------------------------------------------------------------------------------------
    class Deck
    {
        private List<Card> deck;


        public void make_deck()
        {
            for(int i=0; i < 4; ++i)
            {
                for(int j = 0; j < 10; ++i)
                {
                    Card newcard = new Card(i, j);
                }
            }
        }

        public void shuffle()
        {

            Random rnd = new Random();
            Card carta = new Card(1, 1);
            List<Card> empty = new List<Card>();
            while (empty.Count != 40)
            {
                if (!(empty.Contains(carta)))
                {
                    empty.Add(carta);
                    Console.WriteLine("Added a new card: {0}", carta);
                }
                else
                {
                    Console.WriteLine("Card has already been added.");
                }
            }

        }

    }
//--------------------------------------------------------------------------------------

    class Card
    {

        private string suit;
        private string rank;



        //main constructor
        public Card(int r, int s)
        {


            // int s = rnd.Next(1, 5); //creates a random number between 1 and 4
            // int r = rnd.Next(1, 11); //creates a random number between 1 and 10

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

            Console.WriteLine(rank + " de " + suit);
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

        public float get_points()
        {
            switch(rank)
            {
                case "As": return 1;
                case "Dos": return 2;
                case "Tres": return 3;
                case "Cuatro": return 4;
                case "Cinco": return 5;
                case "Seis": return 6;
                case "Siete": return 7;
                case "Sota": return (0.5F);
                case "Caballo": return (0.5F);
                case "Rey": return (0.5F);
                default: return 0;
            }

        }

        ////overloading the < operator
        //public static bool operator < (Card card2) {
        //    int x = Int32.Parse(rank);

        //    return rank < card2.get_rank();
                                                             }
    }





    class Program
    {
    static void Main(string[] args) //this is static so that we do not have to make an object 
                                    //Program every time we want to want to use any of the member fields, properties or methods
    {

        //string decision;
        int s, r;

        Random rnd = new Random();

        r = rnd.Next(1, 11);
        s = rnd.Next(1, 5);
        Card myCard = new Card(r, s);
        Console.WriteLine(myCard);
        Console.WriteLine("You currently have " + myCard.get_points() + " points.");
        Console.Write("Would you like another card? (y/n) ");
        char decision = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if(decision == 'y') {
            Console.WriteLine("you have said yee");
        }

        else if(decision == 'n')
        {
            Console.WriteLine("you said nay");
        }

        else
        {
            Console.WriteLine("Please input a valid answer.");
        }
        Console.Read();
        }
    }





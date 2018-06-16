using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pic10c_finalproject;

namespace pic10c_finalproject
{



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
    }
}





    class Program
    {
    static void Main(string[] args) //this is static so that we do not have to make an object 
                                    //Program every time we want to want to use any of the member fields, properties or methods
    {
        int s, r;
        Random rnd = new Random();
        char decision = 'y'; //starting with y in order to enter the loop
        float player_points = 0, dealer_points = 0;
        int player_money = 100, dealer_money = 900;
        char difficulty; //allows user to choose their difficulty during the beginning of the game
        int bet;


        Console.WriteLine("Welcome to Siete y Medio! Select 'e' for easy or 'd' for difficult");
        difficulty = Console.ReadKey().KeyChar; //reading their decision
        Console.WriteLine();

        Console.Write("How much would like to bet? $");
        bet = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        while (decision == 'y')
        {
            r = rnd.Next(1, 11); //generating random rank number
            s = rnd.Next(1, 5); //generating random suit number
            Card myCard = new Card(r, s); //making a card
            player_points += myCard.get_points();
            Console.WriteLine("You currently have " + player_points + " points."); //displaying point total
            Console.WriteLine();
            if (player_points > 7.5)
            {
                Console.WriteLine("You have busted! You can no longer get new cards. ");
                decision = 'n';
            }
            else
            {
                Console.Write("Would you like another card? (y/n) "); //asking if they wish to get another card
                decision = Console.ReadKey().KeyChar; //reading their decision
            }

            Console.WriteLine();

        }

        if (difficulty == 'e')
        {
            while (dealer_points < 4)
            {
                r = rnd.Next(1, 11); //generating random rank number
                s = rnd.Next(1, 5); //generating random suit number
                Card myCard = new Card(r, s); //making a card
                dealer_points += myCard.get_points();
                Console.WriteLine("Dealer currently has " + dealer_points + " points."); //displaying point total
                Console.WriteLine();
            }
        }

        if (difficulty == 'd')
        {
            while (dealer_points < 6)
            {
                r = rnd.Next(1, 11); //generating random rank number
                s = rnd.Next(1, 5); //generating random suit number
                Card myCard = new Card(r, s); //making a card
                dealer_points += myCard.get_points();
                Console.WriteLine("Dealer currently has " + dealer_points + " points."); //displaying point total
                Console.WriteLine();
            }
        }

        //reading the points now
        if ((player_points > dealer_points && player_points <= 7.5) || (dealer_points > 7.5 && player_points <= 7.5))
        {
            //dealer loses money and player wins money
            Console.WriteLine("You have won money!");
            player_money += bet;

            Console.WriteLine(player_money + "\n");
            Console.WriteLine(dealer_money + "\n");
        }
        else if ((dealer_points > player_points && dealer_points <= 7.5) || (dealer_points <= 7.5 && player_points > 7.5))
        {
            //dealer wins money and player loses money
            Console.WriteLine("You have lost money! But dealer won some!");
            player_money -= bet;
            dealer_money += bet;

            Console.WriteLine(player_money + "\n");
            Console.WriteLine(dealer_money + "\n");

        }
        else if (dealer_points > 7.5 && player_points > 7.5)
        {
            //both lose money (house advantage)
            Console.WriteLine("You both lost money!");
            player_money -= bet;
            dealer_money -= bet;

            Console.WriteLine(player_money + "\n");
            Console.WriteLine(dealer_money + "\n");

        }
        else if (dealer_points == player_points)
        {
            //there is a tie. Nobody wins
            Console.WriteLine("Tie! Nobody gets money!");

            Console.WriteLine(player_money + "\n");
            Console.WriteLine(dealer_money + "\n");

        }

        Console.Read();
        }
    }





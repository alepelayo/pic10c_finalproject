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
        public Card(int r, int s)
        {

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
        public string get_spanish_suit { get { return suit; } }

        public string get_spanish_rank { get { return rank; } }

        //gets rank as an int
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
        int player_money = 100, dealer_money = 900; //initializing the amount of money each player has
        char difficulty; //allows user to choose their difficulty during the beginning of the game
        int bet;

        Console.WriteLine("Welcome to Siete y Medio! Select 'e' for easy or 'd' for difficult");
        difficulty = Console.ReadKey().KeyChar; //reading their decision
        Console.WriteLine();

        while (dealer_money != 0 || player_money != 0) //more rounds will be played while the dealer nor the player have run out of money
        {
            decision = 'y'; //set the decision to yes in order to enter the while loop
            player_points = 0; //initilizing points in the start of every round
            dealer_points = 0;
            Console.Write("How much would like to bet? $");
            bet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (decision == 'y')
            {
                r = rnd.Next(1, 11); //generating random rank number
                s = rnd.Next(1, 5); //generating random suit number
                Card myCard = new Card(r, s); //making a card
                player_points += myCard.get_points(); //updating player's points
                Console.WriteLine("You currently have " + player_points + " points."); //displaying point total
                Console.WriteLine();
                if (player_points > 7.5) //the game will automatically stop giving cards once user busts.
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

            //dealer's turn to play
            if (difficulty == 'e') //if user chose easy
            {
                while (dealer_points < 4) //dealer will continue to get cards until their point count reaches 4 or more
                {
                    r = rnd.Next(1, 11); //generating random rank number
                    s = rnd.Next(1, 5); //generating random suit number
                    Card myCard = new Card(r, s); //making a card
                    dealer_points += myCard.get_points(); //updating dealer's points
                    Console.WriteLine("Dealer currently has " + dealer_points + " points."); //displaying point total
                    Console.WriteLine();
                }
            }

            if (difficulty == 'd') //if user chose difficult
            {
                while (dealer_points < 6) //dealer will continue to get cards until their point count reaches 6 or more
                {
                    r = rnd.Next(1, 11); //generating random rank number
                    s = rnd.Next(1, 5); //generating random suit number
                    Card myCard = new Card(r, s); //making a card
                    dealer_points += myCard.get_points(); //updating dealer's points
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
            
            }
            else if (dealer_points > 7.5 && player_points > 7.5)
            {
                //both lose money (house advantage)
                Console.WriteLine("You both lost money!");
                player_money -= bet;
                dealer_money -= bet;

            }
            else if (dealer_points == player_points)
            {
                //there is a tie. Nobody wins
                Console.WriteLine("Tie! Nobody gets money!");

            }

            //Ending the game:
            if (dealer_money == 0)
            {
                Console.WriteLine("Dealer has run out of money! You have won!");
                break;
            }

            else if (player_money == 0)
            {
                Console.WriteLine("You have lost all your money! Come back when you have more money.");
                break;
            }
        }

        Console.Read();
        }
    }
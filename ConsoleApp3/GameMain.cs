using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class GameMain
    {


        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Console.WriteLine("Your name: ");
            Player player1 = new Player(Console.ReadLine(), deck);
            Player player2 = new Player("Player 2", deck);
            Player player3 = new Player("Player 3", deck);
            List<Player> players = new List<Player>();
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            while (deck.drawIndex > 3)
            {
                playRound(player1, player2, player3, deck, players);
            }
            checkWinner(player1, player2, player3 );
            Console.ReadLine();                     
        }



        static void checkWinner(Player player1, Player player2, Player player3)
        {
            Player winner;

            if (player1.score > player2.score && player1.score > player3.score)
            {
                winner = player1;
            }
            else if (player2.score > player1.score && player2.score > player3.score)
            {
                winner = player2;
            }
            else
            {
                winner = player3; 
            }
            Console.WriteLine("Winner is....  " + winner.name + "!!!");         
        }

        static void playRound(Player player1, Player player2, Player player3, Deck deck, List<Player>players)
        {
            Card winner;
            Console.WriteLine("Press Enter to play the round");
            Console.ReadLine();
            Console.WriteLine($"Remaining Cards on the deck: {deck.drawIndex}");
            Console.WriteLine("-----------------------------------------------");
            player1.setHand();
            player2.setHand();
            player3.setHand();
            winner = winnerCard(player1.stronguestCard, player2.stronguestCard, player3.stronguestCard, player1, player2, player3);
            Console.WriteLine("Winner Card:");
            winner.prettyPrint();
            Console.WriteLine("-------------------");
            Console.WriteLine("Scoreboard: \n");
            foreach (Player player in players)
            {
                Console.WriteLine($"{player.name} score =  {player.score}");
            }
            Console.WriteLine("------------------------------------------------");           
            Console.ReadLine();                 
        }



        static Card winnerCard(Card card1, Card card2, Card card3, Player player1, Player player2, Player player3)
        {
            Card winnercard;

            if (card1.numberValue > card2.numberValue && card1.numberValue > card3.numberValue)
            {
                winnercard = card1;
                player1.score++;
            }

            else if (card2.numberValue > card1.numberValue && card2.numberValue > card3.numberValue)
            {
                winnercard = card2;
                player2.score++;
            }

            else if (card3.numberValue > card2.numberValue && card3.numberValue > card1.numberValue)
            {
                winnercard = card3;
                player3.score++;
            }

            else
            {
                if (card1.suitValue > card2.suitValue && card1.suitValue > card3.suitValue)
                {
                    winnercard = card1;
                    player1.score++;
                }
                else if (card2.suitValue > card3.suitValue && card2.suitValue > card1.suitValue)
                {
                    winnercard = card2;
                    player2.score++;
                }
                else
                {
                    winnercard = card3;
                    player3.score++;
                }
            }
            return winnercard;
            
        }
    }
}

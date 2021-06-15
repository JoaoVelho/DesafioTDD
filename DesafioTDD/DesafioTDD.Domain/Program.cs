using System;
using DesafioTDD.Domain.Entities;
using DesafioTDD.Domain.Enums;
using DesafioTDD.Domain.Utils;

namespace DesafioTDD.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            EHands move1, move2;
            
            do {
                move1 = UserEntry.GetMove(1);
            } while (move1 == 0);

            do {
                move2 = UserEntry.GetMove(2);
            } while (move2 == 0);

            Player player1 = new Player(move1);
            Player player2 = new Player(move2);

            Judge judge = new Judge(player1, player2);

            Player winner = judge.DefineWinner();

            if (winner != null)
                Console.WriteLine(winner.Move + " ganhou!");
            else
                Console.WriteLine("Empate!");
        }
    }
}

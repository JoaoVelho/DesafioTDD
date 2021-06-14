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
            EHands play1 = UserEntry.Validate(1);
            EHands play2 = UserEntry.Validate(2);

            Player player1 = new Player(play1);
            Player player2 = new Player(play2);

            Judge judge = new Judge(player1, player2);

            Player winner = judge.DefineWinner();

            if (winner != null)
                Console.WriteLine(winner.Move);
            else
                Console.WriteLine("Empate");
        }
    }
}

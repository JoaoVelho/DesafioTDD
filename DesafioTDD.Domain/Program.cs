using System;
using DesafioTDD.Domain.Entities;
using DesafioTDD.Domain.Enums;

namespace DesafioTDD.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            EHands play1 = new EHands();
            EHands play2 = new EHands();

            bool invalid = true;
            do {
                Console.WriteLine("Player 1 escolha sua jogada: 1 - Pedra; 2 - Papel; 3 - Tesoura");
                if (Enum.TryParse(Console.ReadLine(), out EHands play) && Player.Validate(play)) {
                    play1 = play;
                    invalid = false;
                } else {
                    Console.WriteLine("Jogada inválida!");
                }
            } while(invalid);

            invalid = true;
            do {
                Console.WriteLine("Player 2 escolha sua jogada: 1 - Pedra; 2 - Papel; 3 - Tesoura");
                if (Enum.TryParse(Console.ReadLine(), out EHands play) && Player.Validate(play)) {
                    play2 = play;
                    invalid = false;
                } else {
                    Console.WriteLine("Jogada inválida!");
                }
            } while(invalid);

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

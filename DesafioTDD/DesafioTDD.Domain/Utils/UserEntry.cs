using System;
using DesafioTDD.Domain.Entities;
using DesafioTDD.Domain.Enums;

namespace DesafioTDD.Domain.Utils
{
    public static class UserEntry
    {
        public static EHands GetMove(int playerNumber) {
            Console.WriteLine($"Player {playerNumber} escolha sua jogada: 1 - Pedra; 2 - Papel; 3 - Tesoura");
            if (Enum.TryParse(Console.ReadLine(), out EHands move) && Player.Validate(move)) {
                return move;
            } else {
                Console.WriteLine("Jogada inválida!");
                return 0;
            }
        }
    }
}
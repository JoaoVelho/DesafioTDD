using System;
using DesafioTDD.Domain.Entities;
using DesafioTDD.Domain.Enums;

namespace DesafioTDD.Domain.Utils
{
    public static class UserEntry
    {
        public static EHands Validate(int playerNumber) {
            do {
                Console.WriteLine($"Player {playerNumber} escolha sua jogada: 1 - Pedra; 2 - Papel; 3 - Tesoura");
                if (Enum.TryParse(Console.ReadLine(), out EHands play) && Player.Validate(play)) {
                    return play;
                } else {
                    Console.WriteLine("Jogada inválida!");
                }
            } while(true);
        }
    }
}
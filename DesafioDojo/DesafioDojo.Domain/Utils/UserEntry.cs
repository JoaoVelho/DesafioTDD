using System;

namespace DesafioDojo.Domain.Utils
{
    public static class UserEntry
    {
        public static int GetNumber() {
            Console.WriteLine("Digite a quantidade de lâmpadas:");
            if (Int32.TryParse(Console.ReadLine(), out int numberLights) && numberLights > 0) {
                return numberLights;
            } else {
                Console.WriteLine("Entrada inválida!");
                return 0;
            }
        }
    }
}
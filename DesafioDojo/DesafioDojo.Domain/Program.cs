using System;
using System.Collections.Generic;
using DesafioDojo.Domain.Entities;

namespace DesafioDojo.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de lâmpadas:");
            Int32.TryParse(Console.ReadLine(), out int numberLights);

            var lights = new List<Light>();
            for (int i = 0; i < numberLights; i++) {
                var light = new Light();
                lights.Add(light);
            }

            Walk.SwitchLights(lights);

            string outString = "";
            foreach (var light in lights) {
                outString += light.ToString() + " ";
            }

            Console.WriteLine(outString);
        }
    }
}

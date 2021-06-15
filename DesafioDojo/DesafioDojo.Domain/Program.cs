using System;
using System.Collections.Generic;
using DesafioDojo.Domain.Entities;
using DesafioDojo.Domain.Utils;

namespace DesafioDojo.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLights = 0;

            while (numberLights == 0) {
                numberLights = UserEntry.GetNumber();
            }

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

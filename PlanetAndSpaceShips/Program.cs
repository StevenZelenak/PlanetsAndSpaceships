using System;
using System.Collections.Generic;

namespace PlanetAndSpaceShips
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            var rockyPlanets = new List<string>();
            

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            var lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(lastTwoPlanets);

            planetList.Insert(0, "Earth");
            planetList.Insert(0, "Venus");

            planetList.Add("Pluto");

            rockyPlanets.AddRange(planetList.GetRange(0, 3));

            planetList.Remove("Pluto");

            foreach (var planet in rockyPlanets)
            {
                Console.WriteLine(planet);
            }

            var spaceship = new Dictionary<string, List<string>>();

            var planetsGloopVisited = new List<string>() { "Mercury", "Mars", "Uranus", "Neptune" };
            var planetsVikingVisited = new List<string>() { "Mercury", "Mars" };
            var planetsOpplaVisited = new List<string>() { "Venus", "Earth" };
            var planetsFiinVisited = new List<string>() { "Mercury", "jupiter", "Saturn" };
            var planetsMarcelineVisited = new List<string>() { "Earth", "Uranus", "Neptune" };



            spaceship.Add("Viking", planetsVikingVisited);
            spaceship.Add("Gloop", planetsGloopVisited);
            spaceship.Add("Oppla", planetsOpplaVisited);
            spaceship.Add("Fiin", planetsFiinVisited);
            spaceship.Add("Marceline", planetsMarcelineVisited);

            foreach (var planet in planetList)
            {
                Console.Write($"\n{planet}: ");
                foreach (var ship in spaceship)
                {
                    if(ship.Value.Contains(planet))
                    {
                        Console.Write($"{ship.Key} ");
                    }
                }

            }
 

        }
    }
}

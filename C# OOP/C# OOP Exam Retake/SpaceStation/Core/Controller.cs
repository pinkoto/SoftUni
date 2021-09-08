using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories;
using SpaceStation.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        private AstronautRepository astronauts;
        private PlanetRepository planets;
        private IMission mission;
        private int explored = 0;

        public Controller()
        {
            astronauts = new AstronautRepository();
            planets = new PlanetRepository();
            mission = new Mission();
        }

        public string AddAstronaut(string type, string astronautName)
        {
            IAstronaut astronaut;
            if (type == nameof(Biologist))
            {
                astronaut = new Biologist(astronautName);
            }
            else if (type == nameof(Geodesist))
            {
                astronaut = new Geodesist(astronautName);
            }
            else if (type == nameof(Meteorologist))
            {
                astronaut = new Meteorologist(astronautName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautType);
            }
            astronauts.Add(astronaut);
            return string.Format(OutputMessages.AstronautAdded, astronaut.GetType().Name, astronaut.Name);

        }

        public string AddPlanet(string planetName, params string[] items)
        {
            IPlanet planet = new Planet(planetName);
            for (int i = 0; i < items.Length; i++)
            {
                planet.Items.Add(items[i]);
            }
            planets.Add(planet);
            return string.Format(OutputMessages.PlanetAdded, planetName);
        }

        public string ExplorePlanet(string planetName)
        {
            List<IAstronaut> viableAstronauts = astronauts.Models.Where(a => a.Oxygen > 60.00).ToList();
            if (viableAstronauts == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautCount);
            }
            mission.Explore(planets.FindByName(planetName), viableAstronauts);
            int dead = viableAstronauts.Where(a => a.CanBreath == false).Count();
            explored++;
            return string.Format(OutputMessages.PlanetExplored, planetName, dead);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{explored} planets were explored!" + Environment.NewLine);
            sb.Append("Astronauts info:");

            foreach (IAstronaut astronaut in astronauts.Models)
            {
                sb.Append(Environment.NewLine + $"Name: { astronaut.Name}" + Environment.NewLine) ;
                sb.Append($"Oxygen: { astronaut.Oxygen}" + Environment.NewLine);
                sb.Append(astronaut.Bag.Items.Count > 0
                    ? $"Bag items: {string.Join(", ", astronaut.Bag.Items)}"
                    : "Bag items: none");
            }
            return sb.ToString().TrimEnd();
        }

        public string RetireAstronaut(string astronautName)
        {
            IAstronaut astronaut = astronauts.FindByName(astronautName);
            if (astronaut is null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidRetiredAstronaut, astronautName));
            }
            astronauts.Remove(astronaut);
            return string.Format(OutputMessages.AstronautRetired, astronautName);
        }
    }
}

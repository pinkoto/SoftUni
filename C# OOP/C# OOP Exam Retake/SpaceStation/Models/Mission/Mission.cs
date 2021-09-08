using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            Queue<string> items = new Queue<string>(planet.Items);
            foreach (IAstronaut astronaut in astronauts)
            {
                while (astronaut.Oxygen>0&&planet.Items.Count>0)
                {   
                    astronaut.Breath();
                    string item = items.Dequeue();
                    astronaut.Bag.Items.Add(item);
                    planet.Items.Remove(item);
                }
            }
        }
    }
}

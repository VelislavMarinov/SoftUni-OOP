using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Planets;
using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SpaceStation.Models.Mission;
using SpaceStation.Repositories;
using SpaceStation.Utilities.Messages;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        private AstronautRepository astronauts;
        private PlanetRepository planets;
        private Mission mission;
        private int exploredplanets = 0;
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

            this.astronauts.Add(astronaut);

            string result = string.Format(
                OutputMessages.AstronautAdded, type, astronautName);

            return result;
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            var planet = new Planet(planetName);
            foreach (var item in items)
            {
                planet.Items.Add(item);
            }
            planets.Add(planet);
            return $"Successfully added Planet: {planetName}!";
        }

        public string ExplorePlanet(string planetName)
        {

            var castronauts = this.astronauts
                 .Models
                 .Where(x => x.Oxygen > 60)
                 .ToList();

            if (!castronauts.Any())
            {
                throw new InvalidOperationException(
                    ExceptionMessages.InvalidAstronautCount);
            }

            exploredplanets++;

            var planet = this.planets
                .FindByName(planetName);

            this.mission.Explore(planet, castronauts);

            int deadAstronauts = castronauts.Count(x => !x.CanBreath);

            string result = string.Format(OutputMessages.PlanetExplored,
                planetName,
                deadAstronauts);

            return result;

        }

        public string Report()
        {
            /*Astronauts info:
            Name: {astronautName}
            Oxygen: {astronautOxygen}
            Bag items: {bagItem1, bagItem2, …, bagItemn} / none
             */

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{exploredplanets} planets were explored!");
            sb.AppendLine($"Astronauts info:");
            foreach (var astronaut in astronauts.Models)
            {
                sb.AppendLine(astronaut.ToString());
                
            }
            return sb.ToString().TrimEnd();
        }

        public string RetireAstronaut(string astronautName)
        {
            var astronaut = astronauts.Models.FirstOrDefault(x => x.Name == astronautName);
            if(astronaut == null)
            {
                throw new InvalidOperationException($"Astronaut {astronautName} doesn't exists!");
            }
            astronauts.Remove(astronaut);
            return $"Astronaut {astronautName} was retired!";
        }
    }
}

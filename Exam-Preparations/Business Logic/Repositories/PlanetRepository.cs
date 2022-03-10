using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpaceStation.Repositories
{
    public class PlanetRepository : IRepository<IPlanet>
    {
        public PlanetRepository()
        {
            models = new List<IPlanet>();
        }
        private List<IPlanet> models;
        public IReadOnlyCollection<IPlanet> Models => this.models;

        public void Add(IPlanet model)
        {
            this.models.Add(model);
        }

        public IPlanet FindByName(string name)
        {
            var planet = Models.FirstOrDefault(x => x.Name == name);
           
            return planet;
        }

        public bool Remove(IPlanet model)
        {
            return this.models.Remove(model);
        }
    }
}

using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpaceStation.Repositories
{
    public class AstronautRepository : IRepository<IAstronaut>
    {
        public AstronautRepository()
        {
            models = new List<IAstronaut>();
        }
        private List<IAstronaut> models;
        public IReadOnlyCollection<IAstronaut> Models => this.models;


        public void Add(IAstronaut model)
        {
            models.Add(model);
        }

        public IAstronaut FindByName(string name)
        {
            var chek = models.FirstOrDefault(x => x.Name == name);
            return chek;
        }

        public bool Remove(IAstronaut model)
        {
            return models.Remove(model);
        }
    }
}

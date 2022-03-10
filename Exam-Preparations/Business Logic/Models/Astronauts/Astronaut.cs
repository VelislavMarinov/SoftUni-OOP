using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Bags;
using SpaceStation.Models.Bags.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Astronauts
{
    public abstract class Astronaut : IAstronaut
    {
        private string name;
        private double oxygen;
        

        public Astronaut(string name, double oxygen)
        {
            this.Name = name;
            this.Oxygen = oxygen;
            this.Bag = new Backpack();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"Astronaut name cannot be null or empty.");
                }
                name = value;
            }
        }

        public double Oxygen
        {
            get
            {
                return this.oxygen;
            }
            protected set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Astronaut name cannot be null or empty.");
                }
                oxygen = value;
            }
        }

        public bool CanBreath => Oxygen > 0;
        

        public IBag Bag { get; }
       

        public virtual void Breath()
        {
            if(oxygen - 10 < 0)
            {
                oxygen = 0;

            }
            else
            {
                oxygen -= 10;
            }
            
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Oxygen: {Oxygen}");
            if(Bag.Items.Count == 0)
            {
              sb.AppendLine($"Bag items: none");
            }
            else
            {
                sb.AppendLine($"Bag items: {string.Join(", ", Bag.Items)}");
            }

                

            return sb.ToString().TrimEnd();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdr2
{
    class Hero : Person, IheeftKrachten
    {
        /// <summary>
        /// Variabelen
        /// </summary>
        private Villain archnemesis;
        private List<string> krachten = new List<string>();
        private Person sidekick;

        public Hero(string name, Villain nemesis, Person sidekick, int evilness)
        {
            this.name = name;
            this.archnemesis = nemesis;
            this.sidekick = sidekick;
            if (evilness > 100)
            {
                this.evilness = 50;
            }
            else
                 this.evilness = evilness;
        }
        public string getName()
        {
            return this.name;
        }
        public int getEvilness()
        {
            return this.evilness;
        }
        public void updateSidekick(Person sidekick)
        {
            this.sidekick = sidekick;
        }

        public Person getSidekick()
        {
            return this.sidekick;
        }

        public Villain getArchnemesis()
        {
            return this.archnemesis;
        }

        public void addStrength(string kracht)
        {
            krachten.Add(kracht);
        }

        public List<string> getKrachten()
        {
            return this.krachten;
        }
    }
}

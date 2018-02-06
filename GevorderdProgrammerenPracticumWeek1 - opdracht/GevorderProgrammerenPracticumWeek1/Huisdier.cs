using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderProgrammerenPracticumWeek1
{ 
    class Huisdier
    {
        /// <summary>
        /// Variabelen
        /// </summary>
        private string naam;
        private string soort;
       
      
        /// <summary>
        /// Constructor voor class Huisdier.
        /// </summary>
        /// <param name="naam"></param>
        /// <param name="soort"></param>
        /// <param name="leeftijd"></param>
        public Huisdier(string naam, string soort)
        {
            this.naam = naam;
            this.soort = soort;
           
          
        }
        /// <summary>
        /// Opvragen van naam
        /// </summary>
        /// <returns>Naam van huisdier</returns>
        public string getNaam()
        {
            return this.naam;
        }

        public string getBeschrijving()
        {
            return $"Naam:{this.naam}, Soort:{this.soort}.";
        }

        public string getSoort()
        {
            return this.soort;
        }
    }
}


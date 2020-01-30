using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BathHouse
{
    class ProfessionalSwimmer : Swimmer
    {
        /// <summary>
        /// Constructor using name and suit constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="suit"></param>
        public ProfessionalSwimmer(string name, BathingSuit suit) : base(name, suit)
        {
            SetName(name);
            SetSuit(suit);
        }
    }
}

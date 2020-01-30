using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BathHouse
{
    class YoungSwimmer : Swimmer
    {
        /// <summary>
        /// Constructor only requiring name parameter
        /// </summary>
        /// <param name="name"></param>
        public YoungSwimmer(string name) : base(name)
        {
            SetName(name);
        }
        /// <summary>
        /// Constructor using name and suit parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="suit"></param>
        public YoungSwimmer(string name, BathingSuit suit) : base(name, suit)
        {
            SetName(name);
            SetSuit(suit);
        }
        /// <summary>
        /// If the young swimmer has swam, set status to tired.
        /// </summary>
        public void SetStamina()
        {
            tired = true;
        }
        /// <summary>
        /// If young swimmer isn't tired, swim.
        /// When the young swimmer has swam, set status to tired.
        /// </summary>
        /// <returns></returns>
        public override string Swim()
        {
            if(!tired)
            {
                SetStamina();
                return "Splish splash - it's so fun in the bath!";
            }
            return "I'm tired";
        }
        //If swimmer is tired.
        private bool tired;
    }
}

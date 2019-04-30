using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Player
    {
        // fields
        internal string name { get; set; }
        internal int wins { get; set; }

        // constructors
        public Player()
        {
            name = "Guest";
            wins = 0;
        }

        public Player(string _name)
        {
            name = _name;
            wins = 0;
        }

        // destructor
        ~Player()
        {
        }
    }
}

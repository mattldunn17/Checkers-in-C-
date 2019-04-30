using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    class Admin : Player
    {
        // fields
        private string adminKey = "checkers01";

        public Admin(string _name, string _key)
        {
            if (_key == adminKey)
            {
                name = _name;
                wins = 0;
            }
        }

        // destructor
        ~Admin()
        {
        }

        // methods
        // possible methods would give an admin player advantages of regular players. (e.g. more moves, more checks, larger move radius, etc.)
    }
}

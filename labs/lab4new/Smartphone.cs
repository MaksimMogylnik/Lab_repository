using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4new
{
    class Smartphone : ColoredPhone
    {
        public string Email { get; set; }

        public string OwnerName { get; set; }

        public string CanAccessInternet { get; set; }

        public Smartphone() : base()
        {
            WayToWrite = "Sensor buttons";
            Display = "Sensor glass";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4new
{
    class DiskPhone
    {
        public bool Portable { get; protected set; }
        public string WayToWrite { get; protected set; }
        public string PhoneNumber { get; set; }

        public DiskPhone()
        {
            Portable = false;
            WayToWrite = "Disk with numbers";
        }

        public virtual void Call(string callTo)
        {
            Console.WriteLine($"calling {callTo}");
            Console.Beep();
        }

        public virtual void RecieveCall(string callFrom)
        {
            Console.Beep();
            Console.WriteLine($"{callFrom} is calling!");
        }
    }
}

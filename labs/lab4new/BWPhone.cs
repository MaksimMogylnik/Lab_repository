using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4new
{
    class BWPhone : ButtonedPhone
    {

        public string Display { get; protected set; }

        public Dictionary<string, string> Contacts { get; set; } = new Dictionary<string, string>();

        public BWPhone()
        {
            Portable = true;
            WayToWrite = "Buttons";
            Display = "Black and white";
        }

        public virtual void SendSmsTo (string smsTo)
        {
            Console.WriteLine($"sending sms to {smsTo}");
            Console.Beep();
        }

        public virtual void RecieveSmsFrom(string smsFrom)
        {
            Console.Beep();
            Console.WriteLine($"recieved sms from {smsFrom}");
        }

        public virtual void PlayGames()
        {
            Console.WriteLine("Insert your cool game name here...");
        }
    }
}

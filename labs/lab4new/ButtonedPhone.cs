using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4new
{
    class ButtonedPhone : DiskPhone
    {
        public ButtonedPhone()
        {
            Portable = false;
            WayToWrite = "Buttons with numbers";
        }
    }
}

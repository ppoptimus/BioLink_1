using BioLink_1.Models;
using System.Collections.Generic;

namespace BioLink_1.Stuff
{
    public class DevicesStuff
    {
        public Devices GetDevices = new Devices();
        public DevicesStuff()
        {
            GetDevices.DevicesId = "1";
            GetDevices.DevicesName = "Name";
        }
    }
}

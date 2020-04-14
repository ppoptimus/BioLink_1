using BioLinkTaskSchedule.Models;
using System.Collections.Generic;

namespace BioLinkTaskSchedule.Stuff
{
    public class DevicesStuff
    {
        public DevicesStuff()
        {
        }
        public List<Devices> Devices = new List<Devices>
        {
            new Devices{DevicesId = "1", DevicesName = "test1"},
            new Devices{DevicesId = "2", DevicesName = "test2"},
            new Devices{DevicesId = "3", DevicesName = "test3"}
        };
    }
}

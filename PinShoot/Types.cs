using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinShoot
{
    public class Types
    {
        public enum SysTypes
        {
            Gender = 1,
            USPSAClass = 2,
            SCClass = 3,
            GunType = 4,
            TeamType = 5,
            EventType = 6
        }

        public enum EventListType
        {
            FivePin = 19,
            Team = 20,
            Other = 21
        }
    }
}

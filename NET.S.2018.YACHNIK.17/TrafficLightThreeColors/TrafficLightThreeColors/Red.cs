using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightThreeColors
{
    class Red : ITrafficLight
    {
        public bool status;
        public Red()
        {
            status = false;
        }
        public void On()
        {

        }
    }
}

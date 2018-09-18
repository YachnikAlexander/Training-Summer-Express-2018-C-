using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
    public class TrafficLight
    {
        public bool[] Colors { get; private set; }

        public  TrafficLight(bool[] colors)
        {
            if(colors == null)
            {
                throw new ArgumentNullException(nameof(colors));

                for(int i = 0; i < colors.Length; i++)
                {
                    Colors[i] = colors[i];
                }
            }
        }

        public void SetColor(int index, bool status)
        {
            Colors[index] = status;

        }
    }
}

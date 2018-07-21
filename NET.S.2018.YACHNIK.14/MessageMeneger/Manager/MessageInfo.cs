using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    /// <summary>
    /// class for additional information
    /// </summary>
    public class MessageInfo
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public int Time { get; set; }
    }
}

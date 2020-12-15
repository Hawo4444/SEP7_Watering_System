using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Utility
{
    public class EventClass : EventArgs
    {
        public String EventFired { get; private set; }
        public EventClass(String eventFired)
        {
            EventFired = eventFired;
        }
    }
}

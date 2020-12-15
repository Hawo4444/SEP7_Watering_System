using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Utility
{
    public class ViewEvent : EventArgs
    {
        public String _eventFired { get; private set; }

        public ViewEvent(String eventFired)
        {
            _eventFired = eventFired;
        }
    }
}

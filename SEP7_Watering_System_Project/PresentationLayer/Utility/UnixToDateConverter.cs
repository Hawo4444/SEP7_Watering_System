using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Utility
{
    public static class UnixToDateConverter
    {
        public static DateTime GetDate(int unixTime)
        {
            DateTime date = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            date = date.AddSeconds(unixTime).ToLocalTime();

            return date;
        }

        public static string GetDay(int unixTime)
        {
            string day = string.Format("{0}", GetDate(unixTime).DayOfWeek);

            return day;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RedDolphin.Module
{
    class Time
    {
        public List<TimeZoneInfo> thisTime;
        public List<DateTime> thisDate;

        IReadOnlyCollection<TimeZoneInfo> zones = TimeZoneInfo.GetSystemTimeZones();



    }
}

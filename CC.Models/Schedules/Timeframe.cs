using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.Models.Schedules;

internal class Timeframe(TimeOnly startTime, TimeSpan duration)
{
    public TimeOnly Start => startTime;

    public TimeOnly End => startTime + duration;

    public bool Intersects(Timeframe timeframe)
    {
        throw new NotImplementedException();
    }
}

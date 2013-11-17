using System.Collections.Generic;

namespace DVFS.Entities
{
    public class ScheduleRow
    {
        public string Processor { get; set; }

        public List<ScheduleColumn> Tasks { get; set; }
    }
}
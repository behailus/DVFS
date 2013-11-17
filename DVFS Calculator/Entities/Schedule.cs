using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVFS.Entities
{
    public class Schedule
    {
        public int ID { get; set; }

        public int IterationNumber { get; set; }

        public List<ScheduleRow> Processors { get; set; }
    }
}

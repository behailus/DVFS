using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVFS.Entities
{
    public class TaskLog
    {
        public int IterationNumber { get; set; }

        public string Processor { get; set; }//For ease of calculation

        public double TreshHoldVoltage { get; set; }//This doesn't change but for ease of calculation only

        public string Task { get; set; }

        public double ExtendedTime { get; set; }

        public double NewVoltage { get; set; }

        public double NewPower { get; set; }

        public double EnergyGradiant { get; set; }
    }
}

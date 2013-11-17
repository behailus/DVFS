using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVFS.Entities
{
    public class ProcessorTaskAttribute
    {
        public int ID { get; set; }
        public string Processor { get; set; }

        public string Task { get; set; }

        public double ExecutionTime { get; set; } //in ms

        public double DynamicPower { get; set; } //in Watts
    }
}

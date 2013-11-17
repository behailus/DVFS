using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVFS.Entities
{
    public class ProcessingElement
    {
        public int ID { get; set; }
        public string  Code { get; set; }
        public double OperatingVoltage { get; set; }
        public double TresholdVoltage { get; set; }


    }
}

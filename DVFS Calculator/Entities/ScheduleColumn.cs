namespace DVFS.Entities
{
    public class ScheduleColumn
    {
        public string Processor { get; set; }

        public string Task { get; set; }

        public double DynamicPower { get; set; }

        public double StartTime { get; set; }

        public double EndTime { get; set; }
    }
}
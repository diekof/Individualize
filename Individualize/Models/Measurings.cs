using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Measurings
    {
        public short Code { get; set; }
        public string Device { get; set; }
        public string Measurer { get; set; }
        public DateTime Date { get; set; }
        public short Medium { get; set; }
        public int Measuring { get; set; }
        public short MeasuringType { get; set; }
        public short BatteryLifetime { get; set; }
        public string Alarm { get; set; }
    }
}

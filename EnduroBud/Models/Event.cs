using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace EnduroBud.Models
{
    public class Event
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Distance { get; set; }
        public DateTime Date { get; set; }
    }
}

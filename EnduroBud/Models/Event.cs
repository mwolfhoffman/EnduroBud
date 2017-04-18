using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace EnduroBud.Models
{
    public class Event
    {
        public string Name;
        public string Type;
        public double Distance;

        public DateTime Date;

    /*    public DateTime ToDateTime(string Date)
        {
            DateTime dt = Convert.ToDateTime(Date);
            return dt;
        }
        */
    }
}

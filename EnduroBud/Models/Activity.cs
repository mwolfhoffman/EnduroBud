using System.Text.RegularExpressions;

namespace EnduroBud.Models
{
    public class Activity
    {
        public long Id { get; set; }

        public string Type { get; set; }
        public double Distance { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
    }
}
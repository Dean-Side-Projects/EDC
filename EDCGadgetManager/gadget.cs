using System;
using System.Collections.Generic;
namespace EDCGadgetManager
{
    public class Gadget
    {
        public string Name { get; set; }
        public HashSet<DayOfWeek> CarriedDays { get; set; }

        public Gadget(string name, IEnumerable<DayOfWeek> carriedDays)
        {
            Name = name;
            CarriedDays = new HashSet<DayOfWeek>(carriedDays);
        }

        public bool IsCarriedOn(DayOfWeek day) => CarriedDays.Contains(day);

        public override string ToString()
        {
            string days = CarriedDays.Count == 7
                ? "Everyday"
                : string.Join(", ", CarriedDays);
            return $"{Name} (Carried: {days})";
        }
    }
}


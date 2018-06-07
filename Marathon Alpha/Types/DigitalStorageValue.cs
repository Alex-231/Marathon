using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Marathon.Types
{
    public class DigitalStorageValue
    {
        public enum DigitalStorageUnit
        {
            MB,
            GB
        }

        public int value;
        public DigitalStorageUnit unit;

        public DigitalStorageValue(int value, DigitalStorageUnit unit)
        {
            this.value = value;
            this.unit = unit;
        }

        public static DigitalStorageValue Parse(string raw)
        {
            string unit = Regex.Replace(raw, @"[\d-]", string.Empty);
            string value = raw.Replace(unit, "");

            return Parse(value, unit);
        }

        public static DigitalStorageValue Parse(string value, string unit)
        {
            unit = unit.ToUpper();
            if (!Enum.TryParse(unit, out DigitalStorageUnit parsedUnit))
                throw new ArgumentException("Unit " + unit + " could not be parsed.");

            if (!int.TryParse(value, out int parsedValue))
                throw new ArgumentException("Value " + value + " could not be parsed.");

            return new DigitalStorageValue(parsedValue, parsedUnit);
        }

        public override string ToString()
        {
            return value.ToString() + unit.ToString().Replace("B", "");
        }

    }
}

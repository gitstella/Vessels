using System;
using System.Globalization;

namespace speedInterface
{
    public class Speed : IFormattable
    {
        private double MaxSpeed;

        public Speed (double speed)
        {
            this.MaxSpeed = speed;
        }

        public double MetersPerSecond
        {
            get { return MaxSpeed * 0.514444444; }
        }

        public override string ToString() 
        {
            return this.ToString("KS", CultureInfo.CurrentCulture);
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider provider)
        {
            
            switch (format.ToUpper())
            {   
                case "KS":
                    return MaxSpeed.ToString("F2", provider) +  "kt/s";
                case "MS":
                    return MetersPerSecond.ToString("F2", provider) + "m/s";
                default:
                    throw new FormatException($"The {format} specifier is not supported");
            
            }
        }
    }
}
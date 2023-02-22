using System;
using System.Reflection;
namespace TempConv
{
    public class TemperatureConversionComponent
    {
        public TemperatureConversionComponent()
        {
        }
        public double cToF(double c)
        {
            // how to control output format
            return (int)((c * 9 / 5.0 + 32) * 100) / 100.0;
        }
        public double fToC(double f)
        {
            // how to control output format
            return (int)((f - 32) * 5 / 9.0 * 100) / 100.0;
        }
    }
}
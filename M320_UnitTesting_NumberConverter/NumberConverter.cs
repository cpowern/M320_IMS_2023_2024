using System;

namespace NumberConverter
{
    public class NumberConverter
    {

        StringConverter _stringConverter;

        public NumberConverter(StringConverter stringConverter = null)
        {
            _stringConverter = stringConverter;
        }

        public int RoundUp(float value)
        {
            if (value < 0 || (int)value == value)
            {
                return (int)value;
            }

            return (int)value + 1;
        }

        public int RoundDown(float value)
        {
            return (int)value;
        }

        public int RoundToPowerOfTen(float value, int precisionExponent = 1)
        {
            int precision = (int)Math.Pow(10, precisionExponent);
            MidpointRounding mode = value >= 0 ? MidpointRounding.AwayFromZero : MidpointRounding.ToZero;
            return (int)Math.Round(value / precision, mode) * precision;

        }

        public int RoundToPowerOfTen(string numericString, int precisionExponent = 1)
        {
            // For demonstration purposes, let's assume that StringConverter is a non-testable class.
            // Non-testable in this context is clearly related to unit testing.
            // In real situations, such nun-testable aspects of an application might be
            // random outcomes, network communication or database and filesystem operations.
            StringConverter stringConverter = new StringConverter();

            return RoundToPowerOfTen(stringConverter.ConvertToInt(numericString), precisionExponent);
        }
    }
}

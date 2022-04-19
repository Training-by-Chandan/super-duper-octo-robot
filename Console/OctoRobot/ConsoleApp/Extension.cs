using System;

namespace Octo.Robot
{
    public static class StringExtensions
    {
        public static int ToInt32(this string s)
        {
            return Convert.ToInt32(s);
        }
    }

    public static class DoubleExtensions
    {
        public static string ToPercent(this double d, string sign)
        {
            return d.ToString("00.00") + " %";
        }
    }

    public static class TimeExtenstions
    {
        public static double Age(this DateTime dt)
        {
            var timespan = DateTime.Now - dt;
            return timespan.TotalDays / 365;
        }
    }
}
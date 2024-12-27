using Microsoft.Extensions.Internal;
using System.Text.RegularExpressions;

namespace SEA_ApiTest.Utils
{
    public static class TimeUtils
    {
        public const string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";

        public static string GetLocalTimeZone()
        {
            return GetTimeZone(DateTimeOffset.Now);
        }

        public static string GetTimeZone(DateTimeOffset time)
        {
            TimeSpan offset = time.Offset;
            string sign = offset < TimeSpan.Zero ? "-" : "+";
            string output = $@"{sign }{offset.TotalHours}";
            return output;
        }

        public static string GetSystemTimeZone()
        {
            return GetTimeZone(SystemDateTimeOffset());
        }

        public static DateTimeOffset SystemDateTimeOffset()
        {
            ConfigUtil config = ConfigUtil.Start();
            string offsetTime = config.Get("DateTime:OffSet");
            return DateTimeOffset.Now.ToOffset(new TimeSpan(int.Parse(offsetTime), 0, 0));
        }

        public static DateTime SystemDateTime() => SystemDateTimeOffset().DateTime;

        public static DateOnly SystemDateOnly() => DateOnly.FromDateTime(SystemDateTime());

        public static long Time() => DateTimeOffset.Now.ToUnixTimeSeconds();
    }
}
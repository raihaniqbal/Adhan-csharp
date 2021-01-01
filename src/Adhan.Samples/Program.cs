using Batoulapps.Adhan;
using Batoulapps.Adhan.Internal;
using System;
using TimeZoneConverter;

namespace Adhan.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinates coordinates = new Coordinates(-33.922016, 150.923903);
            DateComponents dateComponents = DateComponents.From(new DateTime(2021, 4, 4));
            CalculationParameters parameters = CalculationMethod.NORTH_AMERICA.GetParameters();

            string timeZone = "Australia/Sydney";

            TimeZoneInfo easternTime = TZConvert.GetTimeZoneInfo(timeZone);

            PrayerTimes prayerTimes = new PrayerTimes(coordinates, dateComponents, parameters);
            Console.WriteLine("Fajr   : " + TimeZoneInfo.ConvertTimeFromUtc(prayerTimes.Fajr, easternTime));
            Console.WriteLine("Sunrise: " + TimeZoneInfo.ConvertTimeFromUtc(prayerTimes.Sunrise, easternTime));
            Console.WriteLine("Dhuhr  : " + TimeZoneInfo.ConvertTimeFromUtc(prayerTimes.Dhuhr, easternTime));
            Console.WriteLine("Asr    : " + TimeZoneInfo.ConvertTimeFromUtc(prayerTimes.Asr, easternTime));
            Console.WriteLine("Maghrib: " + TimeZoneInfo.ConvertTimeFromUtc(prayerTimes.Maghrib, easternTime));
            Console.WriteLine("Isha   : " + TimeZoneInfo.ConvertTimeFromUtc(prayerTimes.Isha, easternTime));
        }
    }
}

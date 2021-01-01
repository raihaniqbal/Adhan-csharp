using Batoulapps.Adhan;
using Batoulapps.Adhan.Internal;
using System;
using TimeZoneConverter;
using Xamarin.Forms;

namespace Adhan.App.Sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Coordinates coordinates = new Coordinates(-33.922016, 150.923903);
            DateComponents dateComponents = DateComponents.From(new DateTime(2021, 4, 4));
            CalculationParameters parameters = CalculationMethod.NORTH_AMERICA.GetParameters();

            string timeZone = "Australia/Sydney";

            TimeZoneInfo easternTime = TZConvert.GetTimeZoneInfo(timeZone);

            PrayerTimes prayerTimes = new PrayerTimes(coordinates, dateComponents, parameters);
            lblTest.Text = "Fajr   : " + TimeZoneInfo.ConvertTimeFromUtc(prayerTimes.Fajr, easternTime);
        }
    }
}

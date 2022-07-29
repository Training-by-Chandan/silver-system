using System;

namespace Silver.ConsoleApp
{
    public class Enums
    {
        public string Day { get; set; }
        public string Gender { get; set; }

        public Days day { get; set; }

        public void Run()
        {
            Day = "Sonday";
            Gender = "Male      ";
            Gender = "Mail";
            // day = Days.Sunday;
            int d = 50;
            day = (Days)d;
            Console.WriteLine(day);
        }
    }

    public enum Days
    {
        [NepaliName("Aaitabar")]
        Sunday = 10,

        [NepaliName("Bihibar")]
        Thursday = 50,

        [NepaliName("Sombar")]
        Monday = 20,

        [NepaliName("Mangalbar")]
        Tuesday = 30,

        [NepaliName("Budhabar")]
        Wednesday = 40,

        [NepaliName("Sukrabar")]
        Friday = 60,

        [NepaliName("Sanibar")]
        Saturday = 70
    }

    public enum Gender
    {
        Male = 0x1a2b,
        Female = 0x2a2b,
        Other = 0x3a3f
    }
}

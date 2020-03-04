using System;

namespace Cousertime
{
    class Program
    {
        static void Main(string[] args)
        {
            /* DateTime d1 = new DateTime(2020, 3, 03, 13, 5, 58, DateTimeKind.Local);
             DateTime d2 = new DateTime(2020, 3, 03, 13, 5, 58, DateTimeKind.Utc);
             DateTime d3 = new DateTime(2020, 3, 03, 13, 5, 58);

             Console.WriteLine("d1: " + d1);
             Console.WriteLine("d1 Kind: " + d1.Kind);
             Console.WriteLine("d1 to local: " + d1.ToLocalTime());
             Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());*/

            DateTime d4 =  DateTime.Parse("2020-03-03 13:05:58");
            DateTime d5 = DateTime.Parse("2020-03-03T13:05:58Z");

            Console.WriteLine(d4);
            Console.WriteLine(d5);

            Console.ReadLine();


        }
    }
}

using System;


namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            Console.WriteLine($"{date,40:MMMM dd, yyyy}");
            Console.WriteLine($"{date:yyyy.MM.dd}");
            Console.WriteLine($"{date:Day dd of January, yyyy}");
            Console.WriteLine($"{date:Year: yyyy, Month: MM, Day: dd}");
            Console.WriteLine($"{date,10: dddd}");
            Console.WriteLine($"{date,10:t} {date,10:dddd}");
            Console.WriteLine($"h: {date:h,} m: {date:m,} s: {date:s}");
            Console.WriteLine($"{date:yyyy.MM.dd.h.m.s}");

            var pi = Math.PI;
            Console.WriteLine($"{pi:c}");


        }
    }
}

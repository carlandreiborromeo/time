using System;

class Program
{
    static void Main(string[] args)
    {
        const int SecondsInMinute = 60;
        const int MinutesInHour = 60;
        const int HoursInDay = 24;
        const int DaysInMonth = 30;

        int seconds = 86400;

        double minutes = seconds / (double)SecondsInMinute;
        double hours = minutes / MinutesInHour;
        double days = hours / HoursInDay;
        double months = DaysInMonth / days;

        Console.WriteLine($"{seconds} seconds is equal to:");
        Console.WriteLine($"{minutes} minutes");
        Console.WriteLine($"{hours} hours");
        Console.WriteLine($"{days} days");
        Console.WriteLine($"{months} months");
        Console.ReadLine();
    }
}

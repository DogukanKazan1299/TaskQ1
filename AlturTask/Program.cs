using AlturTask;
using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        // 10 ana sürücü- 2 yedek sürücü
        List<Driver> mainDrivers = new List<Driver>
        {
            new Driver(1,"Driver 1", true),
            new Driver(2,"Driver 2", true),
            new Driver(3,"Driver 3", true),
            new Driver(4,"Driver 4", true),
            new Driver(5,"Driver 5", true),
            new Driver(6,"Driver 6", true),
            new Driver(7,"Driver 7", true),
            new Driver(8,"Driver 8", true),
            new Driver(9,"Driver 9", true),
            new Driver(10,"Driver 10", true)
        };

        List<Driver> otherDrivers = new List<Driver>
        {
            new Driver(11,"Other Driver 1", false),
            new Driver(12,"Other Driver 2", false)
        };

        Vardiya vardiya = new Vardiya(mainDrivers, otherDrivers);

        vardiya.CreatePlan();
    }
}

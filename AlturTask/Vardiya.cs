using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlturTask
{
    public class Vardiya
    {
        private List<Driver> mainDrivers;
        private List<Driver> otherDrivers;

        private string[] daysOfWeek = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma" };
        private string[] timeOfDay = { "Gündüz", "Gece" };

        public Vardiya(List<Driver> mainDrivers, List<Driver> otherDrivers)
        {
            this.mainDrivers = mainDrivers;
            this.otherDrivers = otherDrivers;
        }

        public void CreatePlan()
        {
            int mainDriverIndex = 0;
            int otherDriverIndex = 0;
            int weekValue = 0;

            Console.WriteLine("Kaç haftalık vardiya planlamak istiyorsunuz?");
            string getInp = Console.ReadLine();

            if (int.TryParse(getInp, out weekValue))
            {
                for (int week = 1; week <= weekValue; week++)
                {
                    Console.WriteLine($"--- Hafta {week} ---");

                    for (int i = 0; i < daysOfWeek.Length; i++)
                    {
                        for (int j = 0; j < timeOfDay.Length; j++)
                        {
                            Console.WriteLine($"{daysOfWeek[i]} - {timeOfDay[j]} Vardiya:");
                            //5 ana sürücü
                            for (int k = 0; k < 5; k++)
                            {
                                if (mainDriverIndex >= mainDrivers.Count)
                                    mainDriverIndex = 0;

                                Console.WriteLine($" Ana Sürücü: {mainDrivers[mainDriverIndex].Name}");
                                mainDriverIndex++;
                            }

                            //yedek sürücünün devreye gir kontrolü
                            for (int k = 0; k < 2; k++)
                            {
                                if (otherDriverIndex >= otherDrivers.Count)
                                    otherDriverIndex = 0;

                                Console.WriteLine($" Yedek Sürücü: {otherDrivers[otherDriverIndex].Name}");
                                otherDriverIndex++;
                            }
                        }
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("Geçersiz bir sayı girdiniz!");
            }

           
        }
    }
}

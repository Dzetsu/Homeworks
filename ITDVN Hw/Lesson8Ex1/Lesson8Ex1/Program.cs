using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string birth = Console.ReadLine();
            BirthDay birthDay = new BirthDay(DateTime.Parse(birth));
            birthDay.ShowDays();
        }
    }

    class BirthDay
    {
        public DateTime DayOfBirth { get; private set; }
        public DateTime Today { get; private set; }

        public BirthDay(DateTime dayOfBirth)
        {
            DayOfBirth = dayOfBirth;
            Today = DateTime.Now;
        }

        public void ShowDays()
        {
            if (DayOfBirth.DayOfYear > Today.DayOfYear || DayOfBirth.DayOfYear == Today.DayOfYear)
                Console.WriteLine($"Осталось до дня рождения {DayOfBirth.DayOfYear - Today.DayOfYear}");
            if (DayOfBirth.DayOfYear < Today.DayOfYear)
                Console.WriteLine($"Осталось до дня рождения {365 + DayOfBirth.DayOfYear - Today.DayOfYear}");
        }
    }
}

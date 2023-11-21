using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Models
{
    public class CustomData
    {
        public int Day;
        public int Month;
        public int Year;

        public CustomData()
        {
            this.Day = 1;
            this.Month = 1;
            this.Year = 1;
        }

        public CustomData(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public void IncreaseYear()
        {
            Year++;
        }

        public void DecreaseDayBy2()
        {
            if (Day > 2)
            {
                Day -= 2;
            }
            else
            {
                if (Month > 1)
                {
                    Month--;
                    Day = 30;
                }
                else
                {
                    if (Year > 0)
                    {
                        Year--;
                        Month = 12;
                        Day = 30;
                    }
                }
            }
        }


        public override string ToString()
        {
            return $"Day: {Day}, Month: {Month}, Year: {Year}";
        }

        ~CustomData()
        {
            Console.WriteLine("Об'єкт зтертий з пам'яті");
        }
    }
}

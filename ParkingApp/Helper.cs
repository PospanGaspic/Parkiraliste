using System;
using System.Globalization;

namespace ParkingApp
{
    public class Helper
    {
        private static int[,] _calendar = new int[6, 7];
        
        public void CreateCalendar(int yearFromConsole, int monthFromConsole)
        {
            DateTime firstDayOfTheMonthDate = new DateTime(yearFromConsole, monthFromConsole, 1);
            DrawHeader(yearFromConsole, monthFromConsole);
            FillCalendar(firstDayOfTheMonthDate, yearFromConsole, monthFromConsole);
            DrawCalendar();
            
            Console.WriteLine();
            Console.Write("Choose day from calendar and enter it: ");
            
        }
        
        static void DrawHeader(int year, int month)
        {
            Console.Write("\n\n");
            Console.WriteLine(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month) + " " + year);
            Console.WriteLine("Mo Tu We Th Fr Sa Su");
        }

        static void FillCalendar(DateTime firstDayOfTheMonthDate, int year, int month)
        {
            int days = DateTime.DaysInMonth(year, month);
            int currentDay = 1;
            var dayOfWeek = (int) firstDayOfTheMonthDate.DayOfWeek;
            for (int i = 0; i <= _calendar.GetLength(0); i++)
            {
                for (int j = 0; j < _calendar.GetLength(1) && currentDay - dayOfWeek + 1 <= days; j++)
                {
                    
                    if (i == 0 && dayOfWeek > j)
                    {
                        _calendar[i, j] = 0;
                        dayOfWeek++;
                    }
                    else
                    {
                        _calendar[i, j] = currentDay - dayOfWeek + 1;
                    }
                    currentDay++;
                }
            }
        }

        static void DrawCalendar()
        {
            for (int i = 0; i < _calendar.GetLength(0); i++)
            {
                for (int j = 0; j < _calendar.GetLength(1); j++)
                {
                    if (_calendar[i, j] > 0)
                    {
                        if (_calendar[i, j] < 10)
                        {
                            Console.Write(" " + _calendar[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(_calendar[i, j] + " ");
                        }
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class DateTimeCase
    {
        public static void DateTimeCases()
        {
            DateTime now = DateTime.Now;

            int day = now.Day;
            int month = now.Month;  
            int year = now.Year;    
            int hour = now.Hour;
            int minute = now.Minute;
            int second = now.Second;

            //OnlyDate

            DateTime onlyDate = now.Date;
            Console.WriteLine($"Only Date : {onlyDate}");

            //DayOfWeek
            DayOfWeek dayOfWeek = now.DayOfWeek;
            DayOfWeek kamis = DayOfWeek.Thursday;

            //AddDays
            DateTime tomorow = now.AddDays(2);

            //SelisihHari
            TimeSpan DateDifference = tomorow - now;
            int daysRemaining = DateDifference.Days;
            Console.WriteLine($"{now} - {tomorow}, selisih : {daysRemaining}");


            //Strore Spesific Date
            DateTime birthDay = new DateTime(2000, 03, 07);
            Console.WriteLine($"Tanggal ulang tahun : {birthDay}");


        }
    }
}

using System;

namespace Sana04
{
    public class MyDate
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;

        
        public int PropYear
        {
            get { return Year; }
            set { if (value > 0) Year = value; }
        }
        public int PropMonth
        {
            get { return Month; }
            set { if (value >= 1 && value <= 12) Month = value; }
        }
        public int PropDay
        {
            get { return Day; }
            set { if (value >= 1 && value <= 31) Day = value; }
        }
        public int PropHours
        {
            get { return Hours; }
            set { if (value >= 0 && value < 24) Hours = value; }
        }
        public int PropMinutes
        {
            get { return Minutes; }
            set { if (value >= 0 && value < 60) Minutes = value; }
        }

        public MyDate()
        {
            Year = 2024; Month = 1; Day = 1; Hours = 0; Minutes = 0;
        }

        public MyDate(int year, int month, int day, int hours, int minutes)
        {
            Year = year; Month = month; Day = day; Hours = hours; Minutes = minutes;
        }

        public MyDate(int year, int month, int day)
        {
            Year = year; Month = month; Day = day; Hours = 0; Minutes = 0;
        }

        public MyDate(MyDate obj)
        {
            Year = obj.Year;
            Month = obj.Month;
            Day = obj.Day;
            Hours = obj.Hours;
            Minutes = obj.Minutes;
        }

        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day, Hours, Minutes, 0);
        }

        public override string ToString()
        {
            return $"{Day:D2}.{Month:D2}.{Year} {Hours:D2}:{Minutes:D2}";
        }
    }
}
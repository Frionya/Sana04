using System;

namespace Sana04
{
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected MyDate StartDate;
        protected MyDate FinishDate;

  
        public string PropStartCity { get { return StartCity; } set { StartCity = value; } }
        public string PropFinishCity { get { return FinishCity; } set { FinishCity = value; } }
        public MyDate PropStartDate { get { return StartDate; } set { StartDate = value; } }
        public MyDate PropFinishDate { get { return FinishDate; } set { FinishDate = value; } }

        public Airplane()
        {
            StartCity = "Kyiv";
            FinishCity = "Lviv";
            StartDate = new MyDate();
            FinishDate = new MyDate();
        }

        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane(string startCity, string finishCity)
        {
            StartCity = startCity;
            FinishCity = finishCity;
            StartDate = new MyDate(); 
            FinishDate = new MyDate();
        }

        public Airplane(Airplane obj)
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = new MyDate(obj.StartDate); 
            FinishDate = new MyDate(obj.FinishDate);
        }

 
        public int GetTotalTime()
        {
            
            TimeSpan diff = FinishDate.ToDateTime() - StartDate.ToDateTime();
            return (int)diff.TotalMinutes;
        }

        public bool IsArrivingToday()
        {
            return StartDate.PropYear == FinishDate.PropYear &&
                   StartDate.PropMonth == FinishDate.PropMonth &&
                   StartDate.PropDay == FinishDate.PropDay;
        }
    }
}
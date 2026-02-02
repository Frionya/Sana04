namespace Sana04
{
    public class Currency
    {
        protected string Name;
        protected double ExRate; 

      
        public string PropName { get { return Name; } set { Name = value; } }
        public double PropExRate
        {
            get { return ExRate; }
            set { if (value > 0) ExRate = value; }
        }

      
        public Currency()
        {
            Name = "USD";
            ExRate = 41.5;
        }

        public Currency(string name, double exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(string name)
        {
            Name = name;
            ExRate = 1.0; 
        }

        public Currency(Currency obj)
        {
            Name = obj.Name;
            ExRate = obj.ExRate;
        }
    }
}
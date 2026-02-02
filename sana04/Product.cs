namespace Sana04
{
    public class Product
    {
        protected string Name;
        protected double Price;
        protected Currency Cost;
        protected int Quantity;
        protected string Producer;
        protected double Weight;

        
        public string PropName { get { return Name; } set { Name = value; } }
        public double PropPrice { get { return Price; } set { if (value >= 0) Price = value; } }
        public Currency PropCost { get { return Cost; } set { Cost = value; } }
        public int PropQuantity { get { return Quantity; } set { if (value >= 0) Quantity = value; } }
        public string PropProducer { get { return Producer; } set { Producer = value; } }
        public double PropWeight { get { return Weight; } set { if (value >= 0) Weight = value; } }

       
        public Product()
        {
            Name = "Unknown";
            Price = 0;
            Cost = new Currency();
            Quantity = 0;
            Producer = "Unknown";
            Weight = 0;
        }

        public Product(string name, double price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(string name, double price, Currency cost)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Quantity = 0;
            Producer = "Unknown";
            Weight = 0;
        }

        public Product(Product obj)
        {
            Name = obj.Name;
            Price = obj.Price;
            Cost = new Currency(obj.Cost); 
            Quantity = obj.Quantity;
            Producer = obj.Producer;
            Weight = obj.Weight;
        }

        
        public double GetPriceInUAH()
        {
            return Price * Cost.PropExRate;
        }

        public double GetTotalPriceInUAH()
        {
            return GetPriceInUAH() * Quantity;
        }

        public double GetTotalWeight()
        {
            return Weight * Quantity;
        }
    }
}
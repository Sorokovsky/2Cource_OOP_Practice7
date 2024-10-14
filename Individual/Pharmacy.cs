namespace Individual
{
    public class Pharmacy
    {
        private int _price;

        public string Name { get; set; } = string.Empty;
        public int Price
        {
            get { return _price; }
            set { _price = value < 0 ? 0 : value; }
        }

        public Pharmacy(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price}";
        }

        public static Pharmacy Enter()
        {
            Console.Write("Enter a name: "); string name = Console.ReadLine();
            Console.Write("Enter a price: "); int price = Convert.ToInt32(Console.ReadLine());
            return new(name, price);
        }
    }
}

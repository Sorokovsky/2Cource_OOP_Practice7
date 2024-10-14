//variant 12
namespace Individual;
public static class Program
{
    public static void Main()
    {
        List<Pharmacy> pharmacies = new List<Pharmacy>();
        while (true)
        {
            try
            {
                int operation = ChooseOperation();
                switch (operation)
                {
                    case 0:
                        {
                            return;
                        }
                    case 1:
                        {
                            pharmacies.Add(Pharmacy.Enter());
                            break;
                        }
                    case 2:
                        {
                            int i = 1;
                            foreach(var item in pharmacies)
                            {
                                Console.WriteLine($"#{i}");
                                Console.WriteLine(item);
                                i++;
                            }
                            break;
                        }
                    case 3:
                        {
                            var founded = pharmacies.Where(x => x.Price >= 1000);
                            Console.WriteLine($"Pharmacies that price >= 1000.");
                            int i = 1;
                            foreach(var item in founded)
                            {
                                Console.WriteLine($"#{i}");
                                Console.WriteLine(item);
                            }
                            break;
                        }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                continue;
            }
        }
    }

    public static int ChooseOperation()
    {
        Console.WriteLine("Choose operation.");
        Console.WriteLine("0-Exit.");
        Console.WriteLine("1-Add new pharmacy");
        Console.WriteLine("2-Show all");
        Console.WriteLine("3-Show that price >= 1000uah.");
        Console.Write(">> ");
        return Convert.ToInt32(Console.ReadLine());
    }
}
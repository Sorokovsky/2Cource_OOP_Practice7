namespace Task_1;
public static class Program
{
    public static void Main()
    {
        List<Car> cars = new() 
        { 
            new("Audi", "V5", 2004, "Red"), new("Bug", "Seven", 2012, "White") 
        };
        List<CustomerInfo> customerInfos = new() 
        { 
            new("V5", "Andrey", "0985762225"),
            new("Seven", "Ihor", "068532145")
        };

        var items = customerInfos
            .Join(cars, customer => customer.CarModel, car => car.Model, (customer, car) => new
            {
                Name = customer.Name,
                Phone = customer.Phone,
                CarModel = car.Model,
                CreatedYear = car.Model,
                CarColor = car.Color,
                Mark = car.Mark,
            });

        foreach(var item in items)
        {
            Console.WriteLine("INFO");
            Console.WriteLine($"Name = {item.Name}");
            Console.WriteLine($"Phone = {item.Phone}");
            Console.WriteLine($"Car model = {item.CarModel}");
            Console.WriteLine($"Car created at = {item.CreatedYear}");
            Console.WriteLine($"Car color = {item.CarColor}");
            Console.WriteLine($"Car mark = {item.Mark}");
        }
    }
}
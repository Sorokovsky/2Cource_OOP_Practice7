namespace Task_2;
public static class Program
{
    public static void Main()
    {
        List<dynamic> list = new List<dynamic>() { 
            new { English = "Job", Ukraine = "Робота" },
            new { English = "Add", Ukraine = "Додавати" },
            new { English = "Subtract", Ukraine = "Віднімати" },
            new { English = "Multiply", Ukraine = "Множити" },
            new { English = "Divide", Ukraine = "Ділити" },
            new { English = "Influence", Ukraine = "Впливати" },
            new { English = "Improve", Ukraine = "Впроваджувати" },
            new { English = "Save", Ukraine = "Зберігати" },
            new { English = "Delete", Ukraine = "Видаляти" },
            new { English = "Restore", Ukraine = "Відновити" },
        };

        for(int i = 0; i < list.Count; i++)
        {
            var item = list.ElementAt(i);
            Console.WriteLine($"#{i + 1}");
            Console.WriteLine($"English: {item.English}");
            Console.WriteLine($"Ukraine: {item.Ukraine}");
        }
    }
}
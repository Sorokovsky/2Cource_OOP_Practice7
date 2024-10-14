namespace Task_1
{
    public class Car
    {
        private int _createdYear;

        public string Mark {  get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public int CreatedYear
        {
            get
            {
                return _createdYear;
            }
            set
            {
                _createdYear = value < 0 ? 0 : value;
            }
        }

        public Car(string mark, string model, int createdYear, string color)
        {
            Mark = mark;
            Model = model;
            CreatedYear = createdYear;
            Color = color;
        }
        public Car()
        {
            
        }
    }
}

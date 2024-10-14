namespace Task_1
{
    public class CustomerInfo
    {
        public string CarModel { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public CustomerInfo(string carModel, string name, string phone)
        {
            CarModel = carModel;
            Name = name;
            Phone = phone;
        }

        public CustomerInfo()
        {
            
        }
    }
}

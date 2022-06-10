namespace ConsoleApp1.Models
{
    class Room
    {
        public int Id { get; set; }
        private static int _id { get; set; }
        private static string _name { get; set; }
        private static double _price { get; set; }
        private static string _personCapacity { get; set; }

        public bool IsAviable { get; set; }

        public static int IdSum()
        {
            return _id++;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
            }
        }
        public string PersonCapacity
        {
            get { return _personCapacity; }
            set
            {
                _personCapacity = value;
            }
        }
        public Room(string name, double price, string personCapacity)
        {
            Id = IdSum();
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }
        public string ShowInfo()
        {
            return $"{Name}-Room name/{Price}-Room price/{PersonCapacity}-Person capacity/Avaible-{IsAviable}";
        }
        public override string ToString()
        {
            {
                return ShowInfo();
            }
        }
    }
}

namespace MyApp;

    public class Car
    {
        private string _name;
        private int _hp_power;
        private int _year;


        public string Name { get => _name; set => _name = value; }

        public int Horse_Power { get => _hp_power; set => _hp_power = value; }

        public int Year { get => _year; set => _year = value; }




        public Car(string name, int hp_power, int year) { _name = name; _hp_power = hp_power; _year = year; }

         public override string ToString()
        {
            return $"object: {_name} {_hp_power} {_year}";
        }

    }

public class PassengerCar : Car
{
    private int _AmountOfPasangers;
    private Dictionary<string, int> _service_book = new Dictionary<string, int>();

    public PassengerCar(string name, int hp_power, int year, int passengers) : base(name, hp_power, year)
    {
        _AmountOfPasangers = passengers;
    }

    public void AddToServiceBook(int year, string name)
    {
        _service_book.Add(name, year);
    }

    public void ShowServiceBook()
    {
        foreach (var element in _service_book)
        {
            Console.WriteLine($"> {element.Key} year: {element.Value}");
        }
    }

    public void ShowDetail(string name)
    {
        int year = _service_book[name];
        Console.WriteLine($"detail: {name} was repaired in >{year}<");
    }

    public override string ToString()
    {
        return $"{base.ToString()} {_AmountOfPasangers}";
    }
}

public class Truck : Car
{
    private int _maximum_trucking;
    private string _driver_Fio;
    private int _current_weight;
    private Dictionary<string, int> _weight_card = new Dictionary<string, int>();
    public Truck(string name, int hp_power, int year, int trucking, string FIO, int weight) : base(name, hp_power, year)
    {
        _maximum_trucking = trucking;
        _driver_Fio = FIO;
        _current_weight = weight;
    }

    public void EditFio(string name)
    {
        _driver_Fio = name;
    }

    public void AddCargo(string name, int weight)
    {
        _weight_card.Add(name, weight);
    }

    public void DeleteCargo(string name)
    {
        _weight_card.Remove(name);
    }

    public void ShowCargo()
    {
        foreach (var cargo in _weight_card)
        {
            Console.WriteLine($"> {cargo.Key} weight: {cargo.Value}");
        }
    }

    public override string ToString()
    {
        return $"{base.ToString()}\n >current: {_current_weight}\n >max: {_maximum_trucking}\n >FIO: {_driver_Fio}";
    }
}

public class Autopark
{
    private string _name;
    private List<Car> _AllCars = new List<Car>();

    public void Autpark(string name, List<Car> all)
    {
        _name = name;
        _AllCars = all;
    }
    
}
    
    
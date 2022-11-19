namespace MyApp;

public class Car
{
    private string _name;
    private int _hp_power;
    private int _year;
    

    public string Name { get => _name; set => _name = value; }
    public int Horse_Power { get => _hp_power; set => _hp_power = value; }
    public int Year { get => _year; set =>  _year = value; }
    



    public Car(string name, int hp_power, int year)
    {
        _name = name;
        _hp_power = hp_power;
        _year = year;
    }

    public override string ToString()
    {
        return $"> object: {_name} {_hp_power} {_year}";
    }
    
}
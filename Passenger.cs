using System.ComponentModel;

namespace HomeworkOOP;

public enum ServiceLevel
{
    Economy,Business,Premium
}

public class Passenger
{
    private int _id;
    private string _name;
    private int _passport;
    private ServiceLevel _serviceLevel;

    public int Passport => _passport;

    public Passenger(int id, string name, int passport, ServiceLevel serviceLevel)
    {
        _id = id;
        _name = name;
        _serviceLevel = serviceLevel;
        _passport = passport;
    }

    public bool IsPassportsNumbersSame(int passportNumber)
    {
        return (passportNumber == _passport);
    }
}
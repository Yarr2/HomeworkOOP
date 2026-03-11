using System.ComponentModel;
using System.Net.Mail;

namespace HomeworkOOP;

class Program
{
    static void Main(string[] args)
    {
        CompanyManager manager = new CompanyManager();
        Flight KyivLondon = new Flight(101, "London", "20:20, 12.08.25", 20, FlightStatus.Registration);
        Flight KyivWarsaw = new Flight(102, "Warsaw", "12:15, 26.10.25", 10, FlightStatus.Registration);
        manager.AddFlight(KyivWarsaw);
        manager.AddFlight(KyivLondon);

        Passenger passenger1 = new Passenger(101,"Yarema",86234340,ServiceLevel.Economy);
        Passenger passenger2 = new Passenger(102,"Anna",23406439,ServiceLevel.Business);
        Passenger passenger3 = new Passenger(103,"Petro",03948293,ServiceLevel.Premium);
        
        manager.RegisterPassenger(passenger1);
        manager.RegisterPassenger(passenger2);
        
        manager.PutPassengerIntoBoarding(passenger2,KyivLondon);
        manager.PutPassengerIntoBoarding(passenger2,KyivWarsaw);
        manager.OnboardNextPassenger();
        
        Console.WriteLine(manager.GetPassengerByPassport(86234340).Name);
        
        
        Console.WriteLine("\nAddPassengerToFlight method test:");
        KyivLondon.AddPassengerToFlight(passenger1);
        
        Console.WriteLine("\nChangeStatus method test:");
        KyivLondon.ChangeStatus();
        KyivLondon.ChangeStatus();
        KyivLondon.ChangeStatus();
        
        Console.WriteLine("\nFinishFlight method test:");
        manager.FinishFlight(KyivLondon);
        
        Console.WriteLine("\nFiltration test 1:");
        manager.FlightFiltration("London");
        Console.WriteLine("Filtration test 2:");
        manager.FlightFiltration(status:FlightStatus.Registration);
        Console.WriteLine("Filtration test 3:");
        manager.FlightFiltration();
        
        Console.WriteLine("\nHistory:");
        manager.PrintHistory();
    }
}
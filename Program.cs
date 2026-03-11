using System.ComponentModel;
using System.Net.Mail;

namespace HomeworkOOP;

class Program
{
    static void Main(string[] args)
    {
        CompanyManager manager = new CompanyManager();
        Flight KyivLondon = new Flight(101, "London", new DateTime(), 20, FlightStatus.Registration);
        Flight KyivWarsaw = new Flight(101, "London", new DateTime(), 10, FlightStatus.Registration);
        manager.AddFlight(KyivWarsaw);
        manager.AddFlight(KyivLondon);
        manager.AddFlight(KyivWarsaw);

        Passenger passenger1 = new Passenger(101,"Yarema",86234340,ServiceLevel.Economy);
        Passenger passenger2 = new Passenger(102,"Anna",23406439,ServiceLevel.Business);
        Passenger passenger3 = new Passenger(103,"Petro",03948293,ServiceLevel.Premium);
        
        manager.RegisterPassenger(passenger1);
        manager.RegisterPassenger(passenger2);
        
        manager.PutPassengerIntoBoarding(passenger2,KyivLondon);
        manager.PutPassengerIntoBoarding(passenger2,KyivWarsaw);
        manager.OnboardNextPassenger();
        
        //Segment for changing of  Flight attributes
        //End of Segment
        
        Console.WriteLine(manager.GetPassengerByPassport(86234340).Name);
    }
}
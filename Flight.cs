namespace HomeworkOOP;

public class Flight
{
    // PROPERTIES
    public int FlightNumber { get; private set; }
    public string Destination { get; private set; }
    public DateTime DepartureDateAndTime { get; private set; }
    public int Capacity { get; private set; }
    public FlightStatus Status { get; private set; }
    public List<Passenger> RegisteredPassengers { get; private set; } = new();

    // КОНСТРУКТОР
    public Flight(int flightNumber, string destination, DateTime departureDateAndTime, int capacity, FlightStatus status)
    {
        FlightNumber = flightNumber;
        Destination = destination;
        DepartureDateAndTime = departureDateAndTime;
        Capacity = capacity;
        Status = status;
    }

    // МЕТОДИ
    public void AddPassengerToFlight(Passenger passenger)
    {
        if (RegisteredPassengers.Count < Capacity)
        {
            RegisteredPassengers.Add(passenger);
            Console.WriteLine($"Passenger {passenger} added to the flight.");
        }
        else
        {
            Console.WriteLine($"Passenger {passenger} isn't added, not enough space.");
        }
    }

    public void ChangeStatus()
    {
        if (Status == FlightStatus.Arrived)
        {
            Console.WriteLine("Flight has already arrived. It's impossible to change status to next.");
        }
        else
        {
            Status = (FlightStatus)((int)Status + 1);
            Console.WriteLine($"Status {FlightNumber} changed to {Status}");
        }
    }
}

public enum FlightStatus
{
    Registration, 
    Boarding, 
    InFlight, 
    Arrived
}
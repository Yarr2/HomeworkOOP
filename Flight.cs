namespace HomeworkOOP;

public class Flight
{
    private int FlightNumber { get; set; }
    private string Destination { get; set; }
    private string DepartureDateAndTime { get; set; }
    private int Capacity { get; set; }
    private FlightStatus Status { get; set; }
    private List<Passenger> RegisteredPassengers { get; set; } = new();

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

    // public void ChangeStatus()
    // {
    //     flight.Status
    // }
}

public enum FlightStatus
{
    Registration, 
    Boarding, 
    InFlight, 
    Arrived
}
namespace HomeworkOOP;

public class CompanyManager
{
    private List<Flight> _flights = new List<Flight>();
    private Dictionary<int, Passenger> _passengers = new Dictionary<int, Passenger>();
    private Queue<Passenger> _boarding = new Queue<Passenger>();
    private Queue<Flight> _boardingFlights = new Queue<Flight>();
    private Stack<Flight> _history = new Stack<Flight>();

    public void AddFlight(Flight flight)
    {
        _flights.Add(flight);
    }

    public void RegisterPassenger(Passenger passenger)
    {
        if (_passengers.Keys.Contains(passenger.Passport))
        {
            throw new Exception("There is already passenger with this passport");
        }
        _passengers[passenger.Passport] = passenger;
    }

    public void PutPassengerIntoBoarding(Passenger passenger,Flight flight)
    {
        if (!(_flights.Contains(flight) &&
              _passengers.Values.Contains(passenger)))
        {
            throw new Exception("Either passenger is not registered or flight is not registered");
        }

        _boarding.Enqueue(passenger);
        _boardingFlights.Enqueue(flight);
    }

    public Passenger GetPassengerByPassport(int passport)
    {
        if (!_passengers.TryGetValue(passport, out Passenger passenger))
        {
            throw new Exception("There is no passenger with this passport");
        }

        return passenger;
    }

    public void OnboardNextPassenger()
    {
        if (_boarding.Count == 0) return;
        Flight flight = _boardingFlights.Dequeue();
        Passenger passenger = _boarding.Dequeue();
        flight.AddPassengerToFlight(passenger);
    }


    public void FinishFlight(Flight flight)
    {
        if (flight.Status != FlightStatus.Arrived)
        {
            _flights.Remove(flight);
            _history.Push(flight);
            Console.WriteLine($"Flight {flight.FlightNumber} finished.");
        }
        else
        {
            Console.WriteLine($"Can't finish the flight, current status {flight.Status}");
        }
    }
    
    public void FlightFiltration(string destination = null, FlightStatus? status = null) // ? makes unnullable type nullable 
    { 
        foreach (Flight flight in _flights)
        {
            if ((destination == null || destination == flight.Destination) &&
                (status == null || status == flight.Status))
            {
                Console.WriteLine($"Flight number {flight.FlightNumber}");
            }
        }
    }
    
}
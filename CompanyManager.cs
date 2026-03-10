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
    

    
}
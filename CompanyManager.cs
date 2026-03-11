namespace HomeworkOOP;

public class CompanyManager
{
    private List<Flight> _flights = new List<Flight>();
    private Dictionary<int, Passenger> _passengers = new Dictionary<int, Passenger>();
    private Queue<Passenger> _boarding = new Queue<Passenger>();
    private Stack<Flight> _history = new Stack<Flight>();

    public void AddFlight(Flight flight)
    {
        _flights.Add(flight);
    }
    
    
}
namespace HomeworkOOP;

public class CompanyManager
{
    private List<Flight> _flights = new List<Flight>();
    private Dictionary<int, Passanger> _passangers = new Dictionary<int, Passanger>();
    private Queue<Passanger> _boarding = new Queue<Passanger>();
    private Stack<Flight> _history = new Stack<Flight>();

    public void AddFlight(Flight flight)
    {
        _flights.Add(flight);
    }
    
}
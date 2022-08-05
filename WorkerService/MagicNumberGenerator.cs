namespace WorkerService;

public class MagicNumberGenerator : INumberService<int>
{
    public NumberServiceResult<int> GetNumber()
    {
        Random rnd = new Random();
        int val  = rnd.Next(40, 43);
        return new NumberServiceResult<int>() { Value = val };
    }
}
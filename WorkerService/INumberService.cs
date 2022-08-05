namespace WorkerService;

public record struct NumberServiceResult<T>
{
    public T Value { get; set; }
}
public interface INumberService<T>
{
    NumberServiceResult<T> GetNumber();
}

/// <summary>
/// 2. How does async/await work internally?
/// 
/// async methods return a Task or Task<T>, and the compiler transforms the method into a state machine. 
/// await releases the thread back to the thread pool and resumes it once the awaited task completes.
/// </summary>

class Program
{
    static async Task Main(string[] args)
    {
        // can be run without await
        Calculate();

        // other than void, compiler asks to use await
        await Fetch();

        Console.WriteLine("Hello");
    }

    // The return type of an async method must be 
    // void, 
    // Task, 
    // Task< T >, 
    // a task-like type, 
    // IAsyncEnumerable<T>, 
    // or IAsyncEnumerator<T>

    static async void Calculate()
    {
        // can be run without await
        Console.WriteLine("Calculating");
    }
    static async Task Fetch()
    {
        // other than void, compiler asks to use await
        Console.WriteLine("Fetching");
    }
}
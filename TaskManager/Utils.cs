
namespace TaskManager;

internal class Utils
{
    public void ClearConsole()
    {
        Thread.Sleep(5000);

        if (OperatingSystem.IsWindows() && Console.IsOutputRedirected == false)
            Console.Clear();

        Console.WriteLine(new string('\n', Console.WindowHeight));

    }
}

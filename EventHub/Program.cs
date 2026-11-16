using EventHub.Contexts;

namespace EventHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new EventHubDbContext();

            Console.WriteLine(
                context.Database.CanConnect()
                    ? "Database Connected Successfully!"
                    : "Database Connection Failed!");
        }
    }
}

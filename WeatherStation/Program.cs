using Repository;
using WeatherStation;

namespace Database;

public class Program
{
    public static void Main(string[] args)
    {
        using (var myContext = new MyApplycationContext())
        {
            myContext.Database.EnsureCreated();

            IUserRepository userRepository = new UserRepository(myContext);

            var randomUser = Random.Shared.Next(1000) + 1;
            Console.WriteLine(randomUser?.Name ?? "User doesn't exist");
        }
    }
}
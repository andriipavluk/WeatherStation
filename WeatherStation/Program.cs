using Repository;
using WeatherStation;

namespace Database;

public class Program
{
    public static void Main(string[] args)
    {
        using (var myContext = new WeatherStationContext())
        {
            myContext.Database.EnsureCreated();
            //IUserRepository user = new UI;
            var user = new UserRepository(context);
            var tempo = context.user.GetUser(1);
            Console.WriteLine(tempo.Name);
        }
    }
}
using Database;
using Repository;

namespace WeatherStation;

public class Program
{
    public static void Main(string[] args)
    {
        using (var myContext = new WeatherStationContext())
        {
            myContext.Database.EnsureCreated();
            IUserRepository userRepository = new UserRepository(myContext);

            var randomUserId = Random.Shared.Next(1000) + 1;
            var randomUser = (userRepository.GetUser(randomUserId));

            Console.WriteLine(randomUser?.Name?? "User doesn't exist");
        }
    }
}


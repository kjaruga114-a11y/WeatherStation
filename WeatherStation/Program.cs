using Database;

namespace WeatherStation;

public class Program
{
    public static void Main(string[] args)
    {
        using (var myContext = new WeatherStationContext())
        {
            myContext.Database.EnsureCreated();
            IUserRepository userRepository = new UserRepository(myContext);

            var user = userRepository.GetUser(11);
            Console.WriteLine(user.Name);
        }
    }
}


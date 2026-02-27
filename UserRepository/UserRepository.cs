using Database;

namespace Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly WeatherStationContext _dbContext;

        public UserRepository(WeatherStationContext dbContext)
        {
            _dbContext = dbContext;
        }
        public User? GetUser(int id)
        {
           return _dbContext.Set<User>()
                .FirstOrDefault(x => x.Id == id);
        }
    }
}

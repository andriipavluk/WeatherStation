using Database;

namespace Repository
{
    public interface IUserRepository
    {
        User? GetUser(int id);
    }
    public class UI : IUserRepository
    {
        public User? GetUser(int id)
        {
            return Console.WriteLine("User not found") as User;
        }
    }
}

using TimeClockLibrary;
using TimeClock.api.Properties.Models;

namespace TimeClock.api.Data
{
    public interface IUserRepo
    {
        bool SaveChanges();
        IEnumerable<User> GetAppUsers();
        User GetUserById(int id);   
        void CreateUser(User user);

    }
}

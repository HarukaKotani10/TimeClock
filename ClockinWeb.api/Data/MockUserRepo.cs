using TimeClockLibrary;
using TimeClock.api.Properties.Models;

namespace TimeClock.api.Data
{
    public class MockUserRepo : IUserRepo
    {
        public IEnumerable<User> GetAppUsers()
        {
            var users = new List<User>()
            {
                new User { UserID = 1, FirstName = "fsdfsd", LastName = "sfsdfsd", BranchID =1},
                new User { UserID = 2, FirstName = "tewfsdf", LastName = "sdfsd", BranchID =2}
            };

            return users;
        }

        public User GetUserById(int id)
        {
            return new User { UserID = 1, FirstName = "Haruka", LastName = "Kotani", BranchID =1};
        }

        void IUserRepo.CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        IEnumerable<User> IUserRepo.GetAppUsers()
        {
            throw new NotImplementedException();
        }

        User IUserRepo.GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        bool IUserRepo.SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
